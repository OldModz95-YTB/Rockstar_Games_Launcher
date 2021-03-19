using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockstar_Launcher.creer_un_compte
{
    public partial class valid_creer_compte : Form
    {
        public valid_creer_compte()
        {
            InitializeComponent();
        }

        #region Retour à la form principal
        private void button_annuler_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }
        #endregion

        #region Fonction pour activé le bouton
        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (button_suivant.Enabled == false)
            {
                button_suivant.Enabled = true;
                check_1.Visible = false;
            }
            else
            {
                button_suivant.Enabled = false;
                check_1.Visible = true;
            }
        }

        private void check_1_Click(object sender, EventArgs e)
        {
            if (button_suivant.Enabled == false)
            {
                button_suivant.Enabled = true;
                flatCheckBox1.Checked = true;
                check_1.Visible = false;
            }
            else
            {
                button_suivant.Enabled = false;
                flatCheckBox1.Checked = false;
                check_1.Visible = true;
            }
        }
        #endregion


        #region Fonction de connexion
        private void button_suivant_Click(object sender, EventArgs e)
        {
            if (box_email.Text == confirme_email.Text && mdp.Text == confirme_mdp.Text)
            {
                reussi.SHowDialog("");
            }
            else
            {
                error.SHowDialog("");
            }
        }
        #endregion


        #region Redirection vers la form de connexion
        private void label2_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
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
