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
    public partial class cdc : Form
    {
        public cdc()
        {
            InitializeComponent();
        }

        #region Add system messagebox
        public static void SHowDialog(string message)
        {
            cdc cd = new Rockstar_Launcher.login_messagebox.cdc(message);
            cd.ShowDialog();
        }


        public cdc(string _message)
        {
            InitializeComponent();
            //LabelText.Text = _message;
        }
        #endregion

        #region Close
        private void button_close_Click(object sender, EventArgs e)
        {
            base.Hide();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            base.Hide();
        }
        #endregion

    }
}
