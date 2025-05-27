using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.model
{
    public class Absence
    {
        // Propriétés publiques avec get/set
        public int IdPersonnel { get;}
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdMotif { get;}

        public Motif Motif { get; set; }
        public Personnel Personnel { get; set; }

        /// <summary>
        /// Constructeur pour valoriser les propriétés d'une absence
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel</param>
        /// <param name="dateDebut">Date de début de l'absence</param>
        /// <param name="dateFin">Date de fin de l'absence</param>
        /// <param name="idMotif">Identifiant du motif</param>
        /// <param name="motif">Objet Motif associé</param>
        /// <param name="personnel">Objet Personnel associé</param>
        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif, Motif motif, Personnel personnel)
        {
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            IdMotif = idMotif;
            Motif = motif;
            Personnel = personnel;
        }

    }
}
