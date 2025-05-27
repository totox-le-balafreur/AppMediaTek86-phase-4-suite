
﻿using AppMediaTek86.model;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.dal
{

    public class MotifAccess
    {
        ///<summary>
        ///instance unique de l'accés aux données
        /// </summary>
        private readonly Access access = null;
        ///<summary>
        ///Constructeur pour créer l'accès aux données
        /// </summary>
        public MotifAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "select * from motif order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif(
                                (int)record[0],//idmotif
                                (string)record[1]//libelle
                                );
                            lesMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;
        }
    }


}
