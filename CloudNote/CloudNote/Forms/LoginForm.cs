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
    public partial class LoginForm : FixedForm
    {
        private NotesForm parent;

        public LoginForm(NotesForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Make password encrypted
            byte[] encodedPassword = new UTF8Encoding().GetBytes(PassBox.Text);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

            // Checks if login is correct
            MySqlDataReader reader = SqlManager.RunQuery("SELECT * FROM Users WHERE email='" + EmailBox.Text.ToLower() + "' and pass='" + encoded + "';");

            // Determines if we get access
            int user_id = -1;
            string email = "";
            if (reader.Read())
            {
                user_id = reader.GetInt32(0);
                email = reader.GetString(1);
            }

            // Closes the sql connection
            SqlManager.CloseConnection(reader);
            
            // Access granted
            if (user_id != -1)
            {
                parent.AccessGranted(user_id, email);
                this.Close();
            }
            else
            {
                MessageBox.Show("Try again", "Login failed");
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            new RegisterForm();
        }

        private void EmailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginBtn_Click(null, null);
            }
        }

        private void PassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginBtn_Click(null, null);
            }
        }

        private void AutoLoginCheckBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
    }
}
