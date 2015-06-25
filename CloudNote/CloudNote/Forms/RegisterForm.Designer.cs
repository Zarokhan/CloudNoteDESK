namespace CloudNote.Forms
{
    partial class RegisterForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.PassBox1 = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Register account at CloudNote";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(12, 130);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(47, 13);
            this.WarningLabel.TabIndex = 7;
            this.WarningLabel.Text = "Warning";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(145, 106);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(223, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // PassBox2
            // 
            this.PassBox2.Location = new System.Drawing.Point(145, 80);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.PasswordChar = '*';
            this.PassBox2.Size = new System.Drawing.Size(223, 20);
            this.PassBox2.TabIndex = 5;
            this.PassBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassBox2_KeyPress);
            // 
            // PassBox1
            // 
            this.PassBox1.Location = new System.Drawing.Point(145, 54);
            this.PassBox1.Name = "PassBox1";
            this.PassBox1.PasswordChar = '*';
            this.PassBox1.Size = new System.Drawing.Size(223, 20);
            this.PassBox1.TabIndex = 4;
            this.PassBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassBox1_KeyPress);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(145, 28);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(223, 20);
            this.EmailBox.TabIndex = 3;
            this.EmailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the password again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 152);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.PassBox1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PassBox1;
        private System.Windows.Forms.TextBox PassBox2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label label4;
    }
}