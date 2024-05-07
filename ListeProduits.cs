using BOISDUROY_BACKOFFICE.Controllers;
using BOISDUROY_BACKOFFICE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            cb_dispoO.Checked = true;
            dgv_Produit.DataSource = prod.GetListeProd(false);
            dgv_Produit.Columns[0].HeaderText = "Code";
            dgv_Produit.Columns[0].Width = 60;
            dgv_Produit.Columns[1].HeaderText = "Libellé";
            dgv_Produit.Columns[1].Width = 80;
            dgv_Produit.Columns[2].HeaderText = "Disponible ?";
            dgv_Produit.Columns[2].Width = 80;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            SousForm.openChildForm(new ProduitsAM("Création "));
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            SousForm.openChildForm(new ProduitsAM("Modification ", dgv_Produit.CurrentRow.Cells[0].Value.ToString(), dgv_Produit.CurrentRow.Cells[1].Value.ToString(), Convert.ToBoolean(dgv_Produit.CurrentRow.Cells[2].Value.ToString())));
        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult Valid = MessageBox.Show("Voulez vous supprimer le produit :" + dgv_Produit.CurrentRow.Cells[1].Value.ToString() + " ?", "Suppression de : " + dgv_Produit.CurrentRow.Cells[1].Value.ToString(), MessageBoxButtons.YesNo);
            if (Valid == DialogResult.Yes)
            {
                bool RetourSupp = prod.DeleteProd(dgv_Produit.CurrentRow.Cells[0].Value.ToString());
                if (RetourSupp)
                    Rafraichir();
            }
        }

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

        private void txt_RechercheP_TextChanged(object sender, EventArgs e)
        {
            dgv_Produit.DataSource = prod.GetProdByFiltre(txt_search.Text, cb_dispoO.Checked);
            dgv_Produit.Columns[0].HeaderText = "Code";
            dgv_Produit.Columns[0].Width = 60;
            dgv_Produit.Columns[1].HeaderText = "Libellé";
            dgv_Produit.Columns[1].Width = 80;
            dgv_Produit.Columns[2].HeaderText = "Disponible ?";
            dgv_Produit.Columns[2].Width = 80;
        }

        private void cb_dispoO_CheckedChanged(object sender, EventArgs e) //Plantage au chargement
        {
            if (cb_dispoO.Checked)
            {
                dgv_Produit.DataSource = prod.GetProdByFiltre(txt_search.Text, cb_dispoO.Checked);
                dgv_Produit.Columns[0].HeaderText = "Code";
                dgv_Produit.Columns[0].Width = 60;
                dgv_Produit.Columns[1].HeaderText = "Libellé";
                dgv_Produit.Columns[1].Width = 80;
                dgv_Produit.Columns[2].HeaderText = "Disponible ?";
                dgv_Produit.Columns[2].Width = 80;
            }
            else
            {
                dgv_Produit.DataSource = prod.GetProdByFiltre(txt_search.Text, cb_dispoO.Checked);
                dgv_Produit.Columns[0].HeaderText = "Code";
                dgv_Produit.Columns[0].Width = 60;
                dgv_Produit.Columns[1].HeaderText = "Libellé";
                dgv_Produit.Columns[1].Width = 80;
                dgv_Produit.Columns[2].HeaderText = "Disponible ?";
                dgv_Produit.Columns[2].Width = 80;
            }
        }
    }
}
