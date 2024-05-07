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
    public partial class PageCo : Form
    {
        public PageCo()
        {
            InitializeComponent();
            
            //txt_Matricule.GotFocus = GotFocus.EventHandle(RemoveText);
            //txt_Matricule.LostFocus = LostFocus.EventHandle(AddText);
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txt_Matricule.Text == "Matricule")
                txt_Matricule.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Matricule.Text))
                txt_Matricule.Text = "Matricule";
        }

        private void buttonConn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
