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
    /// Contrôleur de FrmSupprMbre
    /// </summary>
    public class FrmSupprMbreController
    {
        /// <summary>
        /// Objet d'accès aux opérations sur le personnel
        /// </summary>
        private readonly PersAccess persAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmSupprMbreController()
        {
            persAccess = new PersAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>La liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            return persAccess.GetLePersonnel();
        }

        /// <summary>
        /// Demande de suppression d'un membre
        /// </summary>
        /// <param name="personnel">Objet personnel à supprimer</param>
        public void SupprPersonnel(Personnel personnel)
        {
            persAccess.SupprPersonnel(personnel);
        }
    }
}
