namespace AppMediaTek86.view
{
    partial class FrmAjoutsMbre
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
            this.grpBoxAjouts = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbBoxAffect = new System.Windows.Forms.ComboBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.btnAffMbre = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.cbBoxLstMbre = new System.Windows.Forms.ComboBox();
            this.grpBoxAjouts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAjouts
            // 
            this.grpBoxAjouts.Controls.Add(this.btnEnregistrer);
            this.grpBoxAjouts.Controls.Add(this.cbBoxAffect);
            this.grpBoxAjouts.Controls.Add(this.txtBoxPrenom);
            this.grpBoxAjouts.Controls.Add(this.txtBoxNom);
            this.grpBoxAjouts.Location = new System.Drawing.Point(13, 13);
            this.grpBoxAjouts.Name = "grpBoxAjouts";
            this.grpBoxAjouts.Size = new System.Drawing.Size(200, 130);
            this.grpBoxAjouts.TabIndex = 0;
            this.grpBoxAjouts.TabStop = false;
            this.grpBoxAjouts.Text = "Ajouts";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.Location = new System.Drawing.Point(7, 102);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // cbBoxAffect
            // 
            this.cbBoxAffect.FormattingEnabled = true;
            this.cbBoxAffect.Location = new System.Drawing.Point(7, 74);
            this.cbBoxAffect.Name = "cbBoxAffect";
            this.cbBoxAffect.Size = new System.Drawing.Size(137, 21);
            this.cbBoxAffect.TabIndex = 2;
            this.cbBoxAffect.Text = "Services d\'affectation";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(7, 47);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(113, 20);
            this.txtBoxPrenom.TabIndex = 1;
            this.txtBoxPrenom.Text = "Prenom";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(7, 20);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(113, 20);
            this.txtBoxNom.TabIndex = 0;
            this.txtBoxNom.Text = "Nom";
            // 
            // btnAffMbre
            // 
            this.btnAffMbre.Location = new System.Drawing.Point(20, 150);
            this.btnAffMbre.Name = "btnAffMbre";
            this.btnAffMbre.Size = new System.Drawing.Size(100, 23);
            this.btnAffMbre.TabIndex = 1;
            this.btnAffMbre.Text = "Afficher membres";
            this.btnAffMbre.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(138, 149);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // cbBoxLstMbre
            // 
            this.cbBoxLstMbre.FormattingEnabled = true;
            this.cbBoxLstMbre.Location = new System.Drawing.Point(20, 179);
            this.cbBoxLstMbre.Name = "cbBoxLstMbre";
            this.cbBoxLstMbre.Size = new System.Drawing.Size(166, 21);
            this.cbBoxLstMbre.TabIndex = 3;
            this.cbBoxLstMbre.Text = "Liste des membres";
            // 
            // AjoutsMbre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 215);
            this.Controls.Add(this.cbBoxLstMbre);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAffMbre);
            this.Controls.Add(this.grpBoxAjouts);
            this.Name = "AjoutsMbre";
            this.Text = "Ajouts membres";
            this.grpBoxAjouts.ResumeLayout(false);
            this.grpBoxAjouts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAjouts;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.ComboBox cbBoxAffect;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAffMbre;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ComboBox cbBoxLstMbre;
    }
}