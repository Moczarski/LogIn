namespace Delegaty8983
{
    partial class Komunikat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Uzytkownik = new System.Windows.Forms.Label();
            this.Ranga = new System.Windows.Forms.Label();
            this.Creating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rank:";
            // 
            // Uzytkownik
            // 
            this.Uzytkownik.AutoSize = true;
            this.Uzytkownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uzytkownik.Location = new System.Drawing.Point(146, 39);
            this.Uzytkownik.Name = "Uzytkownik";
            this.Uzytkownik.Size = new System.Drawing.Size(179, 38);
            this.Uzytkownik.TabIndex = 2;
            this.Uzytkownik.Text = "uzytkownik";
            // 
            // Ranga
            // 
            this.Ranga.AutoSize = true;
            this.Ranga.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ranga.Location = new System.Drawing.Point(146, 107);
            this.Ranga.Name = "Ranga";
            this.Ranga.Size = new System.Drawing.Size(100, 38);
            this.Ranga.TabIndex = 3;
            this.Ranga.Text = "ranga";
            // 
            // Creating
            // 
            this.Creating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Creating.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Creating.Location = new System.Drawing.Point(436, 39);
            this.Creating.Name = "Creating";
            this.Creating.Size = new System.Drawing.Size(197, 106);
            this.Creating.TabIndex = 5;
            this.Creating.Text = "Menadżer użytkowników";
            this.Creating.UseVisualStyleBackColor = true;
            this.Creating.Click += new System.EventHandler(this.Creating_Click);
            // 
            // Komunikat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(645, 197);
            this.Controls.Add(this.Creating);
            this.Controls.Add(this.Ranga);
            this.Controls.Add(this.Uzytkownik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Komunikat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Description";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Komunikat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Uzytkownik;
        private System.Windows.Forms.Label Ranga;
        private System.Windows.Forms.Button Creating;
    }
}