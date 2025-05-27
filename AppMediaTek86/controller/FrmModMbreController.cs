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
    /// controller de FrmModMbre
    /// </summary>
    public class FrmModMbreController
    {
        /// <summary>
        /// objet d'accès des opérations sur le personnel
        /// </summary>
        private readonly PersAccess persAccess;
        /// <summary>
        /// objet d'accès aux opérations sur les Services
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// récupère l'accès aux données
        /// </summary>
        public FrmModMbreController()
        {
            persAccess = new PersAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            return persAccess.GetLePersonnel();
        }

        /// <summary>
        /// récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// demande modification d'un membre 
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            persAccess.UpdatePersonnel(personnel); 
        }
    }
}
