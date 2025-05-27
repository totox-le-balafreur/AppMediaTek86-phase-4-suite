using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.model
{
    public class Motif
    {
        int idMotif { get; }
        string libelle { get; set; }
        ///<summary>
        ///valorise les propriétés
        ///</summary>
        ///<param name="idMotif"></param>
        ///<param name="libelle"></param>
        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }

    }
}
