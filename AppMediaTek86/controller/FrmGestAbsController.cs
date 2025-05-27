using AppMediaTek86.dal;
using AppMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.controller
{
    /// <summary>
    /// controleur de FrmGestAbs
    /// </summary>
    public class FrmGestAbsController
    {
        /// <summary>
        /// objet d'accés aux opérations possibles sur les absences
        /// </summary>
        private readonly AbsAccess absAccess;
        /// <summary>
        /// objet d'accés aux opérations possibles sur les motifs
        /// </summary>
        private readonly MotifAccess motifAccess;
        /// <summary>
        /// récupère l'accès aux données
        /// </summary>
        public FrmGestAbsController()
        {
            absAccess = new AbsAccess();
            motifAccess = new MotifAccess();
        }

        ///<summary>
        /// récupère et retourne la liste des absences
        ///</summary>
        ///<returns>liste des absences</returns>
        public List<Absence> GetLesAbsences()
        {
            return absAccess.GetLesAbsences();
        }

        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void SupprAbsence(Absence absence)
        {
            absAccess.SupprAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AjAbsence(Absence absence)
        {
            absAccess.AjAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absAccess.UpdateAbsence(absence);
        }
    }
}
