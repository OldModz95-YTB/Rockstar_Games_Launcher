using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockstar_Launcher.settings
{
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }


        #region Panel de check 1
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (check_1.Visible == true)
            {
                check_1.Visible = false;
                CheckBox1.Checked = true;
            }
            else
            {
                check_1.Visible = true;
                CheckBox1.Checked = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (check_1.Visible == true)
            {
                check_1.Visible = false;
                CheckBox1.Checked = true;
            }
            else
            {
                check_1.Visible = true;
                CheckBox1.Checked = false;
            }
        }

        private void check_1_Click(object sender, EventArgs e)
        {
            if (check_1.Visible == true)
            {
                check_1.Visible = false;
                CheckBox1.Checked = true;
            }

        }

        private void CheckBox1_CheckedChanged(object sender)
        {
            if (check_1.Visible == true)
            {
                check_1.Visible = false;
            }
            else
            {
                check_1.Visible = true;
            }
        }
        #endregion

        #region Action du bouton chercher
        private void button_recherche_Click(object sender, EventArgs e)
        {
            byoldmodz95.Visible = true;
        }
        #endregion
    }
}
