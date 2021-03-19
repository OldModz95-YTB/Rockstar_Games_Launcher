using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockstar_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Checkbox

        #region Box 1
        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (check_1.Visible == true)
            {
                check_1.Visible = false;
            }
            else
            {
                check_1.Visible = true;
                check_2.Visible = true;
                flatCheckBox2.Checked = false;
            }
        }

        private void check_1_Click(object sender, EventArgs e)
        {
            if (check_1.Visible == true)
            {
                check_1.Visible = false;
                flatCheckBox1.Checked = true;
            }
            else
            {
                flatCheckBox1.Checked = true;
            }
        }
        #endregion

        #region Box 2
        private void flatCheckBox2_CheckedChanged(object sender)
        {
            if (check_2.Visible == true)
            {
                check_2.Visible = false;
                check_1.Visible = false;
                flatCheckBox1.Checked = true;
            }
            else
            {
                check_2.Visible = true;
                flatCheckBox2.Checked = false;
            }
        }

        private void check_2_Click(object sender, EventArgs e)
        {
            if (check_2.Visible == true)
            {
                check_2.Visible = false;
                check_1.Visible = false;
                flatCheckBox2.Checked = true;
                flatCheckBox1.Checked = true;
            }
            else
            {
                flatCheckBox2.Checked = true;
            }
        }
        #endregion

        #endregion


        #region MessageBox Notification

        #region CGD MessageBox Notification
        private void label5_Click(object sender, EventArgs e)
        {
            /*login_messagebox.cgd.SHowDialog("Test Du Text" +
                "\r\nTest D'un Autre text");*/
            login_messagebox.cgd.SHowDialog("");
        }

        #endregion

        #region CDC MessageBox Notification
        private void label6_Click(object sender, EventArgs e)
        {
            login_messagebox.cdc.SHowDialog("");
        }

        #endregion


        #region AL MessageBox Notification
        private void label9_Click(object sender, EventArgs e)
        {
            login_messagebox.al.SHowDialog("");
        }
        #endregion

        #endregion

        #region Redirection MDP Oublier
        private void label1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new mdp_oublie.mdp().Show();
        }
        #endregion


        #region Redirection Créer un compte
        private void label2_Click(object sender, EventArgs e)
        {
            base.Hide();
            new creer_un_compte.cree_un_compte().Show();
        }
        #endregion

        #region Redirection vers les settings
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new settings.home().Show();
        }
        #endregion
    }
}
