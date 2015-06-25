namespace CloudNote.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.AutoLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 22);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 48);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(71, 19);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(238, 20);
            this.EmailBox.TabIndex = 2;
            this.EmailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailBox_KeyPress);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(71, 45);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(238, 20);
            this.PassBox.TabIndex = 3;
            this.PassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassBox_KeyPress);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(71, 71);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // AutoLoginCheckBox
            // 
            this.AutoLoginCheckBox.AutoSize = true;
            this.AutoLoginCheckBox.Location = new System.Drawing.Point(71, 100);
            this.AutoLoginCheckBox.Name = "AutoLoginCheckBox";
            this.AutoLoginCheckBox.Size = new System.Drawing.Size(94, 17);
            this.AutoLoginCheckBox.TabIndex = 5;
            this.AutoLoginCheckBox.Text = "Remember me";
            this.AutoLoginCheckBox.UseVisualStyleBackColor = true;
            this.AutoLoginCheckBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoLoginCheckBox_KeyPress);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(152, 71);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 125);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.AutoLoginCheckBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Name = "LoginForm";
            this.Text = "CloudNote Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.CheckBox AutoLoginCheckBox;
        private System.Windows.Forms.Button RegisterBtn;
    }
}