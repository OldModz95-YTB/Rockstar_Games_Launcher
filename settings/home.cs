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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            formoldmodz(new settings.general());
        }

        #region System d'affichage de form dans un panel
        private Form activeForm = null;
        private void formoldmodz(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_form.Controls.Add(childForm);
            panel_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region System de switch
        private void button_general_Click(object sender, EventArgs e)
        {
            formoldmodz(new settings.general());
            barres.Visible = false;
            barre.Visible = true;
        }

        private void button_legal_Click(object sender, EventArgs e)
        {
            formoldmodz(new settings.legal());
            barre.Visible = false;
            barres.Visible = true;
        }
        #endregion

        #region Fonctionner pour quitté
        private void label5_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }
        #endregion
    }
}
