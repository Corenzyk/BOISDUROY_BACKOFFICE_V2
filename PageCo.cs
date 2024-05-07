using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOISDUROY_BACKOFFICE.Models;
using BOISDUROY_BACKOFFICE.Controllers;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOISDUROY_BACKOFFICE
{
    public partial class PageCo : Form
    {
        Logging log;
        public PageCo()
        {
            InitializeComponent();
            txt_MDP.PasswordChar = '*';
            log = new Logging();
        }

        private void buttonConn_Click(object sender, EventArgs e)
        {
            if (txt_Matricule.Text=="" || txt_MDP.Text=="") {
                MessageBox.Show("Veuillez saisir toutes les informations requises.");
            }
            else
            {
                if (log.LogPossible(txt_Matricule.Text, txt_MDP.Text) != 1) //erreur au clique bouton
                {
                    MessageBox.Show("Vous n'êtes pas autorisé à accéder à cette application.");
                }
                else
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                }
            }
            
        }

        private void checkMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMDP.Checked == true)
            {
                txt_MDP.PasswordChar = '\0';
            }
            else
            {
                txt_MDP.PasswordChar = '*';
            }
        }
    }
}
