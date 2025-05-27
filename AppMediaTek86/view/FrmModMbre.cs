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
    public partial class FrmModMbre : Form
    {
        /// <summary>
        /// controleur de la fenetre
        /// </summary>
        private FrmModMbreController controller;
        /// <summary>
        /// objet pour gerer la liste du personnel
        /// </summary>
        private BindingSource bdgMembre;
        /// <summary>
        /// objet pour gerer la liste des services
        /// </summary>
        private BindingSource bdgService;
        /// <summary>
        ///construction des composants graphiques et appel des autre initialisation
        /// </summary>
        public FrmModMbre()
        {
            InitializeComponent();
            Init();
            RemplirListeDuPersonnel();
            RemplirListeService();

            // Désactivation initiale
            checkBoxConfMod.Enabled = false;
            btnEnregMod.Enabled = false;

            // Événements de vérification
            txtBoxNom.TextChanged += Champs_TextChanged;
            txtBoxPrenom.TextChanged += Champs_TextChanged;
            txtMail.TextChanged += Champs_TextChanged;
            txtTel.TextChanged += Champs_TextChanged;
            cbBoxAffect.SelectedIndexChanged += Champs_TextChanged;
        }
        /// <summary>
        /// initialise les composants
        /// </summary>
        private void Init()
        {
            bdgMembre = new BindingSource();
            bdgService = new BindingSource();
            controller = new FrmModMbreController();
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
        /// affiche la liste des services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgService.DataSource = lesServices;
            cbBoxAffect.DataSource = bdgService;
            cbBoxAffect.DisplayMember = "Nom";
            cbBoxAffect.ValueMember = "Idservice";
        }
        /// <summary>
        /// Vérifie si tous les champs nécessaires sont remplis
        /// </summary>
        private void VerifierChamps()
        {
            bool tousChampsRemplis =
                !string.IsNullOrWhiteSpace(txtBoxNom.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxPrenom.Text) &&
                !string.IsNullOrWhiteSpace(txtMail.Text) &&
                !string.IsNullOrWhiteSpace(txtTel.Text) &&
                cbBoxAffect.SelectedIndex != -1;

            checkBoxConfMod.Enabled = tousChampsRemplis;
        }
        /// <summary>
        /// gestion centralisée des changements de champs
        /// </summary>
        private void Champs_TextChanged(object sender, EventArgs e)
        {
            VerifierChamps();
        }
        /// <summary>
        /// gere la fermeture de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// cocher pour activer l'enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxConfMod_CheckedChanged(object sender, EventArgs e)
        {
            btnEnregMod.Enabled = checkBoxConfMod.Checked;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            grpBoxModMbre.Enabled = true;

            Personnel personnel = (Personnel)bdgMembre.List[bdgMembre.Position];

            txtBoxNom.Text = personnel.Nom;
            txtBoxPrenom.Text = personnel.Prenom;
            txtMail.Text = personnel.Mail;
            txtTel.Text = personnel.Tel;
            cbBoxAffect.SelectedIndex = cbBoxAffect.FindStringExact(personnel.Service.Nom);

            VerifierChamps(); // Pour forcer une vérification à l’ouverture
        }

        private void btnEnregMod_Click(object sender, EventArgs e)
        {
            if (bdgMembre.Position < 0)
            {
                MessageBox.Show("Aucun membre sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Personnel personnel = (Personnel)bdgMembre.List[bdgMembre.Position];

            // Mise à jour des champs
            personnel.Nom = txtBoxNom.Text.Trim();
            personnel.Prenom = txtBoxPrenom.Text.Trim();
            personnel.Mail = txtMail.Text.Trim();
            personnel.Tel = txtTel.Text.Trim();
            personnel.Service = (Service)cbBoxAffect.SelectedItem;

            // Appel au contrôleur pour mettre à jour dans la base de données
            controller.UpdatePersonnel(personnel);
            MessageBox.Show("Modification enregistrée !");
        }
    }
}
