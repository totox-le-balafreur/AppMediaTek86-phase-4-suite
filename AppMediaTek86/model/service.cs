using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.model
{
    public class Service
    {
        public Service(int idService, string nom)
        {
            this.Idservice = idService;
            this.Nom = nom;
        }

        public int Idservice { get; }
        public string Nom { get; set; }
    }
}
