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
    /// fenetre qui gere l'ajout de personnel
    /// </summary>
    public partial class FrmAjoutsMbre : Form
    {
        /// <summary>
        /// Controleur de la fenetre
        /// </summary>
        FrmAjoutsMbreController controller;
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
        public FrmAjoutsMbre()
        {
            InitializeComponent();
            Init();
            RemplirListeDuPersonnel();
            RemplirListeService();
            // On abonne les événements
            txtBoxNom.TextChanged += ChampsModifies;
            txtBoxPrenom.TextChanged += ChampsModifies;
            cbBoxAffect.SelectedIndexChanged += ChampsModifies;

            // On fait une vérification initiale
            VerifierChamps();
        }
        /// <summary>
        /// initialise les composants
        /// </summary>
        private void Init() 
        {
            bdgMembre = new BindingSource();
            controller = new FrmAjoutsMbreController();
            bdgService = new BindingSource();
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
        /// vérifie si tous les champs obligatoires sont remplis
        /// </summary>
        private void VerifierChamps()
        {
            btnEnregistrer.Enabled =
                !string.IsNullOrWhiteSpace(txtBoxNom.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxPrenom.Text) &&
                cbBoxAffect.SelectedIndex != -1;
        }
        /// <summary>
        /// appelé à chaque modification des champs
        /// </summary>
        private void ChampsModifies(object sender, EventArgs e)
        {
            VerifierChamps();
        }
        /// <summary>
        /// gere l'affichage de la liste du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAffMbre_Click(object sender, EventArgs e)
        {
            cbBoxLstMbre.Visible = true;
        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un membre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// gere la fermeture de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            // ferme la fenetre
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtBoxNom.Text.Equals("") && !txtBoxPrenom.Text.Equals("") && cbBoxAffect.SelectedIndex != -1)
            {
                Service service = (Service)cbBoxAffect.SelectedItem;
                Personnel personnel = new Personnel(0, txtBoxNom.Text, txtBoxPrenom.Text,"","", service);
                controller.AjPersonnel(personnel);
                RemplirListeDuPersonnel();
                btnEnregistrer.Enabled = true;
            }
        }
    }
}
