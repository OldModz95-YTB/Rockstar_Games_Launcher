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
    public partial class cree_un_compte : Form
    {
        public cree_un_compte()
        {
            InitializeComponent();
        }

        #region Redirection vers la form de connexion
        private void label2_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }
        #endregion


        #region Message Notification BOX

        #region Notification CGD
        private void box_condition_Click(object sender, EventArgs e)
        {
            login_messagebox.cgd.SHowDialog("");
        }
        #endregion

        #region Notification CDC
        private void box_charte_Click(object sender, EventArgs e)
        {
            login_messagebox.cdc.SHowDialog("");
        }
        #endregion

        #region Notification AL
        private void box_license_Click(object sender, EventArgs e)
        {
            login_messagebox.al.SHowDialog("");
        }
        #endregion

        #endregion


        #region Fonction d'activation du bouton send

        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (button_send.Enabled == false)
            {
                button_send.Enabled = true;
                check_1.Visible = false;
            }
            else
            {
                button_send.Enabled = false;
                check_1.Visible = true;
            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (button_send.Enabled == false)
            {
                button_send.Enabled = true;
                flatCheckBox1.Checked = true;
                check_1.Visible = false;
            }
            else
            {
                button_send.Enabled = false;
                flatCheckBox1.Checked = false;
                check_1.Visible = true;
            }
        }


        private void check_1_Click(object sender, EventArgs e)
        {
            if (button_send.Enabled == false)
            {
                button_send.Enabled = true;
                flatCheckBox1.Checked = true;
                check_1.Visible = false;
            }
            else
            {
                button_send.Enabled = false;
                flatCheckBox1.Checked = false;
                check_1.Visible = true;
            }
        }

        #endregion


        #region Redirection vers la créaction du compte
        private void button_send_Click(object sender, EventArgs e)
        {
            base.Hide();
            new creer_un_compte.valid_creer_compte().Show();
        }
        #endregion

        #region Annulation de l'action
        private void button_annuler_Click(object sender, EventArgs e)
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
