using BOISDUROY_BACKOFFICE.Controllers;
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
    public partial class ListeProduits : Form
    {
        private Produits prod;
        private SF SousForm;

        public ListeProduits()
        {
            InitializeComponent();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pan_menu);
            prod = new Produits();
            dgv_Produit.DataSource = prod.GetListeProd(false);
            dgv_Produit.Columns[0].HeaderText = "Code";
            dgv_Produit.Columns[0].Width = 60;
            dgv_Produit.Columns[1].HeaderText = "Libellé";
            dgv_Produit.Columns[1].Width = 80;
            dgv_Produit.Columns[2].HeaderText = "Disponible ?";
            dgv_Produit.Columns[2].Width = 80;
        }

        /*private void btn_ajouter_Click(object sender, EventArgs e)
        {

            SousForm.openChildForm(new EmployesAM("Ajouter un artiste"));

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {

            SousForm.openChildForm(new EmployesAM("Modifier un artiste", Convert.ToInt32(dgv_Employe.CurrentRow.Cells[0].Value.ToString()), dgv_Employe.CurrentRow.Cells[1].Value.ToString(), Convert.ToBoolean(dgv_Employe.CurrentRow.Cells[2].Value.ToString())));

        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult Valid = MessageBox.Show("Voulez vous supprimer l'artiste :" + dgv_Employe.CurrentRow.Cells[1].Value.ToString() + " ?", "Suppression de : " + dgv_Employe.CurrentRow.Cells[1].Value.ToString(), MessageBoxButtons.YesNo);
            if (Valid == DialogResult.Yes)
            {
                bool RetourSupp = emp.DeleteEmploye(Convert.ToInt32(dgv_Employe.CurrentRow.Cells[0].Value.ToString()));
                if (RetourSupp)
                    Rafraichir();
            }

        }*/

        public void Rafraichir()
        {
            dgv_Produit.DataSource = prod.GetListeProd(false);
            dgv_Produit.Columns[0].HeaderText = "Code";
            dgv_Produit.Columns[0].Width = 60;
            dgv_Produit.Columns[1].HeaderText = "Libellé";
            dgv_Produit.Columns[1].Width = 80;
            dgv_Produit.Columns[2].HeaderText = "Disponible ?";
            dgv_Produit.Columns[2].Width = 80;
        }
    }
}
