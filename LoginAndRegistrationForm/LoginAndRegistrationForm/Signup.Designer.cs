namespace LoginAndRegistrationForm
{
    partial class Signup
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signup_Close = new System.Windows.Forms.Label();
            this.signup_Login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_ShowPassword = new System.Windows.Forms.CheckBox();
            this.signup_Button = new System.Windows.Forms.Button();
            this.signup_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginAndRegistrationForm.Properties.Resources.icons8_user_male_circle_104px_2;
            this.pictureBox1.Location = new System.Drawing.Point(69, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(95, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Started";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signup_Password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.signup_Close);
            this.panel1.Controls.Add(this.signup_Login);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_ShowPassword);
            this.panel1.Controls.Add(this.signup_Button);
            this.panel1.Controls.Add(this.signup_Username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signup_Email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 411);
            this.panel1.TabIndex = 1;
            // 
            // signup_Password
            // 
            this.signup_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Password.Location = new System.Drawing.Point(278, 247);
            this.signup_Password.Multiline = true;
            this.signup_Password.Name = "signup_Password";
            this.signup_Password.PasswordChar = '*';
            this.signup_Password.Size = new System.Drawing.Size(304, 30);
            this.signup_Password.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password:";
            // 
            // signup_Close
            // 
            this.signup_Close.AutoSize = true;
            this.signup_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Close.Location = new System.Drawing.Point(611, 7);
            this.signup_Close.Name = "signup_Close";
            this.signup_Close.Size = new System.Drawing.Size(18, 18);
            this.signup_Close.TabIndex = 10;
            this.signup_Close.Text = "X";
            this.signup_Close.Click += new System.EventHandler(this.signup_Close_Click);
            // 
            // signup_Login
            // 
            this.signup_Login.AutoSize = true;
            this.signup_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Login.ForeColor = System.Drawing.Color.DimGray;
            this.signup_Login.Location = new System.Drawing.Point(442, 379);
            this.signup_Login.Name = "signup_Login";
            this.signup_Login.Size = new System.Drawing.Size(80, 16);
            this.signup_Login.TabIndex = 9;
            this.signup_Login.Text = "Login here";
            this.signup_Login.Click += new System.EventHandler(this.signup_Login_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(311, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already have an account?";
            // 
            // signup_ShowPassword
            // 
            this.signup_ShowPassword.AutoSize = true;
            this.signup_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.signup_ShowPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup_ShowPassword.Location = new System.Drawing.Point(480, 283);
            this.signup_ShowPassword.Name = "signup_ShowPassword";
            this.signup_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.signup_ShowPassword.TabIndex = 7;
            this.signup_ShowPassword.Text = "Show Password";
            this.signup_ShowPassword.UseVisualStyleBackColor = false;
            this.signup_ShowPassword.CheckedChanged += new System.EventHandler(this.signup_ShowPassword_CheckedChanged);
            // 
            // signup_Button
            // 
            this.signup_Button.BackColor = System.Drawing.Color.MidnightBlue;
            this.signup_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_Button.FlatAppearance.BorderSize = 0;
            this.signup_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Button.ForeColor = System.Drawing.Color.White;
            this.signup_Button.Location = new System.Drawing.Point(278, 303);
            this.signup_Button.Name = "signup_Button";
            this.signup_Button.Size = new System.Drawing.Size(100, 35);
            this.signup_Button.TabIndex = 6;
            this.signup_Button.Text = "Sign up";
            this.signup_Button.UseVisualStyleBackColor = false;
            this.signup_Button.Click += new System.EventHandler(this.signup_Button_Click);
            // 
            // signup_Username
            // 
            this.signup_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Username.Location = new System.Drawing.Point(278, 181);
            this.signup_Username.Multiline = true;
            this.signup_Username.Name = "signup_Username";
            this.signup_Username.Size = new System.Drawing.Size(304, 30);
            this.signup_Username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // signup_Email
            // 
            this.signup_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_Email.Location = new System.Drawing.Point(278, 111);
            this.signup_Email.Multiline = true;
            this.signup_Email.Name = "signup_Email";
            this.signup_Email.Size = new System.Drawing.Size(304, 30);
            this.signup_Email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 411);
            this.panel2.TabIndex = 0;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_Close;
        private System.Windows.Forms.Label signup_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_ShowPassword;
        private System.Windows.Forms.Button signup_Button;
        private System.Windows.Forms.TextBox signup_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox signup_Password;
        private System.Windows.Forms.Label label8;
    }
}