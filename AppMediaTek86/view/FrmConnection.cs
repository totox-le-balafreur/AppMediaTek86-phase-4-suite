using AppMediaTek86.controller;
using AppMediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaTek86.view
{
    /// <summary>
    /// Fenetre de connection pour les responsables
    /// </summary>
    public partial class FrmConnection : Form
    {
        /// <summary>
        /// controleur de la fenetre
        /// </summary>
        private FrmConnectionController controller;
        /// <summary>
        /// Construction des composant graphiques
        /// </summary>
        public FrmConnection()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Initialisation
        /// Création du controller
        /// </summary>
        private void Init()
        {
            controller = new FrmConnectionController();
        }
        /// <summary>
        /// demande au controller le controle de l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeConn_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String mdp = txtMdp.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, mdp);
                if (controller.ControleAuthentification(responsable))
                {
                    FrmGestion frm = new FrmGestion();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }
    }
}
