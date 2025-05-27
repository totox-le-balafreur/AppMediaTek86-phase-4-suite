namespace AppMediaTek86.view
{
    partial class FrmModMbre
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpBoxModMbre = new System.Windows.Forms.GroupBox();
            this.cbBoxAffect = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.checkBoxConfMod = new System.Windows.Forms.CheckBox();
            this.btnEnregMod = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpBoxModMbre.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxLstMbre
            // 
            this.cbBoxLstMbre.FormattingEnabled = true;
            this.cbBoxLstMbre.Location = new System.Drawing.Point(12, 12);
            this.cbBoxLstMbre.Name = "cbBoxLstMbre";
            this.cbBoxLstMbre.Size = new System.Drawing.Size(166, 21);
            this.cbBoxLstMbre.TabIndex = 4;
            this.cbBoxLstMbre.Text = "Liste des membres";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(228, 12);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // grpBoxModMbre
            // 
            this.grpBoxModMbre.Controls.Add(this.cbBoxAffect);
            this.grpBoxModMbre.Controls.Add(this.txtMail);
            this.grpBoxModMbre.Controls.Add(this.txtTel);
            this.grpBoxModMbre.Controls.Add(this.txtBoxPrenom);
            this.grpBoxModMbre.Controls.Add(this.txtBoxNom);
            this.grpBoxModMbre.Enabled = false;
            this.grpBoxModMbre.Location = new System.Drawing.Point(12, 41);
            this.grpBoxModMbre.Name = "grpBoxModMbre";
            this.grpBoxModMbre.Size = new System.Drawing.Size(301, 112);
            this.grpBoxModMbre.TabIndex = 6;
            this.grpBoxModMbre.TabStop = false;
            this.grpBoxModMbre.Text = "modifictaion";
            // 
            // cbBoxAffect
            // 
            this.cbBoxAffect.FormattingEnabled = true;
            this.cbBoxAffect.Location = new System.Drawing.Point(74, 81);
            this.cbBoxAffect.Name = "cbBoxAffect";
            this.cbBoxAffect.Size = new System.Drawing.Size(137, 21);
            this.cbBoxAffect.TabIndex = 6;
            this.cbBoxAffect.Text = "Services d\'affectation";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(140, 46);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(151, 20);
            this.txtMail.TabIndex = 5;
            this.txtMail.Text = "Mail";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(7, 46);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(112, 20);
            this.txtTel.TabIndex = 4;
            this.txtTel.Text = "Tel";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(140, 19);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(113, 20);
            this.txtBoxPrenom.TabIndex = 3;
            this.txtBoxPrenom.Text = "Prenom";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(6, 19);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(113, 20);
            this.txtBoxNom.TabIndex = 2;
            this.txtBoxNom.Text = "Nom";
            // 
            // checkBoxConfMod
            // 
            this.checkBoxConfMod.AutoSize = true;
            this.checkBoxConfMod.Enabled = false;
            this.checkBoxConfMod.Location = new System.Drawing.Point(12, 164);
            this.checkBoxConfMod.Name = "checkBoxConfMod";
            this.checkBoxConfMod.Size = new System.Drawing.Size(129, 17);
            this.checkBoxConfMod.TabIndex = 7;
            this.checkBoxConfMod.Text = "Confirmer modification";
            this.checkBoxConfMod.UseVisualStyleBackColor = true;
            // 
            // btnEnregMod
            // 
            this.btnEnregMod.Enabled = false;
            this.btnEnregMod.Location = new System.Drawing.Point(147, 160);
            this.btnEnregMod.Name = "btnEnregMod";
            this.btnEnregMod.Size = new System.Drawing.Size(75, 23);
            this.btnEnregMod.TabIndex = 8;
            this.btnEnregMod.Text = "Enregistrer";
            this.btnEnregMod.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(228, 160);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // ModMbre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 213);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregMod);
            this.Controls.Add(this.checkBoxConfMod);
            this.Controls.Add(this.grpBoxModMbre);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbBoxLstMbre);
            this.Name = "ModMbre";
            this.Text = "Modifier membre";
            this.grpBoxModMbre.ResumeLayout(false);
            this.grpBoxModMbre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxLstMbre;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grpBoxModMbre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.ComboBox cbBoxAffect;
        private System.Windows.Forms.CheckBox checkBoxConfMod;
        private System.Windows.Forms.Button btnEnregMod;
        private System.Windows.Forms.Button btnRetour;
    }
}