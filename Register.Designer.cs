
namespace Entertainment_Center_Database_Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.done = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check_confirmpassword = new System.Windows.Forms.CheckBox();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LeftPanel.Controls.Add(this.done);
            this.LeftPanel.Controls.Add(this.btn_return);
            this.LeftPanel.Controls.Add(this.pictureBox1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(261, 488);
            this.LeftPanel.TabIndex = 11;
            // 
            // done
            // 
            this.done.AutoSize = true;
            this.done.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(21, 347);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(211, 21);
            this.done.TabIndex = 4;
            this.done.Text = "Registration Complete?";
            // 
            // btn_return
            // 
            this.btn_return.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_return.Location = new System.Drawing.Point(34, 387);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(182, 52);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Return to Login Page!";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 118);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(694, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 23);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.password.Location = new System.Drawing.Point(313, 210);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 18);
            this.password.TabIndex = 17;
            this.password.Text = "Password:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.username.Location = new System.Drawing.Point(311, 130);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(88, 18);
            this.username.TabIndex = 16;
            this.username.Text = "Username:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(315, 240);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(300, 22);
            this.txt_password.TabIndex = 15;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(315, 163);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(300, 22);
            this.txt_username.TabIndex = 14;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(317, 387);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(108, 47);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Login.Location = new System.Drawing.Point(364, 65);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(279, 29);
            this.Login.TabIndex = 12;
            this.Login.Text = "Create a new account!";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(314, 331);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.PasswordChar = '*';
            this.txt_confirmpassword.Size = new System.Drawing.Size(300, 22);
            this.txt_confirmpassword.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(311, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Confirm Password:";
            // 
            // check_confirmpassword
            // 
            this.check_confirmpassword.AutoSize = true;
            this.check_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_confirmpassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.check_confirmpassword.Location = new System.Drawing.Point(486, 359);
            this.check_confirmpassword.Name = "check_confirmpassword";
            this.check_confirmpassword.Size = new System.Drawing.Size(142, 21);
            this.check_confirmpassword.TabIndex = 24;
            this.check_confirmpassword.Text = "Show Password";
            this.check_confirmpassword.UseVisualStyleBackColor = true;
            this.check_confirmpassword.CheckedChanged += new System.EventHandler(this.check_confirmpassword_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 488);
            this.Controls.Add(this.check_confirmpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_confirmpassword);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Label done;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_confirmpassword;
    }
}