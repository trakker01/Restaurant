namespace ProiectFinalForm.View
{
    partial class Menu
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
            this.btnDate = new System.Windows.Forms.Button();
            this.btnPreturiMeniu = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alegeti fereastra care doriti sa accesati";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(26, 83);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(159, 23);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "Datele contului";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnPreturiMeniu
            // 
            this.btnPreturiMeniu.Location = new System.Drawing.Point(26, 25);
            this.btnPreturiMeniu.Name = "btnPreturiMeniu";
            this.btnPreturiMeniu.Size = new System.Drawing.Size(159, 23);
            this.btnPreturiMeniu.TabIndex = 2;
            this.btnPreturiMeniu.Text = "Preturi meniuri";
            this.btnPreturiMeniu.UseVisualStyleBackColor = true;
            this.btnPreturiMeniu.Click += new System.EventHandler(this.btnPreturiMeniu_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(26, 54);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(159, 23);
            this.btnComanda.TabIndex = 3;
            this.btnComanda.Text = "Comandati";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(122, 112);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(100, 20);
            this.txtU.TabIndex = 6;
            this.txtU.Visible = false;
            this.txtU.WordWrap = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 127);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.btnPreturiMeniu);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnPreturiMeniu;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtU;
    }
}