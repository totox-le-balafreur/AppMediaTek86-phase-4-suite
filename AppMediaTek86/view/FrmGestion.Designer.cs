namespace AppMediaTek86.view
{
    partial class FrmGestion
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
            this.grpBoxGest = new System.Windows.Forms.GroupBox();
            this.btnGestAbs = new System.Windows.Forms.Button();
            this.btnModMbre = new System.Windows.Forms.Button();
            this.btnSupprMbre = new System.Windows.Forms.Button();
            this.btnAjMbre = new System.Windows.Forms.Button();
            this.cbBoxLstMbre = new System.Windows.Forms.ComboBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpBoxGest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGest
            // 
            this.grpBoxGest.Controls.Add(this.btnGestAbs);
            this.grpBoxGest.Controls.Add(this.btnModMbre);
            this.grpBoxGest.Controls.Add(this.btnSupprMbre);
            this.grpBoxGest.Controls.Add(this.btnAjMbre);
            this.grpBoxGest.Location = new System.Drawing.Point(26, 12);
            this.grpBoxGest.Name = "grpBoxGest";
            this.grpBoxGest.Size = new System.Drawing.Size(173, 154);
            this.grpBoxGest.TabIndex = 0;
            this.grpBoxGest.TabStop = false;
            this.grpBoxGest.Text = "Gestion du personnel";
            // 
            // btnGestAbs
            // 
            this.btnGestAbs.Location = new System.Drawing.Point(23, 110);
            this.btnGestAbs.Name = "btnGestAbs";
            this.btnGestAbs.Size = new System.Drawing.Size(124, 23);
            this.btnGestAbs.TabIndex = 3;
            this.btnGestAbs.Text = "Gestion des absences";
            this.btnGestAbs.UseVisualStyleBackColor = true;
            this.btnGestAbs.Click += new System.EventHandler(this.btnGestAbs_Click);
            // 
            // btnModMbre
            // 
            this.btnModMbre.Location = new System.Drawing.Point(23, 80);
            this.btnModMbre.Name = "btnModMbre";
            this.btnModMbre.Size = new System.Drawing.Size(124, 23);
            this.btnModMbre.TabIndex = 2;
            this.btnModMbre.Text = "Modifier membre";
            this.btnModMbre.UseVisualStyleBackColor = true;
            this.btnModMbre.Click += new System.EventHandler(this.btnModMbre_Click);
            // 
            // btnSupprMbre
            // 
            this.btnSupprMbre.Location = new System.Drawing.Point(23, 50);
            this.btnSupprMbre.Name = "btnSupprMbre";
            this.btnSupprMbre.Size = new System.Drawing.Size(124, 23);
            this.btnSupprMbre.TabIndex = 1;
            this.btnSupprMbre.Text = "Supprimer membre";
            this.btnSupprMbre.UseVisualStyleBackColor = true;
            this.btnSupprMbre.Click += new System.EventHandler(this.btnSupprMbre_Click);
            // 
            // btnAjMbre
            // 
            this.btnAjMbre.Location = new System.Drawing.Point(23, 20);
            this.btnAjMbre.Name = "btnAjMbre";
            this.btnAjMbre.Size = new System.Drawing.Size(124, 23);
            this.btnAjMbre.TabIndex = 0;
            this.btnAjMbre.Text = "Ajouter membre";
            this.btnAjMbre.UseVisualStyleBackColor = true;
            this.btnAjMbre.Click += new System.EventHandler(this.btnAjMbre_Click);
            // 
            // cbBoxLstMbre
            // 
            this.cbBoxLstMbre.FormattingEnabled = true;
            this.cbBoxLstMbre.Location = new System.Drawing.Point(26, 172);
            this.cbBoxLstMbre.Name = "cbBoxLstMbre";
            this.cbBoxLstMbre.Size = new System.Drawing.Size(173, 21);
            this.cbBoxLstMbre.TabIndex = 1;
            this.cbBoxLstMbre.Text = "Liste des membres";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(68, 199);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 235);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cbBoxLstMbre);
            this.Controls.Add(this.grpBoxGest);
            this.Name = "FrmGestion";
            this.Text = "Gestion";
            this.grpBoxGest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGest;
        private System.Windows.Forms.Button btnGestAbs;
        private System.Windows.Forms.Button btnModMbre;
        private System.Windows.Forms.Button btnSupprMbre;
        private System.Windows.Forms.Button btnAjMbre;
        private System.Windows.Forms.ComboBox cbBoxLstMbre;
        private System.Windows.Forms.Button btnQuit;
    }
}