namespace Delegaty8983
{
    partial class New_user
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
            this.In_psw = new System.Windows.Forms.Label();
            this.New_password = new System.Windows.Forms.TextBox();
            this.New_login = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Create_NewUser = new System.Windows.Forms.Button();
            this.Create_admin = new System.Windows.Forms.CheckBox();
            this.admin = new System.Windows.Forms.Label();
            this.Login_exist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_user = new System.Windows.Forms.Button();
            this.users_box = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // In_psw
            // 
            this.In_psw.AutoSize = true;
            this.In_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.In_psw.ForeColor = System.Drawing.Color.Red;
            this.In_psw.Location = new System.Drawing.Point(195, 234);
            this.In_psw.Name = "In_psw";
            this.In_psw.Size = new System.Drawing.Size(0, 25);
            this.In_psw.TabIndex = 14;
            // 
            // New_password
            // 
            this.New_password.Location = new System.Drawing.Point(116, 201);
            this.New_password.Name = "New_password";
            this.New_password.Size = new System.Drawing.Size(255, 22);
            this.New_password.TabIndex = 13;
            this.New_password.UseSystemPasswordChar = true;
            // 
            // New_login
            // 
            this.New_login.Location = new System.Drawing.Point(116, 122);
            this.New_login.Name = "New_login";
            this.New_login.Size = new System.Drawing.Size(255, 22);
            this.New_login.TabIndex = 12;
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Haslo.Location = new System.Drawing.Point(28, 194);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(85, 29);
            this.Haslo.TabIndex = 11;
            this.Haslo.Text = "Hasło:";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Login.Location = new System.Drawing.Point(28, 115);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(82, 29);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login:";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Clear.Location = new System.Drawing.Point(270, 321);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(101, 47);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Czyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Create_NewUser
            // 
            this.Create_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Create_NewUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Create_NewUser.Location = new System.Drawing.Point(56, 321);
            this.Create_NewUser.Name = "Create_NewUser";
            this.Create_NewUser.Size = new System.Drawing.Size(101, 47);
            this.Create_NewUser.TabIndex = 8;
            this.Create_NewUser.Text = "Utwórz";
            this.Create_NewUser.UseVisualStyleBackColor = true;
            this.Create_NewUser.Click += new System.EventHandler(this.Create_NewUser_Click);
            // 
            // Create_admin
            // 
            this.Create_admin.AutoSize = true;
            this.Create_admin.Location = new System.Drawing.Point(116, 262);
            this.Create_admin.Name = "Create_admin";
            this.Create_admin.Size = new System.Drawing.Size(18, 17);
            this.Create_admin.TabIndex = 15;
            this.Create_admin.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.admin.Location = new System.Drawing.Point(17, 253);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(93, 29);
            this.admin.TabIndex = 16;
            this.admin.Text = "Admin:";
            // 
            // Login_exist
            // 
            this.Login_exist.AutoSize = true;
            this.Login_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_exist.ForeColor = System.Drawing.Color.Red;
            this.Login_exist.Location = new System.Drawing.Point(12, 150);
            this.Login_exist.Name = "Login_exist";
            this.Login_exist.Size = new System.Drawing.Size(0, 25);
            this.Login_exist.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(73, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Zarządzaj użytkownikami";
            // 
            // Delete_user
            // 
            this.Delete_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Delete_user.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Delete_user.Location = new System.Drawing.Point(163, 321);
            this.Delete_user.Name = "Delete_user";
            this.Delete_user.Size = new System.Drawing.Size(101, 47);
            this.Delete_user.TabIndex = 21;
            this.Delete_user.Text = "Usuń";
            this.Delete_user.UseVisualStyleBackColor = true;
            this.Delete_user.Click += new System.EventHandler(this.Delete_user_Click);
            // 
            // users_box
            // 
            this.users_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.users_box.FormattingEnabled = true;
            this.users_box.ItemHeight = 20;
            this.users_box.Location = new System.Drawing.Point(417, 11);
            this.users_box.Name = "users_box";
            this.users_box.Size = new System.Drawing.Size(980, 424);
            this.users_box.TabIndex = 20;
            // 
            // New_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1409, 450);
            this.Controls.Add(this.Delete_user);
            this.Controls.Add(this.users_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_exist);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.Create_admin);
            this.Controls.Add(this.In_psw);
            this.Controls.Add(this.New_password);
            this.Controls.Add(this.New_login);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Create_NewUser);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_user";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label In_psw;
        private System.Windows.Forms.TextBox New_password;
        private System.Windows.Forms.TextBox New_login;
        private System.Windows.Forms.Label Haslo;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Create_NewUser;
        private System.Windows.Forms.CheckBox Create_admin;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label Login_exist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_user;
        public System.Windows.Forms.ListBox users_box;
    }
}