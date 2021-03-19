using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockstar_Launcher.login_messagebox
{
    public partial class al : Form
    {
        public al()
        {
            InitializeComponent();
        }


        #region Add system messagebox
        public static void SHowDialog(string message)
        {
            al cd = new Rockstar_Launcher.login_messagebox.al(message);
            cd.ShowDialog();
        }


        public al(string _message)
        {
            InitializeComponent();
            //LabelText.Text = _message;
        }
        #endregion

        #region Close
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
