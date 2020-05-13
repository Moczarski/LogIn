namespace Delegaty8983
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zaloguj = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.Haslo = new System.Windows.Forms.Label();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Haslo_box = new System.Windows.Forms.TextBox();
            this.Tytul = new System.Windows.Forms.Label();
            this.In_psw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Zaloguj
            // 
            this.Zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Zaloguj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Zaloguj.Location = new System.Drawing.Point(148, 353);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(101, 47);
            this.Zaloguj.TabIndex = 0;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Anuluj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Anuluj.Location = new System.Drawing.Point(285, 353);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(101, 47);
            this.Anuluj.TabIndex = 1;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Login.Location = new System.Drawing.Point(43, 188);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(82, 29);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login:";
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Haslo.Location = new System.Drawing.Point(43, 267);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(85, 29);
            this.Haslo.TabIndex = 3;
            this.Haslo.Text = "Hasło:";
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(131, 195);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(255, 22);
            this.Login_box.TabIndex = 4;
            // 
            // Haslo_box
            // 
            this.Haslo_box.Location = new System.Drawing.Point(131, 274);
            this.Haslo_box.Name = "Haslo_box";
            this.Haslo_box.Size = new System.Drawing.Size(255, 22);
            this.Haslo_box.TabIndex = 5;
            this.Haslo_box.UseSystemPasswordChar = true;
            // 
            // Tytul
            // 
            this.Tytul.AutoSize = true;
            this.Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Tytul.Location = new System.Drawing.Point(141, 39);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(183, 39);
            this.Tytul.TabIndex = 6;
            this.Tytul.Text = "Zaloguj się";
            // 
            // In_psw
            // 
            this.In_psw.AutoSize = true;
            this.In_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.In_psw.ForeColor = System.Drawing.Color.Red;
            this.In_psw.Location = new System.Drawing.Point(210, 299);
            this.In_psw.Name = "In_psw";
            this.In_psw.Size = new System.Drawing.Size(0, 25);
            this.In_psw.TabIndex = 7;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.In_psw);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.Haslo_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Zaloguj);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logowanie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Haslo;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Haslo_box;
        private System.Windows.Forms.Label Tytul;
        private System.Windows.Forms.Label In_psw;
    }
}

