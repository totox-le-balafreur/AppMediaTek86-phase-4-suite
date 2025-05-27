using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.model
{

    public class Responsable

    
        {
        public string Login { get; }
        public string Mdp { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        public Responsable(string login,string mdp)
        {
            this.Login = login;
            this.Mdp = mdp;
        }
    }
}

