
﻿using AppMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.dal
{

    public class ServiceAccess
    {
        ///<summary>
        ///instance unique de l'accés aux données
        /// </summary>
        private readonly Access access = null;
        ///<summary>
        ///Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service(
                                (int)record[0],//idservice
                                (string)record[1]//nom
                                );
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
