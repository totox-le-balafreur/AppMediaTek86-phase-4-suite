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
    public partial class FrmGestAbs : Form
    {
        private FrmGestionController controllerMbre;
        /// <summary>
        /// controleur de la fenetre
        /// </summary>
        private FrmGestAbsController controller;
        /// <summary>
        /// objet pour gerer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences;
        /// <summary>
        /// objet pour gerer la liste des membres du personnel
        /// </summary>
        private BindingSource bdgMembre;
        /// <summary>
        /// objet pour gerer la liste des motifs d'absence
        /// </summary>
        private BindingSource bdgMotifs;
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisation
        /// </summary>
        public FrmGestAbs()
        {
            InitializeComponent();
            Init();
            RemplirListeDuPersonnel();

            // Événement sur changement de sélection dans la ComboBox personnel
            cbBoxLstMbre.SelectedIndexChanged += CbBoxLstMbre_SelectedIndexChanged;

            // Initialiser l'affichage des absences avec le premier membre (si existe)
            if (bdgMembre.Current != null)
            {
                RemplirListeAbsences((Personnel)bdgMembre.Current);
            }
        }
        private void CbBoxLstMbre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bdgMembre.Current != null)
            {
                Personnel membreSelectionne = (Personnel)bdgMembre.Current;
                RemplirListeAbsences(membreSelectionne);
            }
        }
        /// <summary>
        /// initialise les composants
        /// </summary>
        private void Init()
        {
            controllerMbre = new FrmGestionController();
            controller = new FrmGestAbsController();
            bdgAbsences = new BindingSource();
            bdgMembre = new BindingSource();
            bdgMotifs = new BindingSource();
        }
        /// <summary>
        /// AFFICHE LA LISTE DES MOTIFS d'absences
        /// </summary>
        private void RemplirListeMotifs()
        {
            // Récupérer la liste des motifs via le controller
            List<Motif> lesMotifs = controller.GetLesMotifs();

            // Affichage debug en console
            Console.WriteLine("Liste des motifs :");
            foreach (var motif in lesMotifs)
            {
                Console.WriteLine($"IdMotif: {motif.IdMotif}, Libelle: {motif.Libelle}");
            }

            // Lier la liste au BindingSource
            bdgMotifs.DataSource = lesMotifs;
            // Assigner le BindingSource à la ComboBox cbBoxlstMotifs2
            cbBoxLstMotifsAj.DataSource = null;  // Reset avant d'affecter la source
            cbBoxLstMotifsAj.DataSource = bdgMotifs;
            cbBoxLstMotifsAj.DisplayMember = "Libelle";   // Ce qui s'affiche
            cbBoxLstMotifsAj.ValueMember = "IdMotif";     // Valeur associée
            // Assigner le BindingSource à la ComboBox cbBoxlstMotifs2
            cbBoxLstMotifsMod.DataSource = null;  // Reset avant d'affecter la source
            cbBoxLstMotifsMod.DataSource = bdgMotifs;
            cbBoxLstMotifsMod.DisplayMember = "Libelle";   // Ce qui s'affiche
            cbBoxLstMotifsMod.ValueMember = "IdMotif";     // Valeur associée
        }
        /// <summary>
        /// affiche la liste du personnel
        /// </summary>
        private void RemplirListeDuPersonnel()
        {
            List<Personnel> lePersonnel = controllerMbre.GetLePersonnel();
            // Debug affichage en console
            Console.WriteLine("Liste du personnel :");
            foreach (var p in lePersonnel)
            {
                Console.WriteLine($"Id: {p.Idpersonnel}, NomComplet: {p.NomComplet}");
            }
            bdgMembre.DataSource = lePersonnel;
            cbBoxLstMbre.DataSource = bdgMembre;
            cbBoxLstMbre.DisplayMember = "NomComplet";
            cbBoxLstMbre.ValueMember = "IdPersonnel";
        }
        /// <summary>
        /// Remplit la ComboBox avec les absences du personnel sélectionné.
        /// </summary>
        /// <param name="personnel">Le membre du personnel dont on veut afficher les absences.</param>
        private void RemplirListeAbsences(Personnel personnel)
        {
            List<Absence> toutesLesAbsences = controller.GetLesAbsences();

            // Filtrage des absences du personnel courant
            List<Absence> absencesFiltrees = toutesLesAbsences
                .Where(abs => abs.IdPersonnel == personnel.Idpersonnel)
                .OrderBy(abs => abs.DateDebut) // Tri par date croissante
                .ToList();

            Console.WriteLine("Absences filtrées :");
            foreach (var a in absencesFiltrees)
            {
                Console.WriteLine($"IdPersonnel: {a.IdPersonnel}, DateDebutString: {a.DateDebutString}, IdAbsenceString: {a.IdAbsenceString}");
            }

            // Mise à jour du BindingSource avec tri
            bdgAbsences.DataSource = absencesFiltrees;

            cbBoxLstAbs.DataSource = null; // Reset d'abord
            cbBoxLstAbs.DataSource = bdgAbsences;
            cbBoxLstAbs.DisplayMember = "DateDebutString"; // Affiche la date
            cbBoxLstAbs.ValueMember = "IdAbsenceString";   // Valeur associée
        }

        private void btnSupprAbs_Click(object sender, EventArgs e)
        {
            if (cbBoxLstAbs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            { 
                groupBoxSupprAbs.Enabled = true; 
            }
        }

        private void btnSupprConfirmer_Click(object sender, EventArgs e)
        {
            // Récupérer l'absence sélectionnée
            Absence absenceASupprimer = (Absence)cbBoxLstAbs.SelectedItem;
            // Appel de la suppression (void)
            controller.SupprAbsence(absenceASupprimer);
            groupBoxSupprAbs.Enabled=false;
            MessageBox.Show("Absence supprimée avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mise à jour de la liste
            if (bdgMembre.Current != null)
            {
                Personnel membreSelectionne = (Personnel)bdgMembre.Current;
                RemplirListeAbsences(membreSelectionne);
            }
            groupBoxSupprAbs.Enabled = false;
        }
        /// <summary>
        /// active le groupe box d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjAbs_Click(object sender, EventArgs e)
        {
            groupBoxAjoutAbs.Enabled = true;
            RemplirListeMotifs();
        }

        private void btnAjConfirmer_Click(object sender, EventArgs e)
        {
            if (bdgMembre.Current == null)
            {
                MessageBox.Show("Aucun membre sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérer les dates sélectionnées dans les calendriers
            DateTime dateDebut = dateTimePickerAjDebut.Value.Date;
            DateTime dateFin = dateTimePickerAjFin.Value.Date;

            if (dateFin < dateDebut)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer le membre sélectionné
            Personnel membre = (Personnel)bdgMembre.Current;

            // Récupérer le motif sélectionné dans ta ComboBox d'ajout (ex: cbBoxLstMotifsAj)
            if (cbBoxLstMotifsAj.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un motif d'absence.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Motif motifSelectionne = (Motif)cbBoxLstMotifsAj.SelectedItem;

            // Créer l'absence
            Absence nouvelleAbsence = new Absence(
                membre.Idpersonnel,
                dateDebut,
                dateFin,
                motifSelectionne.IdMotif,
                motifSelectionne,
                membre
            );

            // Ajouter l'absence via le controller
            controller.AjAbsence(nouvelleAbsence);

            // Mettre à jour la liste des absences affichées
            RemplirListeAbsences(membre);

            // Verrouiller le groupe d'ajout
            groupBoxAjoutAbs.Enabled = false;

        }

        private void btnModAbs_Click(object sender, EventArgs e)
        {
            groupBoxModAbs.Enabled = true;
            RemplirListeMotifs();
        }

        private void btnModConfirmer_Click(object sender, EventArgs e)
        {
            if (cbBoxLstAbs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer l'absence sélectionnée
            Absence absenceAModifier = (Absence)cbBoxLstAbs.SelectedItem;

            // Récupérer les nouvelles dates
            DateTime nouvelleDateDebut = dateTimePickerModDebut.Value.Date;
            DateTime nouvelleDateFin = dateTimePickerModFin.Value.Date;

            if (nouvelleDateFin < nouvelleDateDebut)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier qu’un motif est sélectionné
            if (cbBoxLstMotifsMod.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer le motif sélectionné
            Motif nouveauMotif = (Motif)cbBoxLstMotifsMod.SelectedItem;

            // Mise à jour des propriétés de l’absence
            absenceAModifier.DateDebut = nouvelleDateDebut;
            absenceAModifier.DateFin = nouvelleDateFin;
            absenceAModifier.IdMotif = nouveauMotif.IdMotif;
            absenceAModifier.Motif = nouveauMotif;

            // Appel au contrôleur pour modifier l’absence
            controller.UpdateAbsence(absenceAModifier);

            // Mise à jour de la liste des absences affichées
            if (bdgMembre.Current != null)
            {
                Personnel membreSelectionne = (Personnel)bdgMembre.Current;
                RemplirListeAbsences(membreSelectionne);
            }

            MessageBox.Show("Absence modifiée avec succès.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fermer le groupe de modification
            groupBoxModAbs.Enabled = false;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
