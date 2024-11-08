namespace Motivation
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
            this.buttonLos = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.labelAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLos
            // 
            this.buttonLos.Location = new System.Drawing.Point(13, 13);
            this.buttonLos.Name = "buttonLos";
            this.buttonLos.Size = new System.Drawing.Size(99, 23);
            this.buttonLos.TabIndex = 0;
            this.buttonLos.Text = "Los geht\'s!";
            this.buttonLos.UseVisualStyleBackColor = true;
            this.buttonLos.Click += new System.EventHandler(this.buttonLos_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(183, 13);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(99, 23);
            this.buttonAbbrechen.TabIndex = 1;
            this.buttonAbbrechen.Text = "Mir reicht\'s!";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // labelAusgabe
            // 
            this.labelAusgabe.AutoSize = true;
            this.labelAusgabe.Location = new System.Drawing.Point(12, 39);
            this.labelAusgabe.Name = "labelAusgabe";
            this.labelAusgabe.Size = new System.Drawing.Size(0, 13);
            this.labelAusgabe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 68);
            this.Controls.Add(this.labelAusgabe);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonLos);
            this.Name = "Form1";
            this.Text = "Zeitverschwender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLos;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Label labelAusgabe;
    }
}

