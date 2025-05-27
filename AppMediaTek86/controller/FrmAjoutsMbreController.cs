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
    /// controleur de FrmAjoutsMbre
    /// </summary>
    public class FrmAjoutsMbreController
    {
        /// <summary>
        /// objet de d'accès des opérations sur le personnel
        /// </summary>
        private readonly PersAccess persAccess;
        /// <summary>
        /// objet d'accès au opération sur les Services
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// récrupère l'accès aux données
        /// </summary>
        public FrmAjoutsMbreController()
        {
            persAccess = new PersAccess();
            serviceAccess = new ServiceAccess();
        }
        /// <summary>
        /// recupère et retourne les infos du personnel
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLePersonnel() 
        {
            return persAccess.GetLePersonnel();
        }
        /// <summary>
        /// recupère et retroune les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }
        /// <summary>
        /// demande l'ajout d'un membre
        /// </summary>
        /// <param name="personnel"></param>
        public void AjPersonnel(Personnel personnel)
        {
            persAccess.AjPersonnel(personnel);
        }
    }
}
