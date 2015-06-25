using CloudNote.SQL;
using CloudNote.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudNote.Forms
{
    public partial class RegisterForm : FixedForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.init();
            this.ShowDialog();
        }

        private void init()
        {
            this.WarningLabel.Text = "";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = EmailBox.Text.ToLower();
            string pass1 = PassBox1.Text;
            string pass2 = PassBox2.Text;

            // Check if username is empty
            if (username == "")
            {
                WarningLabel.Text = "Account textbox is empty.";
                return;
            }

            // Check if valid email
            if (!username.Contains("@") || username.Length < 5 || !username.Contains("."))
            {
                WarningLabel.Text = "Not valid email.";
                return;
            }

            // Check if both password boxes match
            if (pass1 != pass2)
            {
                WarningLabel.Text = "Passwords dont match.";
                return;
            }

            // Minimum password lenght acceptance
            if (pass1.Length < 8)
            {
                WarningLabel.Text = "Password is to short.";
                return;
            }

            // Check if username already exist in database
            MySqlDataReader reader = SqlManager.RunQuery("SELECT * FROM users WHERE email = '" + username + "';");
            if (reader.Read())
            {
                WarningLabel.Text = "Email already registered.";
                SqlManager.CloseConnection(reader);
                return;
            }

            // Make password encrypted
            byte[] encodedPassword = new UTF8Encoding().GetBytes(pass1);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

            // Register user
            reader = SqlManager.RunQuery("INSERT INTO Users (email, pass) " +
                                            "VALUES ('" + username + "', '" + encoded + "');");
            SqlManager.CloseConnection(reader);
            WarningLabel.Text = "";

            this.Close();
        }

        /*
         * Controll the flow with the enter key
         */

        private void EmailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RegisterBtn_Click(null, null);
            }
        }

        private void PassBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RegisterBtn_Click(null, null);
            }
        }

        private void PassBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RegisterBtn_Click(null, null);
            }
        }
    }
}
