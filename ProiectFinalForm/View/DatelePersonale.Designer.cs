namespace ProiectFinalForm.View
{
    partial class DatelePersonale
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
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.Prenume = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.NameD = new System.Windows.Forms.Label();
            this.PrenumeD = new System.Windows.Forms.Label();
            this.UserD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(334, 334);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(100, 20);
            this.txtUtilizator.TabIndex = 0;
            this.txtUtilizator.Visible = false;
            this.txtUtilizator.WordWrap = false;
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(12, 9);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(38, 13);
            this.Nume.TabIndex = 1;
            this.Nume.Text = "Nume:";
            // 
            // Prenume
            // 
            this.Prenume.AutoSize = true;
            this.Prenume.Location = new System.Drawing.Point(12, 41);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(52, 13);
            this.Prenume.TabIndex = 2;
            this.Prenume.Text = "Prenume:";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(12, 68);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(61, 13);
            this.User.TabIndex = 3;
            this.User.Text = "User name:";
            // 
            // NameD
            // 
            this.NameD.AutoSize = true;
            this.NameD.Location = new System.Drawing.Point(56, 9);
            this.NameD.Name = "NameD";
            this.NameD.Size = new System.Drawing.Size(43, 13);
            this.NameD.TabIndex = 4;
            this.NameD.Text = "NumeD";
            // 
            // PrenumeD
            // 
            this.PrenumeD.AutoSize = true;
            this.PrenumeD.Location = new System.Drawing.Point(70, 41);
            this.PrenumeD.Name = "PrenumeD";
            this.PrenumeD.Size = new System.Drawing.Size(57, 13);
            this.PrenumeD.TabIndex = 5;
            this.PrenumeD.Text = "PrenumeD";
            // 
            // UserD
            // 
            this.UserD.AutoSize = true;
            this.UserD.Location = new System.Drawing.Point(79, 68);
            this.UserD.Name = "UserD";
            this.UserD.Size = new System.Drawing.Size(69, 13);
            this.UserD.TabIndex = 6;
            this.UserD.Text = "User nameD:";
            // 
            // DatelePersonale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 107);
            this.Controls.Add(this.UserD);
            this.Controls.Add(this.PrenumeD);
            this.Controls.Add(this.NameD);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.txtUtilizator);
            this.Name = "DatelePersonale";
            this.Text = "DatelePersonale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Prenume;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label NameD;
        private System.Windows.Forms.Label PrenumeD;
        private System.Windows.Forms.Label UserD;
    }
}