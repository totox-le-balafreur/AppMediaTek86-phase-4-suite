namespace AppMediaTek86.view
{
    partial class FrmGestAbs
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
            this.groupBoxAjoutAbs = new System.Windows.Forms.GroupBox();
            this.btnAjConfirmer = new System.Windows.Forms.Button();
            this.cbBoxLstMotifsAj = new System.Windows.Forms.ComboBox();
            this.lblAjAbsFin = new System.Windows.Forms.Label();
            this.lblAjAbsDebut = new System.Windows.Forms.Label();
            this.dateTimePickerAjFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAjDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSupprAbs = new System.Windows.Forms.GroupBox();
            this.btnSupprConfirmer = new System.Windows.Forms.Button();
            this.groupBoxModAbs = new System.Windows.Forms.GroupBox();
            this.cbBoxLstMotifsMod = new System.Windows.Forms.ComboBox();
            this.lblModAbsDebut = new System.Windows.Forms.Label();
            this.btnModConfirmer = new System.Windows.Forms.Button();
            this.lblModAbsFin = new System.Windows.Forms.Label();
            this.dateTimePickerModFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerModDebut = new System.Windows.Forms.DateTimePicker();
            this.btnRetour = new System.Windows.Forms.Button();
            this.cbBoxLstAbs = new System.Windows.Forms.ComboBox();
            this.btnAjAbs = new System.Windows.Forms.Button();
            this.btnSupprAbs = new System.Windows.Forms.Button();
            this.btnModAbs = new System.Windows.Forms.Button();
            this.btnGestAbsEnregistrer = new System.Windows.Forms.Button();
            this.groupBoxAjoutAbs.SuspendLayout();
            this.groupBoxSupprAbs.SuspendLayout();
            this.groupBoxModAbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxLstMbre
            // 
            this.cbBoxLstMbre.FormattingEnabled = true;
            this.cbBoxLstMbre.Location = new System.Drawing.Point(12, 12);
            this.cbBoxLstMbre.Name = "cbBoxLstMbre";
            this.cbBoxLstMbre.Size = new System.Drawing.Size(166, 21);
            this.cbBoxLstMbre.TabIndex = 5;
            this.cbBoxLstMbre.Text = "Liste des membres";
            // 
            // groupBoxAjoutAbs
            // 
            this.groupBoxAjoutAbs.Controls.Add(this.btnAjConfirmer);
            this.groupBoxAjoutAbs.Controls.Add(this.cbBoxLstMotifsAj);
            this.groupBoxAjoutAbs.Controls.Add(this.lblAjAbsFin);
            this.groupBoxAjoutAbs.Controls.Add(this.lblAjAbsDebut);
            this.groupBoxAjoutAbs.Controls.Add(this.dateTimePickerAjFin);
            this.groupBoxAjoutAbs.Controls.Add(this.dateTimePickerAjDebut);
            this.groupBoxAjoutAbs.Enabled = false;
            this.groupBoxAjoutAbs.Location = new System.Drawing.Point(12, 94);
            this.groupBoxAjoutAbs.Name = "groupBoxAjoutAbs";
            this.groupBoxAjoutAbs.Size = new System.Drawing.Size(221, 178);
            this.groupBoxAjoutAbs.TabIndex = 6;
            this.groupBoxAjoutAbs.TabStop = false;
            this.groupBoxAjoutAbs.Text = "ajout";
            // 
            // btnAjConfirmer
            // 
            this.btnAjConfirmer.Location = new System.Drawing.Point(63, 143);
            this.btnAjConfirmer.Name = "btnAjConfirmer";
            this.btnAjConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnAjConfirmer.TabIndex = 5;
            this.btnAjConfirmer.Text = "Confirmer";
            this.btnAjConfirmer.UseVisualStyleBackColor = true;
            this.btnAjConfirmer.Click += new System.EventHandler(this.btnAjConfirmer_Click);
            // 
            // cbBoxLstMotifsAj
            // 
            this.cbBoxLstMotifsAj.FormattingEnabled = true;
            this.cbBoxLstMotifsAj.Location = new System.Drawing.Point(41, 116);
            this.cbBoxLstMotifsAj.Name = "cbBoxLstMotifsAj";
            this.cbBoxLstMotifsAj.Size = new System.Drawing.Size(125, 21);
            this.cbBoxLstMotifsAj.TabIndex = 4;
            this.cbBoxLstMotifsAj.Text = "Motif";
            // 
            // lblAjAbsFin
            // 
            this.lblAjAbsFin.AutoSize = true;
            this.lblAjAbsFin.Location = new System.Drawing.Point(9, 61);
            this.lblAjAbsFin.Name = "lblAjAbsFin";
            this.lblAjAbsFin.Size = new System.Drawing.Size(79, 13);
            this.lblAjAbsFin.TabIndex = 3;
            this.lblAjAbsFin.Text = "date de retour :";
            // 
            // lblAjAbsDebut
            // 
            this.lblAjAbsDebut.AutoSize = true;
            this.lblAjAbsDebut.Location = new System.Drawing.Point(6, 18);
            this.lblAjAbsDebut.Name = "lblAjAbsDebut";
            this.lblAjAbsDebut.Size = new System.Drawing.Size(79, 13);
            this.lblAjAbsDebut.TabIndex = 2;
            this.lblAjAbsDebut.Text = "date de debut :";
            // 
            // dateTimePickerAjFin
            // 
            this.dateTimePickerAjFin.Location = new System.Drawing.Point(6, 80);
            this.dateTimePickerAjFin.Name = "dateTimePickerAjFin";
            this.dateTimePickerAjFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAjFin.TabIndex = 1;
            // 
            // dateTimePickerAjDebut
            // 
            this.dateTimePickerAjDebut.Location = new System.Drawing.Point(6, 34);
            this.dateTimePickerAjDebut.Name = "dateTimePickerAjDebut";
            this.dateTimePickerAjDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAjDebut.TabIndex = 0;
            // 
            // groupBoxSupprAbs
            // 
            this.groupBoxSupprAbs.Controls.Add(this.btnSupprConfirmer);
            this.groupBoxSupprAbs.Enabled = false;
            this.groupBoxSupprAbs.Location = new System.Drawing.Point(260, 94);
            this.groupBoxSupprAbs.Name = "groupBoxSupprAbs";
            this.groupBoxSupprAbs.Size = new System.Drawing.Size(94, 74);
            this.groupBoxSupprAbs.TabIndex = 7;
            this.groupBoxSupprAbs.TabStop = false;
            this.groupBoxSupprAbs.Text = "suppression";
            // 
            // btnSupprConfirmer
            // 
            this.btnSupprConfirmer.Location = new System.Drawing.Point(6, 31);
            this.btnSupprConfirmer.Name = "btnSupprConfirmer";
            this.btnSupprConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprConfirmer.TabIndex = 7;
            this.btnSupprConfirmer.Text = "Confirmer";
            this.btnSupprConfirmer.UseVisualStyleBackColor = true;
            this.btnSupprConfirmer.Click += new System.EventHandler(this.btnSupprConfirmer_Click);
            // 
            // groupBoxModAbs
            // 
            this.groupBoxModAbs.Controls.Add(this.cbBoxLstMotifsMod);
            this.groupBoxModAbs.Controls.Add(this.lblModAbsDebut);
            this.groupBoxModAbs.Controls.Add(this.btnModConfirmer);
            this.groupBoxModAbs.Controls.Add(this.lblModAbsFin);
            this.groupBoxModAbs.Controls.Add(this.dateTimePickerModFin);
            this.groupBoxModAbs.Controls.Add(this.dateTimePickerModDebut);
            this.groupBoxModAbs.Enabled = false;
            this.groupBoxModAbs.Location = new System.Drawing.Point(384, 94);
            this.groupBoxModAbs.Name = "groupBoxModAbs";
            this.groupBoxModAbs.Size = new System.Drawing.Size(224, 178);
            this.groupBoxModAbs.TabIndex = 8;
            this.groupBoxModAbs.TabStop = false;
            this.groupBoxModAbs.Text = "modification";
            // 
            // cbBoxLstMotifsMod
            // 
            this.cbBoxLstMotifsMod.FormattingEnabled = true;
            this.cbBoxLstMotifsMod.Location = new System.Drawing.Point(35, 116);
            this.cbBoxLstMotifsMod.Name = "cbBoxLstMotifsMod";
            this.cbBoxLstMotifsMod.Size = new System.Drawing.Size(125, 21);
            this.cbBoxLstMotifsMod.TabIndex = 6;
            this.cbBoxLstMotifsMod.Text = "Motif";
            // 
            // lblModAbsDebut
            // 
            this.lblModAbsDebut.AutoSize = true;
            this.lblModAbsDebut.Location = new System.Drawing.Point(6, 18);
            this.lblModAbsDebut.Name = "lblModAbsDebut";
            this.lblModAbsDebut.Size = new System.Drawing.Size(79, 13);
            this.lblModAbsDebut.TabIndex = 6;
            this.lblModAbsDebut.Text = "date de debut :";
            // 
            // btnModConfirmer
            // 
            this.btnModConfirmer.Location = new System.Drawing.Point(65, 143);
            this.btnModConfirmer.Name = "btnModConfirmer";
            this.btnModConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnModConfirmer.TabIndex = 6;
            this.btnModConfirmer.Text = "Confirmer";
            this.btnModConfirmer.UseVisualStyleBackColor = true;
            this.btnModConfirmer.Click += new System.EventHandler(this.btnModConfirmer_Click);
            // 
            // lblModAbsFin
            // 
            this.lblModAbsFin.AutoSize = true;
            this.lblModAbsFin.Location = new System.Drawing.Point(6, 64);
            this.lblModAbsFin.Name = "lblModAbsFin";
            this.lblModAbsFin.Size = new System.Drawing.Size(79, 13);
            this.lblModAbsFin.TabIndex = 5;
            this.lblModAbsFin.Text = "date de retour :";
            // 
            // dateTimePickerModFin
            // 
            this.dateTimePickerModFin.Location = new System.Drawing.Point(6, 80);
            this.dateTimePickerModFin.Name = "dateTimePickerModFin";
            this.dateTimePickerModFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerModFin.TabIndex = 3;
            // 
            // dateTimePickerModDebut
            // 
            this.dateTimePickerModDebut.Location = new System.Drawing.Point(6, 34);
            this.dateTimePickerModDebut.Name = "dateTimePickerModDebut";
            this.dateTimePickerModDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerModDebut.TabIndex = 2;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(384, 294);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // cbBoxLstAbs
            // 
            this.cbBoxLstAbs.FormattingEnabled = true;
            this.cbBoxLstAbs.Location = new System.Drawing.Point(260, 12);
            this.cbBoxLstAbs.Name = "cbBoxLstAbs";
            this.cbBoxLstAbs.Size = new System.Drawing.Size(200, 21);
            this.cbBoxLstAbs.TabIndex = 9;
            this.cbBoxLstAbs.Text = "Liste des absences";
            // 
            // btnAjAbs
            // 
            this.btnAjAbs.Location = new System.Drawing.Point(13, 62);
            this.btnAjAbs.Name = "btnAjAbs";
            this.btnAjAbs.Size = new System.Drawing.Size(75, 23);
            this.btnAjAbs.TabIndex = 10;
            this.btnAjAbs.Text = "Ajouter";
            this.btnAjAbs.UseVisualStyleBackColor = true;
            this.btnAjAbs.Click += new System.EventHandler(this.btnAjAbs_Click);
            // 
            // btnSupprAbs
            // 
            this.btnSupprAbs.Location = new System.Drawing.Point(260, 62);
            this.btnSupprAbs.Name = "btnSupprAbs";
            this.btnSupprAbs.Size = new System.Drawing.Size(75, 23);
            this.btnSupprAbs.TabIndex = 11;
            this.btnSupprAbs.Text = "Supprimer";
            this.btnSupprAbs.UseVisualStyleBackColor = true;
            this.btnSupprAbs.Click += new System.EventHandler(this.btnSupprAbs_Click);
            // 
            // btnModAbs
            // 
            this.btnModAbs.Location = new System.Drawing.Point(384, 62);
            this.btnModAbs.Name = "btnModAbs";
            this.btnModAbs.Size = new System.Drawing.Size(75, 23);
            this.btnModAbs.TabIndex = 12;
            this.btnModAbs.Text = "Modifier";
            this.btnModAbs.UseVisualStyleBackColor = true;
            this.btnModAbs.Click += new System.EventHandler(this.btnModAbs_Click);
            // 
            // btnGestAbsEnregistrer
            // 
            this.btnGestAbsEnregistrer.Enabled = false;
            this.btnGestAbsEnregistrer.Location = new System.Drawing.Point(184, 294);
            this.btnGestAbsEnregistrer.Name = "btnGestAbsEnregistrer";
            this.btnGestAbsEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnGestAbsEnregistrer.TabIndex = 13;
            this.btnGestAbsEnregistrer.Text = "Enregistrer";
            this.btnGestAbsEnregistrer.UseVisualStyleBackColor = true;
            // 
            // FrmGestAbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 334);
            this.Controls.Add(this.btnGestAbsEnregistrer);
            this.Controls.Add(this.btnModAbs);
            this.Controls.Add(this.btnSupprAbs);
            this.Controls.Add(this.btnAjAbs);
            this.Controls.Add(this.cbBoxLstAbs);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.groupBoxModAbs);
            this.Controls.Add(this.groupBoxSupprAbs);
            this.Controls.Add(this.groupBoxAjoutAbs);
            this.Controls.Add(this.cbBoxLstMbre);
            this.Name = "FrmGestAbs";
            this.Text = "Gestion des absences";
            this.groupBoxAjoutAbs.ResumeLayout(false);
            this.groupBoxAjoutAbs.PerformLayout();
            this.groupBoxSupprAbs.ResumeLayout(false);
            this.groupBoxModAbs.ResumeLayout(false);
            this.groupBoxModAbs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxLstMbre;
        private System.Windows.Forms.GroupBox groupBoxAjoutAbs;
        private System.Windows.Forms.GroupBox groupBoxSupprAbs;
        private System.Windows.Forms.GroupBox groupBoxModAbs;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DateTimePicker dateTimePickerAjFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerAjDebut;
        private System.Windows.Forms.ComboBox cbBoxLstAbs;
        private System.Windows.Forms.Button btnAjAbs;
        private System.Windows.Forms.Button btnSupprAbs;
        private System.Windows.Forms.Button btnModAbs;
        private System.Windows.Forms.Button btnAjConfirmer;
        private System.Windows.Forms.ComboBox cbBoxLstMotifsAj;
        private System.Windows.Forms.Label lblAjAbsFin;
        private System.Windows.Forms.Label lblAjAbsDebut;
        private System.Windows.Forms.Label lblModAbsFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerModFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerModDebut;
        private System.Windows.Forms.Button btnSupprConfirmer;
        private System.Windows.Forms.Button btnModConfirmer;
        private System.Windows.Forms.Button btnGestAbsEnregistrer;
        private System.Windows.Forms.Label lblModAbsDebut;
        private System.Windows.Forms.ComboBox cbBoxLstMotifsMod;
    }
}