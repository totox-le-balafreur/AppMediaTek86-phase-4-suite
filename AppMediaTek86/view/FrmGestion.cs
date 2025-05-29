using AppMediaTek86.controller;
using AppMediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaTek86.view
{
    /// <summary>
    /// fenetre permettant l'accés aux differentes fonctionnalites
    /// </summary>
    public partial class FrmGestion : Form
    {
        /// <summary>
        /// controleur de la fenetre
        /// </summary>
        private FrmGestionController controller;
        /// <summary>
        /// objet pour gerer la liste du personnel
        /// </summary>
        private BindingSource bdgMembre;
        /// <summary>
        /// initialisation des composant
        /// </summary>
        public FrmGestion()
        {
            InitializeComponent();
            Init();
            RemplirListeDuPersonnel();
        }
        /// <summary>
        /// initialise les composants
        /// </summary>
        private void Init()
        {
            bdgMembre = new BindingSource();
            controller = new FrmGestionController();
        }
        /// <summary>
        /// affiche la liste du personnel
        /// </summary>
        private void RemplirListeDuPersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bdgMembre.DataSource = lePersonnel;
            cbBoxLstMbre.DataSource = bdgMembre;
            cbBoxLstMbre.DisplayMember = "NomComplet";
            cbBoxLstMbre.ValueMember = "IdPersonnel";
        }
        /// <summary>
        /// bouton menant a FrmAjoutsMbre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjMbre_Click(object sender, EventArgs e)
        {
            FrmAjoutsMbre frmAj = new FrmAjoutsMbre();
            frmAj.ShowDialog();
        }
        /// <summary>
        /// Bouton menant a FrmSupprMbre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprMbre_Click(object sender, EventArgs e)
        {
            FrmSupprMbre frmSuppr = new FrmSupprMbre();
            frmSuppr.ShowDialog();

        }
        /// <summary>
        /// Bouton menant a FrmModMbre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModMbre_Click(object sender, EventArgs e)
        {
            FrmModMbre frmMod = new FrmModMbre();
            frmMod.ShowDialog();
        }
        /// <summary>
        /// Bouton menant a FrmGestAbs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestAbs_Click(object sender, EventArgs e)
        {
            FrmGestAbs frmGest = new FrmGestAbs();
            frmGest.ShowDialog();
        }
        /// <summary>
        /// bouton quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Message de confirmation avant de quitter
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment quitter l'application ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Ferme toutes les fenêtres de l'application
            }
        }
    }
}
