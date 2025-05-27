
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
        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (nom, prénom, pwd et profil "admin")
        /// </summary>
        /// <param name="responsable"></param>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns>vrai si l'utilisateur a le profil "admin"</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable";
                req += "where login=@ton_login and  and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@ton_login", responsable.Login);
                parameters.Add("@pwd", responsable.Mdp);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
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
                string req = "SELECT * FROM absence a ";
                req += "JOIN motif m ON a.idmotif = m.idmotif ";
                req += "JOIN personnel p ON a.idpersonnel = p.idpersonnel ";
                req += "JOIN service s ON p.idservice = s.idservice ";
                req += "ORDER BY a.datedebut DESC;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            // Création des objets dépendants
                            Service service = new Service((int)record[11], (string)record[12]);
                            Personnel personnel = new Personnel((int)record[6], (string)record[7], (string)record[8], (string)record[9], (string)record[10], service);
                            Motif motif = new Motif((int)record[4], (string)record[5]);

                            // Création de l'absence
                            Absence absence = new Absence(
                                (int)record[0],           // idPersonnel
                                (DateTime)record[1],      // dateDebut
                                (DateTime)record[2],      // dateFin
                                (int)record[3],           // idMotif
                                motif,                    // objet Motif
                                personnel                 // objet Personnel
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
                string req = "delete from absence where datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absence.DateDebut);
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
                string req = "insert into absencel(idpersonnel, datedebut, datefin, idmotife) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.IdPersonnel);
                parameters.Add("@datedebut", absence.DateDebut);
                parameters.Add("@datefin", absence.DateFin);
                parameters.Add("@mail", absence.IdMotif);
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
                string req = "update absence set idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where datedbut = @datedebut;";
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

    }
}
