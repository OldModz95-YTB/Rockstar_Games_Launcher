using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockstar_Launcher.mdp_oublie
{
    public partial class mdp : Form
    {
        public mdp()
        {
            InitializeComponent();
        }

        #region Redirection ANNULER
        private void button_annuler_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }
        #endregion


        #region Redirection Créer un compte
        private void label2_Click(object sender, EventArgs e)
        {
            base.Hide();
            new creer_un_compte.cree_un_compte().Show();
        }
        #endregion


        #region Redirection settings
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new settings.home().Show();
        }
        #endregion
    }
}
