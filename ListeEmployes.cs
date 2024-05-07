using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOISDUROY_BACKOFFICE.Controllers;
using BOISDUROY_BACKOFFICE.Models;

namespace BOISDUROY_BACKOFFICE
{
    public partial class ListeEmployes : Form
    {
        private Employes emp;
        private SF SousForm;
        private Fonctions fonc;
        private Produits prod;

        public ListeEmployes()
        {
            InitializeComponent();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pan_menu);
            emp = new Employes();
            fonc = new Fonctions();
            prod = new Produits();
            dgv_Employe.DataSource = emp.GetListeEmp(false);
            dgv_Employe.Columns[0].HeaderText = "Matricule";
            dgv_Employe.Columns[0].Width = 60;
            dgv_Employe.Columns[1].HeaderText = "Nom";
            dgv_Employe.Columns[1].Width = 80;
            dgv_Employe.Columns[2].HeaderText = "Prenom";
            dgv_Employe.Columns[2].Width = 80;
            dgv_Employe.Columns[3].HeaderText = "Fonction";
            dgv_Employe.Columns[3].Width = 130;
            dgv_Employe.Columns[4].HeaderText = "Type Produit";
            dgv_Employe.Columns[4].Width = 130;
            dgv_Employe.Columns[5].HeaderText = "Date naissance";
            dgv_Employe.Columns[5].Width = 80;
            dgv_Employe.Columns[6].HeaderText = "Date entrée";
            dgv_Employe.Columns[6].Width = 80;
            dgv_Employe.Columns[7].HeaderText = "Date sortie";
            dgv_Employe.Columns[7].Width = 80;
            dgv_Employe.Columns[8].HeaderText = "Responsable";
            dgv_Employe.Columns[8].Width = 75;
            dgv_Employe.Columns[9].HeaderText = "Autoriser BO ?";
            dgv_Employe.Columns[9].Width = 100;
            dgv_Employe.Columns[10].HeaderText = "Responsable ?";
            dgv_Employe.Columns[10].Width = 100;

            cb_fonc.DataSource = fonc.GetListeFonc(true);
            cb_fonc.DisplayMember = "LIB_FONC";
            cb_fonc.ValueMember = "LIB_FONC";

            cb_prod.DataSource = prod.GetListeProdComb(true);
            cb_prod.DisplayMember = "LIB_PROD";
            cb_prod.ValueMember = "LIB_PROD";
        }

        public void Rafraichir()
        {
            dgv_Employe.DataSource = emp.GetListeEmp(false);
            dgv_Employe.Columns[0].HeaderText = "Matricule";
            dgv_Employe.Columns[0].Width = 60;
            dgv_Employe.Columns[1].HeaderText = "Nom";
            dgv_Employe.Columns[1].Width = 80;
            dgv_Employe.Columns[2].HeaderText = "Prenom";
            dgv_Employe.Columns[2].Width = 80;
            dgv_Employe.Columns[3].HeaderText = "Fonction";
            dgv_Employe.Columns[3].Width = 130;
            dgv_Employe.Columns[4].HeaderText = "Type Produit";
            dgv_Employe.Columns[4].Width = 130;
            dgv_Employe.Columns[5].HeaderText = "Date naissance";
            dgv_Employe.Columns[5].Width = 80;
            dgv_Employe.Columns[6].HeaderText = "Date entrée";
            dgv_Employe.Columns[6].Width = 80;
            dgv_Employe.Columns[7].HeaderText = "Date sortie";
            dgv_Employe.Columns[7].Width = 80;
            dgv_Employe.Columns[8].HeaderText = "Responsable";
            dgv_Employe.Columns[8].Width = 75;
            dgv_Employe.Columns[9].HeaderText = "Autoriser BO ?";
            dgv_Employe.Columns[9].Width = 100;
            dgv_Employe.Columns[10].HeaderText = "Responsable ?";
            dgv_Employe.Columns[10].Width = 100;
        }

        private void btn_ajouter_Click_1(object sender, EventArgs e)
        {
            SousForm.openChildForm(new EmployesAM("Création "));
        }

        private void btn_modifier_Click_1(object sender, EventArgs e)
        {
            SousForm.openChildForm(new EmployesAM("Modification ", dgv_Employe.CurrentRow.Cells[0].Value.ToString(), dgv_Employe.CurrentRow.Cells[1].Value.ToString(),
                dgv_Employe.CurrentRow.Cells[2].Value.ToString(), dgv_Employe.CurrentRow.Cells[5].Value.ToString(), dgv_Employe.CurrentRow.Cells[6].Value.ToString(),
                dgv_Employe.CurrentRow.Cells[7].Value.ToString(), dgv_Employe.CurrentRow.Cells[3].Value.ToString(), dgv_Employe.CurrentRow.Cells[4].Value.ToString(),
                dgv_Employe.CurrentRow.Cells[8].Value.ToString(), Convert.ToBoolean(dgv_Employe.CurrentRow.Cells[9].Value), Convert.ToBoolean(dgv_Employe.CurrentRow.Cells[10].Value)));
        }

        private void btn_supprimer_Click_1(object sender, EventArgs e)
        {
            DialogResult Valid = MessageBox.Show("Voulez vous supprimer l'employé :" + dgv_Employe.CurrentRow.Cells[1].Value.ToString() + " ?", "Suppression de : " + dgv_Employe.CurrentRow.Cells[1].Value.ToString(), MessageBoxButtons.YesNo);
            if (Valid == DialogResult.Yes)
            {
                bool RetourSupp = emp.DeleteEmp(Convert.ToInt32(dgv_Employe.CurrentRow.Cells[0].Value.ToString()));
                if (RetourSupp)
                    Rafraichir();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_Employe.DataSource = emp.GetEmpByFiltre(txt_search.Text, Convert.ToString(cb_fonc.SelectedValue), Convert.ToString(cb_prod.SelectedValue)); //Entrée d'une lettre -> plante
            dgv_Employe.Columns[0].HeaderText = "Matricule";
            dgv_Employe.Columns[0].Width = 60;
            dgv_Employe.Columns[1].HeaderText = "Nom";
            dgv_Employe.Columns[1].Width = 80;
            dgv_Employe.Columns[2].HeaderText = "Prenom";
            dgv_Employe.Columns[2].Width = 80;
            dgv_Employe.Columns[3].HeaderText = "Fonction";
            dgv_Employe.Columns[3].Width = 130;
            dgv_Employe.Columns[4].HeaderText = "Type Produit";
            dgv_Employe.Columns[4].Width = 130;
            dgv_Employe.Columns[5].HeaderText = "Date naissance";
            dgv_Employe.Columns[5].Width = 80;
            dgv_Employe.Columns[6].HeaderText = "Date entrée";
            dgv_Employe.Columns[6].Width = 80;
            dgv_Employe.Columns[7].HeaderText = "Date sortie";
            dgv_Employe.Columns[7].Width = 80;
            dgv_Employe.Columns[8].HeaderText = "Responsable";
            dgv_Employe.Columns[8].Width = 75;
            dgv_Employe.Columns[9].HeaderText = "Autoriser BO ?";
            dgv_Employe.Columns[9].Width = 100;
            dgv_Employe.Columns[10].HeaderText = "Responsable ?";
            dgv_Employe.Columns[10].Width = 100;
        }

        private void cb_fonc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_fonc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv_Employe.DataSource = emp.GetEmpByFiltre(txt_search.Text, Convert.ToString(cb_fonc.SelectedValue), Convert.ToString(cb_prod.SelectedValue)); //Entrée d'une lettre -> plante
            dgv_Employe.Columns[0].HeaderText = "Matricule";
            dgv_Employe.Columns[0].Width = 60;
            dgv_Employe.Columns[1].HeaderText = "Nom";
            dgv_Employe.Columns[1].Width = 80;
            dgv_Employe.Columns[2].HeaderText = "Prenom";
            dgv_Employe.Columns[2].Width = 80;
            dgv_Employe.Columns[3].HeaderText = "Fonction";
            dgv_Employe.Columns[3].Width = 130;
            dgv_Employe.Columns[4].HeaderText = "Type Produit";
            dgv_Employe.Columns[4].Width = 130;
            dgv_Employe.Columns[5].HeaderText = "Date naissance";
            dgv_Employe.Columns[5].Width = 80;
            dgv_Employe.Columns[6].HeaderText = "Date entrée";
            dgv_Employe.Columns[6].Width = 80;
            dgv_Employe.Columns[7].HeaderText = "Date sortie";
            dgv_Employe.Columns[7].Width = 80;
            dgv_Employe.Columns[8].HeaderText = "Responsable";
            dgv_Employe.Columns[8].Width = 75;
            dgv_Employe.Columns[9].HeaderText = "Autoriser BO ?";
            dgv_Employe.Columns[9].Width = 100;
            dgv_Employe.Columns[10].HeaderText = "Responsable ?";
            dgv_Employe.Columns[10].Width = 100;
        }

        private void cb_prod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv_Employe.DataSource = emp.GetEmpByFiltre(txt_search.Text, Convert.ToString(cb_fonc.SelectedValue), Convert.ToString(cb_prod.SelectedValue)); //Entrée d'une lettre -> plante
            dgv_Employe.Columns[0].HeaderText = "Matricule";
            dgv_Employe.Columns[0].Width = 60;
            dgv_Employe.Columns[1].HeaderText = "Nom";
            dgv_Employe.Columns[1].Width = 80;
            dgv_Employe.Columns[2].HeaderText = "Prenom";
            dgv_Employe.Columns[2].Width = 80;
            dgv_Employe.Columns[3].HeaderText = "Fonction";
            dgv_Employe.Columns[3].Width = 130;
            dgv_Employe.Columns[4].HeaderText = "Type Produit";
            dgv_Employe.Columns[4].Width = 130;
            dgv_Employe.Columns[5].HeaderText = "Date naissance";
            dgv_Employe.Columns[5].Width = 80;
            dgv_Employe.Columns[6].HeaderText = "Date entrée";
            dgv_Employe.Columns[6].Width = 80;
            dgv_Employe.Columns[7].HeaderText = "Date sortie";
            dgv_Employe.Columns[7].Width = 80;
            dgv_Employe.Columns[8].HeaderText = "Responsable";
            dgv_Employe.Columns[8].Width = 75;
            dgv_Employe.Columns[9].HeaderText = "Autoriser BO ?";
            dgv_Employe.Columns[9].Width = 100;
            dgv_Employe.Columns[10].HeaderText = "Responsable ?";
            dgv_Employe.Columns[10].Width = 100;
        }
    }
}
