
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
    /// controlleur de FrmConnection
    /// </summary>
    public class FrmConnectionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur personnel
        /// </summary>
        private readonly PersAccess persAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmConnectionController()
        {
            persAccess = new PersAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns>true si les informations de connexion sont correctes</returns>
        public bool ControleAuthentification(Responsable responsable)
        {
            return persAccess.ControleAuthentification(responsable);
        }
    }
}