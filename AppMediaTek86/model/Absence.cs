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
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdMotif { get; set; }
        public Motif Motif { get; set; }
        public Personnel Personnel { get; set; }

        // Pour gérer une modification sans perdre la date d’origine
        public DateTime DateDebutInitial { get; set; }
        //clée composite d'idabsence
        public string IdAbsenceString
        {
            get
            {
                return $"{IdPersonnel}_{DateDebut:yyyyMMdd}_{DateFin:yyyyMMdd}";
            }
        }
        // Pour l'affichage dans ComboBox ou autre
        public string DateDebutString
        {
            get { return DateDebut.ToString("dd/MM/yyyy"); }
        }

        public override string ToString()
        {
            return $"{Personnel.Nom} {Personnel.Prenom} - {DateDebut:dd/MM/yyyy} au {DateFin:dd/MM/yyyy} ({Motif.Libelle})";
        }

        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif, Motif motif, Personnel personnel)
        {
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            IdMotif = idMotif;
            Motif = motif;
            Personnel = personnel;

            // Initialement, la date de début "initiale" est la même que la courante
            DateDebutInitial = dateDebut;
        }
    }
}
