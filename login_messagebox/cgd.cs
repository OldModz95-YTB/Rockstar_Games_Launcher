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
    public partial class cgd : Form
    {
        public cgd()
        {
            InitializeComponent();
        }

        #region Add system messagebox
        public static void SHowDialog(string message)
        {
            cgd cd = new Rockstar_Launcher.login_messagebox.cgd(message);
            cd.ShowDialog();
        }


        public cgd(string _message)
        {
            InitializeComponent();
            //LabelText.Text = _message;
        }
        #endregion

        #region Close
        private void button_settings_Click(object sender, EventArgs e)
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
