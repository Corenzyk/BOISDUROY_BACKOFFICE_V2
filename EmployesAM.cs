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
    public partial class EmployesAM : Form
    {
        Employes emp;
        Produits prod;
        Fonctions fonc;
        SF SousForm;
        bool modif = false;

        public EmployesAM(String LabelGroupeBox)
        {
            init();
            check_sortie.Visible = false;
            dateP_DateSortie.Visible = false;
            lbl_titre.Text = LabelGroupeBox + "d\'un employé";
        }

        public EmployesAM(String LabelGroupeBox, string Matricule, string NomEmp, string PrenomEmp, string DateNaiss, string DateEntree, string DateSortie, string Fonc, string Prod, string Resp, bool estAuto, bool estResp)
        {
            init();
            if (DateSortie == null)
            {
                check_sortie.Checked = false;
                dateP_DateSortie.Visible = false;
            }
            else
            {
                check_sortie.Checked = true;
                dateP_DateSortie.Visible = true;
            }
            lbl_titre.Text = LabelGroupeBox+"d\'un employé";
            txt_Matricule.Text = Matricule;
            txt_NomEmp.Text = NomEmp;
            txt_PrenomEmp.Text = PrenomEmp;
            //Transmission fonction
            //Transmission produit
            dateP_DateNaiss.Value = Convert.ToDateTime(DateNaiss);
            dateP_DateEntree.Value = Convert.ToDateTime(DateEntree);
            //Transmission date sortie (cas si vide/null)
            check_resp.Checked = estResp;
            check_backoffice.Checked = estAuto;
            modif = true;
        }

        public void init()
        {
            InitializeComponent();
            emp = new Employes();
            prod = new Produits();
            fonc = new Fonctions();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pan_menu);

            cb_Fonc.DataSource = fonc.GetListeFonc(true);
            cb_Fonc.DisplayMember = "LIB_FONC";
            cb_Fonc.ValueMember = "CODE_FONCT";

            cb_Prod.DataSource = prod.GetListeProdComb(true);
            cb_Prod.DisplayMember = "LIB_PROD";
            cb_Prod.ValueMember = "CODE_PROD";

            cb_Resp.DataSource = emp.GetListeRespComb(true);
            cb_Resp.DisplayMember = "ID_EMP";
            cb_Resp.ValueMember = "ID_EMP";
        }

        private void btn_Annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click_1(object sender, EventArgs e)
        {
            if (txt_Matricule.Text == "" || txt_NomEmp.Text == "" || txt_PrenomEmp.Text == "" || dateP_DateNaiss.Value == null || dateP_DateEntree.Value == null || cb_Fonc.SelectedValue.ToString() == ""
                || cb_Prod.SelectedValue.ToString() == "" || (cb_Resp.SelectedValue.ToString() != "" && check_resp.Checked) || (cb_Resp.SelectedValue.ToString() != "REL" && check_resp.Checked)) //Conditions d'erreurs
            {
                string messageErreur = "Vous n'avez pas renseigner certains champs :";
                if (txt_Matricule.Text == "")
                {
                    messageErreur += "\r\n - Le matricule";
                }
                if (txt_NomEmp.Text == "")
                {
                    messageErreur += "\r\n - Le nom";
                }
                if (txt_PrenomEmp.Text == "")
                {
                    messageErreur += "\r\n - Le prénom";
                }
                if (dateP_DateNaiss.Value == null)
                {
                    messageErreur += "\r\n - La date de naissance";
                }
                if (dateP_DateEntree.Value == null)
                {
                    messageErreur += "\r\n - La date d'entrée";
                }
                if (cb_Fonc.SelectedValue.ToString() == "")
                {
                    messageErreur += "\r\n - La fonction";
                }
                if (cb_Prod.SelectedValue.ToString() == "")
                {
                    messageErreur += "\r\n - Le produit";
                }
                if (cb_Resp.SelectedValue.ToString() != "" && check_resp.Checked)
                {
                    messageErreur += "\r\nVous ne pouvez pas créer un employé responsable avec un responsable";
                }
                if (cb_Resp.SelectedValue.ToString() != "REL" && check_resp.Checked)
                {
                    messageErreur += "\r\nSi vous cochez \"Responsable\", la fonction de l'employé doit être \"Responsable commercial\"";
                }
                MessageBox.Show(messageErreur);
            }
            else
            {
                if (modif == false)
                {
                    emp.InsertEmp(txt_Matricule.Text, txt_NomEmp.Text, txt_PrenomEmp.Text, Convert.ToString(dateP_DateNaiss.Value), Convert.ToString(dateP_DateEntree.Value), Convert.ToString(cb_Fonc.SelectedValue), Convert.ToString(cb_Prod.SelectedValue), Convert.ToString(cb_Resp.SelectedValue), check_resp.Checked, check_backoffice.Checked); //Paramètres pour l'insertion
                }
                else
                {
                    emp.UpdateEmp(txt_Matricule.Text, txt_NomEmp.Text, txt_PrenomEmp.Text, Convert.ToString(dateP_DateNaiss.Value), Convert.ToString(dateP_DateEntree.Value), Convert.ToString(dateP_DateSortie.Value), Convert.ToString(cb_Fonc.SelectedValue), Convert.ToString(cb_Prod.SelectedValue), Convert.ToString(cb_Resp.SelectedValue), check_resp.Checked, check_backoffice.Checked, check_mdp.Checked);
                }
                ListeEmployes LE = new ListeEmployes();
                SousForm.openChildForm(LE);
                (System.Windows.Forms.Application.OpenForms["ListeEmployes"] as ListeEmployes).Rafraichir();
                this.Close();
            }
        }

        private void check_sortie_CheckedChanged(object sender, EventArgs e)
        {
            if (check_sortie.Checked == true)
            {
                dateP_DateSortie.Visible = true;
            }
            else
            {

                dateP_DateSortie.Visible = false;
            }
        }
    }
}
