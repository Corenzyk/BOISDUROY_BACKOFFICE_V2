using BOISDUROY_BACKOFFICE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOISDUROY_BACKOFFICE
{
    public partial class Menu : Form
    {
        public SF SousForm;

        public Menu()
        {
            InitializeComponent();
            SousForm = new SF(pan_menu);
        }

        private void employésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_Logo.Visible = false;
            lab_BDR.Visible = false;
            SousForm.openChildForm(new ListeEmployes());
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_Logo.Visible = false;
            lab_BDR.Visible = false;
            SousForm.openChildForm(new ListeProduits());
        }

        private void notesDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_Logo.Visible = false;
            lab_BDR.Visible = false;
            SousForm.openChildForm(new ListeNotes());
        }
    }
}
