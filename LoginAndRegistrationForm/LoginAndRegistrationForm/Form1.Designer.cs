namespace LoginAndRegistrationForm
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_Close = new System.Windows.Forms.Label();
            this.login_Register = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_ShowPassword = new System.Windows.Forms.CheckBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.login_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.login_Close);
            this.panel1.Controls.Add(this.login_Register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.login_ShowPassword);
            this.panel1.Controls.Add(this.login_Button);
            this.panel1.Controls.Add(this.login_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 411);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login_Close
            // 
            this.login_Close.AutoSize = true;
            this.login_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Close.Location = new System.Drawing.Point(612, 6);
            this.login_Close.Name = "login_Close";
            this.login_Close.Size = new System.Drawing.Size(18, 18);
            this.login_Close.TabIndex = 10;
            this.login_Close.Text = "X";
            this.login_Close.Click += new System.EventHandler(this.login_Close_Click);
            // 
            // login_Register
            // 
            this.login_Register.AutoSize = true;
            this.login_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Register.ForeColor = System.Drawing.Color.DimGray;
            this.login_Register.Location = new System.Drawing.Point(434, 379);
            this.login_Register.Name = "login_Register";
            this.login_Register.Size = new System.Drawing.Size(101, 16);
            this.login_Register.TabIndex = 9;
            this.login_Register.Text = "Register here";
            this.login_Register.Click += new System.EventHandler(this.login_Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(311, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t have an account?";
            // 
            // login_ShowPassword
            // 
            this.login_ShowPassword.AutoSize = true;
            this.login_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.login_ShowPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_ShowPassword.Location = new System.Drawing.Point(480, 255);
            this.login_ShowPassword.Name = "login_ShowPassword";
            this.login_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.login_ShowPassword.TabIndex = 7;
            this.login_ShowPassword.Text = "Show Password";
            this.login_ShowPassword.UseVisualStyleBackColor = false;
            this.login_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.MidnightBlue;
            this.login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_Button.FlatAppearance.BorderSize = 0;
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.ForeColor = System.Drawing.Color.White;
            this.login_Button.Location = new System.Drawing.Point(278, 292);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(100, 35);
            this.login_Button.TabIndex = 6;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // login_Password
            // 
            this.login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Password.Location = new System.Drawing.Point(278, 219);
            this.login_Password.Multiline = true;
            this.login_Password.Name = "login_Password";
            this.login_Password.PasswordChar = '*';
            this.login_Password.Size = new System.Drawing.Size(304, 30);
            this.login_Password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // login_Name
            // 
            this.login_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Name.Location = new System.Drawing.Point(278, 150);
            this.login_Name.Multiline = true;
            this.login_Name.Name = "login_Name";
            this.login_Name.Size = new System.Drawing.Size(304, 30);
            this.login_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back!";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginAndRegistrationForm.Properties.Resources.icons8_user_male_circle_104px_2;
            this.pictureBox1.Location = new System.Drawing.Point(69, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox login_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox login_ShowPassword;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label login_Register;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label login_Close;
    }
}

