namespace AppMediaTek86.view
{
    partial class FrmSupprMbre
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
            this.cbBoxLstMbre = new System.Windows.Forms.ComboBox();
            this.checkBoxSuppr = new System.Windows.Forms.CheckBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBoxLstMbre
            // 
            this.cbBoxLstMbre.FormattingEnabled = true;
            this.cbBoxLstMbre.Location = new System.Drawing.Point(33, 12);
            this.cbBoxLstMbre.Name = "cbBoxLstMbre";
            this.cbBoxLstMbre.Size = new System.Drawing.Size(166, 21);
            this.cbBoxLstMbre.TabIndex = 4;
            this.cbBoxLstMbre.Text = "Liste des membres";
            // 
            // checkBoxSuppr
            // 
            this.checkBoxSuppr.AutoSize = true;
            this.checkBoxSuppr.Location = new System.Drawing.Point(32, 44);
            this.checkBoxSuppr.Name = "checkBoxSuppr";
            this.checkBoxSuppr.Size = new System.Drawing.Size(72, 17);
            this.checkBoxSuppr.TabIndex = 5;
            this.checkBoxSuppr.Text = "Validation";
            this.checkBoxSuppr.UseVisualStyleBackColor = true;
            this.checkBoxSuppr.CheckedChanged += new System.EventHandler(this.checkBoxSuppr_CheckedChanged);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Enabled = false;
            this.btnSuppr.Location = new System.Drawing.Point(120, 40);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 6;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(80, 69);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // FrmSupprMbre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 110);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.checkBoxSuppr);
            this.Controls.Add(this.cbBoxLstMbre);
            this.Name = "FrmSupprMbre";
            this.Text = "Supprimer membre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxLstMbre;
        private System.Windows.Forms.CheckBox checkBoxSuppr;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnRetour;
    }
}