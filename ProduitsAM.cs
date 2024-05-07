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
    public partial class ProduitsAM : Form
    {
        Produits prod;
        SF SousForm;
        bool modif = false;

        public ProduitsAM(String LabelGroupeBox)
        {
            init();
            lbl_titre.Text = LabelGroupeBox + "d\'un produit";
        }

        public ProduitsAM(String LabelGroupeBox, string Code, string Lib, bool estDispo)
        {
            init();
            lbl_titre.Text = LabelGroupeBox + "d\'un produit";
            txt_code.Text = Code;
            txt_lib.Text = Lib;
            check_dispo.Checked = estDispo;
            modif = true;
        }

        public void init()
        {
            InitializeComponent();
            prod = new Produits();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pan_menu);
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "" || txt_lib.Text == "") //Conditions d'erreurs
            {
                string messageErreur = "Vous n'avez pas renseigner certains champs :";
                if (txt_code.Text == "")
                {
                    messageErreur += "\r\n - Le code";
                }
                if (txt_lib.Text == "")
                {
                    messageErreur += "\r\n - Le libellé";
                }
                MessageBox.Show(messageErreur);
            }
            else
            {
                if (modif == false)
                {
                    //Insertion non réalisée
                    prod.InsertProd(txt_code.Text, txt_lib.Text, check_dispo.Checked); //Paramètres pour l'insertion
                }
                else
                {
                    //Update non réalisée
                    prod.UpdateProd(txt_code.Text, txt_lib.Text, check_dispo.Checked);
                }
                ListeEmployes LE = new ListeEmployes();
                SousForm.openChildForm(LE);
                (System.Windows.Forms.Application.OpenForms["ListeProduits"] as ListeProduits).Rafraichir();
                this.Close();
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
