using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.model
{
    public class Motif
    {
        public int IdMotif { get; set; }
        public string Libelle { get; set; }

        public Motif(int idMotif, string libelle)
        {
            IdMotif = idMotif;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
