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
    public partial class error : Form
    {
        public error()
        {
            InitializeComponent();
        }

        #region Redirection à la form principal
        private void button_suivant_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }
        #endregion


        #region Add system messagebox
        public static void SHowDialog(string message)
        {
            error cd = new Rockstar_Launcher.creer_un_compte.error(message);
            cd.ShowDialog();
        }


        public error(string _message)
        {
            InitializeComponent();
        }
        #endregion

        #region Fermer la notification
        private void button_suivant_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
