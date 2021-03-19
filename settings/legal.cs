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
    public partial class legal : Form
    {
        public legal()
        {
            InitializeComponent();
        }

        #region Notification

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login_messagebox.cdc.SHowDialog("");
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            login_messagebox.cgd.SHowDialog("");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            login_messagebox.al.SHowDialog("");
        }
        #endregion
    }
}
