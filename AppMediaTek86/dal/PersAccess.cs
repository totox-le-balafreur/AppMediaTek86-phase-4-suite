using AppMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaTek86.dal
{
    ///<summary>
    ///Classe gerant les demandes acces du responsable
    /// </summary>

    public class PersAccess

    {
        ///<summary>
        ///instance unique de l'accés aux données
        /// </summary>
        private readonly Access access = null;

        ///<summary>
        ///Constructeur pour créer l'accès aux données
        /// </summary>
        public PersAccess()
        {
            access = Access.GetInstance(); 
        }
        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (nom, prénom, pwd et profil "admin")
        /// </summary>

        /// <param name="responsable"></param>
        /// <param name="Login"></param>
        /// <param name="Mdp"></param>
        /// <returns>vrai si l'utilisateur a le profil "responsable"</returns>

        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable where login=@ton_login and pwd=SHA2(@pwd, 256)";
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
        ///recupere et retourne la liste du personnel
        ///</summary>
        ///<returns> liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "SELECT p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom ";
                req += "FROM personnel p ";
                req += "JOIN service s ON p.idservice = s.idservice ";
                req += "ORDER BY p.nom, p.prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel(
                                (int)record[0],        // idpersonnel
                                (string)record[1],     // nom
                                (string)record[2],     // prenom
                                (string)record[3],     // tel
                                (string)record[4],     // mail
                                service                // service
                            );
                            lePersonnel.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lePersonnel;
        }


        /// <summary>
        /// Demande de suppression d'un Membre
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void SupprPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
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
        /// Demande d'ajout d'un membre
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AjPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
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
        /// Demande de modification d'un membre
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
                parameters.Add("@idpersonnel",personnel.Idpersonnel);
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
