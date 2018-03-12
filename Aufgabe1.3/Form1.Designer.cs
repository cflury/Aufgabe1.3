namespace Aufgabe1._3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGutenTag = new System.Windows.Forms.Label();
            this.btnTschuess = new System.Windows.Forms.Button();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnGross = new System.Windows.Forms.Button();
            this.btnRot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGutenTag
            // 
            this.lblGutenTag.AutoSize = true;
            this.lblGutenTag.Location = new System.Drawing.Point(17, 36);
            this.lblGutenTag.Name = "lblGutenTag";
            this.lblGutenTag.Size = new System.Drawing.Size(183, 13);
            this.lblGutenTag.TabIndex = 0;
            this.lblGutenTag.Text = "Guten Tag! mein zweites C#-Projekt. ";
            // 
            // btnTschuess
            // 
            this.btnTschuess.Location = new System.Drawing.Point(344, 106);
            this.btnTschuess.Name = "btnTschuess";
            this.btnTschuess.Size = new System.Drawing.Size(102, 28);
            this.btnTschuess.TabIndex = 1;
            this.btnTschuess.Text = "Tschüss";
            this.btnTschuess.UseVisualStyleBackColor = true;
            this.btnTschuess.Click += new System.EventHandler(this.btnTschuess_Click);
            // 
            // btnZurueck
            // 
            this.btnZurueck.Location = new System.Drawing.Point(236, 106);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(102, 28);
            this.btnZurueck.TabIndex = 1;
            this.btnZurueck.Text = "Zurücksetzen";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnGross
            // 
            this.btnGross.Location = new System.Drawing.Point(128, 106);
            this.btnGross.Name = "btnGross";
            this.btnGross.Size = new System.Drawing.Size(102, 28);
            this.btnGross.TabIndex = 1;
            this.btnGross.Text = "Grosse Schrift";
            this.btnGross.UseVisualStyleBackColor = true;
            this.btnGross.Click += new System.EventHandler(this.btnGross_Click);
            // 
            // btnRot
            // 
            this.btnRot.Location = new System.Drawing.Point(20, 106);
            this.btnRot.Name = "btnRot";
            this.btnRot.Size = new System.Drawing.Size(102, 28);
            this.btnRot.TabIndex = 1;
            this.btnRot.Text = "Rot";
            this.btnRot.UseVisualStyleBackColor = true;
            this.btnRot.Click += new System.EventHandler(this.btnRot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 159);
            this.Controls.Add(this.btnRot);
            this.Controls.Add(this.btnGross);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.btnTschuess);
            this.Controls.Add(this.lblGutenTag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGutenTag;
        private System.Windows.Forms.Button btnTschuess;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnGross;
        private System.Windows.Forms.Button btnRot;
    }
}

