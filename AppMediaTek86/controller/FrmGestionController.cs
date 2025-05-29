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
    /// controller de FrmGestion
    /// </summary>
    public class FrmGestionController
    {

        /// <summary>
        /// objet d'accès des opérations sur le personnel
        /// </summary>
        private readonly PersAccess persAccess;
        /// <summary>
        /// récupère l'accés aux données
        /// </summary>
        public FrmGestionController()
        {
            persAccess = new PersAccess();
        }
        /// <summary>
        /// récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            return persAccess.GetLePersonnel();
        }
    }
}
