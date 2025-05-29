
﻿using AppMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.dal
{

    public class AbsAccess
    {
        ///<summary>
        ///instance unique de l'accés aux données
        /// </summary>
        private readonly Access access = null;

        ///<summary>
        ///Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsAccess()
        {
            access = Access.GetInstance();
        }
       
        ///<summary>
        ///recupere et retourne la liste des absences
        ///</summary>
        ///<returns> liste dabesences</returns>
        public List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                Console.WriteLine("[DEBUG] Accès manager OK"); // Test
                string req = @"SELECT a.idpersonnel, a.datedebut, a.datefin, a.idmotif, 
                                m.idmotif, m.libelle, 
                                p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, p.idservice, 
                                s.idservice, s.nom 
                                FROM absence a
                                JOIN motif m ON a.idmotif = m.idmotif
                                JOIN personnel p ON a.idpersonnel = p.idpersonnel
                                JOIN service s ON p.idservice = s.idservice
                                ORDER BY a.datedebut DESC;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    Console.WriteLine("[DEBUG] Absences récupérées : " + records?.Count); // Test
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Console.WriteLine("[DEBUG] Lecture absence : " + string.Join(" | ", record)); // Test
                            // Récupération des valeurs avec gestion des valeurs NULL
                            int idPersonnel = record[0] != DBNull.Value ? Convert.ToInt32(record[0]) : 0;
                            DateTime dateDebut = record[1] != DBNull.Value ? Convert.ToDateTime(record[1]) : DateTime.MinValue;
                            DateTime dateFin = record[2] != DBNull.Value ? Convert.ToDateTime(record[2]) : DateTime.MinValue;
                            int idMotif = record[3] != DBNull.Value ? Convert.ToInt32(record[3]) : 0;

                            int idMotifMotif = record[4] != DBNull.Value ? Convert.ToInt32(record[4]) : 0;
                            string libelleMotif = record[5] != DBNull.Value ? record[5].ToString() : string.Empty;
                            Motif motif = new Motif(idMotifMotif, libelleMotif);

                            int idPerso = record[6] != DBNull.Value ? Convert.ToInt32(record[6]) : 0;
                            string nom = record[7] != DBNull.Value ? record[7].ToString() : string.Empty;
                            string prenom = record[8] != DBNull.Value ? record[8].ToString() : string.Empty;
                            string tel = record[9] != DBNull.Value ? record[9].ToString() : string.Empty;
                            string mail = record[10] != DBNull.Value ? record[10].ToString() : string.Empty;

                            int idService = record[12] != DBNull.Value ? Convert.ToInt32(record[12]) : 0;
                            string nomService = record[13] != DBNull.Value ? record[13].ToString() : string.Empty;
                            Service service = new Service(idService, nomService);

                            Personnel personnel = new Personnel(idPerso, nom, prenom, tel, mail, service);
                            // Test
                            Console.WriteLine($"idPersonnel={idPersonnel}, idPerso={idPerso}, égalité: {idPersonnel == idPerso}");
                            Absence absence = new Absence(
                                idPersonnel,
                                dateDebut,
                                dateFin,
                                idMotif,
                                motif,
                                personnel
                            );

                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void SupprAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absence.DateDebut);
                parameters.Add("@idpersonnel", absence.IdPersonnel);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AjAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.IdPersonnel);
                parameters.Add("@datedebut", absence.DateDebut);
                parameters.Add("@datefin", absence.DateFin);
                parameters.Add("@idmotif", absence.IdMotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set idpersonnel = @idpersonnel, datedebut = @new_datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "WHERE idpersonnel = @idpersonnel AND datedebut = @old_datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.IdPersonnel);
                parameters.Add("@new_datedebut", absence.DateDebut);
                parameters.Add("@datefin", absence.DateFin);
                parameters.Add("@idmotif", absence.IdMotif);
                parameters.Add("@old_datedebut", absence.DateDebutInitial);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

    }
}
