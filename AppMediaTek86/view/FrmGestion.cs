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
    /// fenetre permettant l'accés aux differentes fonctionnalites
    /// </summary>
    public partial class FrmGestion : Form
    {
        /// <summary>
        /// initialisation des composant
        /// </summary>
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void btnAjMbre_Click(object sender, EventArgs e)
        {
            FrmAjoutsMbre frmAj = new FrmAjoutsMbre();
            frmAj.ShowDialog();
        }

        private void btnSupprMbre_Click(object sender, EventArgs e)
        {
            FrmSupprMbre frmSuppr = new FrmSupprMbre();
            frmSuppr.ShowDialog();

        }

        private void btnModMbre_Click(object sender, EventArgs e)
        {
            FrmModMbre frmMod = new FrmModMbre();
            frmMod.ShowDialog();
        }

        private void btnGestAbs_Click(object sender, EventArgs e)
        {
            FrmGestAbs frmGest = new FrmGestAbs();
            frmGest.ShowDialog();
        }
    }
}
