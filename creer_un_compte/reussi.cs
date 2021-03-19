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
    public partial class reussi : Form
    {
        public reussi()
        {
            InitializeComponent();
        }


        #region Redirection à la form principal
        private void button_suivant_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Add system messagebox
        public static void SHowDialog(string message)
        {
            reussi cd = new Rockstar_Launcher.creer_un_compte.reussi(message);
            cd.ShowDialog();
        }


        public reussi(string _message)
        {
            InitializeComponent();
        }
        #endregion
    }
}
