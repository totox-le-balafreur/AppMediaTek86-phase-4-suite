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
    public partial class FrmSupprMbre : Form
    {
        /// <summary>
        /// controleur de la fenetre 
        /// </summary>
        private FrmSupprMbreController controller;
        /// <summary>
        /// objet pour gerer la liste du personnel
        /// </summary>
        private BindingSource bdgMembre;
        /// <summary>
        /// construction des composants graphiques et appel des autre initialisation
        /// </summary>
        public FrmSupprMbre()
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
            controller = new FrmSupprMbreController();
            bdgMembre = new BindingSource();
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
        /// deverouille le bouton de suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSuppr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSuppr.Checked)
            {
                btnSuppr.Enabled = true;
            }
            else 
            {
                btnSuppr.Enabled = false;
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (cbBoxLstMbre.SelectedItem is Personnel personnelSelectionne)
            {
                DialogResult res = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer {personnelSelectionne.Nom} {personnelSelectionne.Prenom} ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        controller.SupprPersonnel(personnelSelectionne);
                        MessageBox.Show("Suppression réussie.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemplirListeDuPersonnel();  // Rafraîchir la liste
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // ferme la fenetre
            this.Close();
        }
    }
}
