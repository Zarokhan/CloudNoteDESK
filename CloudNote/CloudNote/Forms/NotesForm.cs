using CloudNote.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudNote.Forms
{
    public partial class NotesForm : FixedForm
    {
        // Forms
        private LoginForm login;
        
        // User
        private int user_id = -1;

        public NotesForm()
        {
            InitializeComponent();
            this.Show();

            // Login window
            login = new LoginForm(this);
            login.ShowDialog();
        }

        public void AccessGranted(int id, string email)
        {
            this.user_id = id;
            this.EmailLabel.Text = email;
        }

        private void RefreshNotes()
        {

        }

        private void NoteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
