using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BOISDUROY_BACKOFFICE
{
    partial class EmployesAM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_AjoutModif = new System.Windows.Forms.GroupBox();
            this.check_sortie = new System.Windows.Forms.CheckBox();
            this.cb_Fonc = new System.Windows.Forms.ComboBox();
            this.lbl_Fonc = new System.Windows.Forms.Label();
            this.cb_Prod = new System.Windows.Forms.ComboBox();
            this.lbl_Prod = new System.Windows.Forms.Label();
            this.cb_Resp = new System.Windows.Forms.ComboBox();
            this.lbl_Resp = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.check_resp = new System.Windows.Forms.CheckBox();
            this.check_backoffice = new System.Windows.Forms.CheckBox();
            this.dateP_DateEntree = new System.Windows.Forms.DateTimePicker();
            this.dateP_DateSortie = new System.Windows.Forms.DateTimePicker();
            this.dateP_DateNaiss = new System.Windows.Forms.DateTimePicker();
            this.check_mdp = new System.Windows.Forms.CheckBox();
            this.lbl_DateEntree = new System.Windows.Forms.Label();
            this.lbl_DateNaiss = new System.Windows.Forms.Label();
            this.lbl_prenomEmp = new System.Windows.Forms.Label();
            this.txt_PrenomEmp = new System.Windows.Forms.TextBox();
            this.lbl_nomEmp = new System.Windows.Forms.Label();
            this.txt_Matricule = new System.Windows.Forms.TextBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.txt_NomEmp = new System.Windows.Forms.TextBox();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.GB_AjoutModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_AjoutModif
            // 
            this.GB_AjoutModif.Controls.Add(this.check_sortie);
            this.GB_AjoutModif.Controls.Add(this.cb_Fonc);
            this.GB_AjoutModif.Controls.Add(this.lbl_Fonc);
            this.GB_AjoutModif.Controls.Add(this.cb_Prod);
            this.GB_AjoutModif.Controls.Add(this.lbl_Prod);
            this.GB_AjoutModif.Controls.Add(this.cb_Resp);
            this.GB_AjoutModif.Controls.Add(this.lbl_Resp);
            this.GB_AjoutModif.Controls.Add(this.lbl_titre);
            this.GB_AjoutModif.Controls.Add(this.check_resp);
            this.GB_AjoutModif.Controls.Add(this.check_backoffice);
            this.GB_AjoutModif.Controls.Add(this.dateP_DateEntree);
            this.GB_AjoutModif.Controls.Add(this.dateP_DateSortie);
            this.GB_AjoutModif.Controls.Add(this.dateP_DateNaiss);
            this.GB_AjoutModif.Controls.Add(this.check_mdp);
            this.GB_AjoutModif.Controls.Add(this.lbl_DateEntree);
            this.GB_AjoutModif.Controls.Add(this.lbl_DateNaiss);
            this.GB_AjoutModif.Controls.Add(this.lbl_prenomEmp);
            this.GB_AjoutModif.Controls.Add(this.txt_PrenomEmp);
            this.GB_AjoutModif.Controls.Add(this.lbl_nomEmp);
            this.GB_AjoutModif.Controls.Add(this.txt_Matricule);
            this.GB_AjoutModif.Controls.Add(this.btn_Annuler);
            this.GB_AjoutModif.Controls.Add(this.btn_Valider);
            this.GB_AjoutModif.Controls.Add(this.txt_NomEmp);
            this.GB_AjoutModif.Controls.Add(this.lbl_matricule);
            this.GB_AjoutModif.Location = new System.Drawing.Point(187, 0);
            this.GB_AjoutModif.Name = "GB_AjoutModif";
            this.GB_AjoutModif.Size = new System.Drawing.Size(428, 411);
            this.GB_AjoutModif.TabIndex = 0;
            this.GB_AjoutModif.TabStop = false;
            // 
            // check_sortie
            // 
            this.check_sortie.AutoSize = true;
            this.check_sortie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.check_sortie.Location = new System.Drawing.Point(41, 238);
            this.check_sortie.Name = "check_sortie";
            this.check_sortie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_sortie.Size = new System.Drawing.Size(133, 24);
            this.check_sortie.TabIndex = 28;
            this.check_sortie.Text = "? Date de sortie";
            this.check_sortie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_sortie.UseVisualStyleBackColor = true;
            this.check_sortie.CheckedChanged += new System.EventHandler(this.check_sortie_CheckedChanged);
            // 
            // cb_Fonc
            // 
            this.cb_Fonc.FormattingEnabled = true;
            this.cb_Fonc.Location = new System.Drawing.Point(161, 133);
            this.cb_Fonc.Name = "cb_Fonc";
            this.cb_Fonc.Size = new System.Drawing.Size(226, 21);
            this.cb_Fonc.TabIndex = 27;
            // 
            // lbl_Fonc
            // 
            this.lbl_Fonc.AutoSize = true;
            this.lbl_Fonc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_Fonc.Location = new System.Drawing.Point(82, 133);
            this.lbl_Fonc.Name = "lbl_Fonc";
            this.lbl_Fonc.Size = new System.Drawing.Size(73, 20);
            this.lbl_Fonc.TabIndex = 26;
            this.lbl_Fonc.Text = "Fonction :";
            // 
            // cb_Prod
            // 
            this.cb_Prod.FormattingEnabled = true;
            this.cb_Prod.Location = new System.Drawing.Point(161, 160);
            this.cb_Prod.Name = "cb_Prod";
            this.cb_Prod.Size = new System.Drawing.Size(226, 21);
            this.cb_Prod.TabIndex = 25;
            // 
            // lbl_Prod
            // 
            this.lbl_Prod.AutoSize = true;
            this.lbl_Prod.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_Prod.Location = new System.Drawing.Point(55, 160);
            this.lbl_Prod.Name = "lbl_Prod";
            this.lbl_Prod.Size = new System.Drawing.Size(100, 20);
            this.lbl_Prod.TabIndex = 24;
            this.lbl_Prod.Text = "Type produit :";
            // 
            // cb_Resp
            // 
            this.cb_Resp.FormattingEnabled = true;
            this.cb_Resp.Location = new System.Drawing.Point(161, 265);
            this.cb_Resp.Name = "cb_Resp";
            this.cb_Resp.Size = new System.Drawing.Size(226, 21);
            this.cb_Resp.TabIndex = 23;
            // 
            // lbl_Resp
            // 
            this.lbl_Resp.AutoSize = true;
            this.lbl_Resp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_Resp.Location = new System.Drawing.Point(55, 266);
            this.lbl_Resp.Name = "lbl_Resp";
            this.lbl_Resp.Size = new System.Drawing.Size(100, 20);
            this.lbl_Resp.TabIndex = 22;
            this.lbl_Resp.Text = "Responsable :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_titre.Location = new System.Drawing.Point(75, 16);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(0, 20);
            this.lbl_titre.TabIndex = 1;
            // 
            // check_resp
            // 
            this.check_resp.AutoSize = true;
            this.check_resp.BackColor = System.Drawing.Color.Transparent;
            this.check_resp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.check_resp.Location = new System.Drawing.Point(106, 322);
            this.check_resp.Name = "check_resp";
            this.check_resp.Size = new System.Drawing.Size(112, 24);
            this.check_resp.TabIndex = 20;
            this.check_resp.Text = "Responsable";
            this.check_resp.UseVisualStyleBackColor = false;
            // 
            // check_backoffice
            // 
            this.check_backoffice.AutoSize = true;
            this.check_backoffice.BackColor = System.Drawing.Color.Transparent;
            this.check_backoffice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.check_backoffice.Location = new System.Drawing.Point(106, 352);
            this.check_backoffice.Name = "check_backoffice";
            this.check_backoffice.Size = new System.Drawing.Size(161, 24);
            this.check_backoffice.TabIndex = 19;
            this.check_backoffice.Text = "Accès au BackOffice";
            this.check_backoffice.UseVisualStyleBackColor = false;
            // 
            // dateP_DateEntree
            // 
            this.dateP_DateEntree.Location = new System.Drawing.Point(161, 213);
            this.dateP_DateEntree.Name = "dateP_DateEntree";
            this.dateP_DateEntree.Size = new System.Drawing.Size(226, 20);
            this.dateP_DateEntree.TabIndex = 18;
            // 
            // dateP_DateSortie
            // 
            this.dateP_DateSortie.Location = new System.Drawing.Point(180, 239);
            this.dateP_DateSortie.Name = "dateP_DateSortie";
            this.dateP_DateSortie.Size = new System.Drawing.Size(207, 20);
            this.dateP_DateSortie.TabIndex = 17;
            // 
            // dateP_DateNaiss
            // 
            this.dateP_DateNaiss.Location = new System.Drawing.Point(161, 187);
            this.dateP_DateNaiss.Name = "dateP_DateNaiss";
            this.dateP_DateNaiss.Size = new System.Drawing.Size(226, 20);
            this.dateP_DateNaiss.TabIndex = 1;
            // 
            // check_mdp
            // 
            this.check_mdp.AutoSize = true;
            this.check_mdp.BackColor = System.Drawing.Color.Transparent;
            this.check_mdp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.check_mdp.Location = new System.Drawing.Point(106, 292);
            this.check_mdp.Name = "check_mdp";
            this.check_mdp.Size = new System.Drawing.Size(258, 24);
            this.check_mdp.TabIndex = 1;
            this.check_mdp.Text = "Mettre le mot de passe par défault";
            this.check_mdp.UseVisualStyleBackColor = false;
            // 
            // lbl_DateEntree
            // 
            this.lbl_DateEntree.AutoSize = true;
            this.lbl_DateEntree.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_DateEntree.Location = new System.Drawing.Point(49, 213);
            this.lbl_DateEntree.Name = "lbl_DateEntree";
            this.lbl_DateEntree.Size = new System.Drawing.Size(106, 20);
            this.lbl_DateEntree.TabIndex = 12;
            this.lbl_DateEntree.Text = "Date d\'entrée :";
            // 
            // lbl_DateNaiss
            // 
            this.lbl_DateNaiss.AutoSize = true;
            this.lbl_DateNaiss.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_DateNaiss.Location = new System.Drawing.Point(19, 187);
            this.lbl_DateNaiss.Name = "lbl_DateNaiss";
            this.lbl_DateNaiss.Size = new System.Drawing.Size(136, 20);
            this.lbl_DateNaiss.TabIndex = 10;
            this.lbl_DateNaiss.Text = "Date de naissance :";
            // 
            // lbl_prenomEmp
            // 
            this.lbl_prenomEmp.AutoSize = true;
            this.lbl_prenomEmp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_prenomEmp.Location = new System.Drawing.Point(88, 107);
            this.lbl_prenomEmp.Name = "lbl_prenomEmp";
            this.lbl_prenomEmp.Size = new System.Drawing.Size(67, 20);
            this.lbl_prenomEmp.TabIndex = 8;
            this.lbl_prenomEmp.Text = "Prenom :";
            // 
            // txt_PrenomEmp
            // 
            this.txt_PrenomEmp.Location = new System.Drawing.Point(161, 107);
            this.txt_PrenomEmp.Name = "txt_PrenomEmp";
            this.txt_PrenomEmp.Size = new System.Drawing.Size(226, 20);
            this.txt_PrenomEmp.TabIndex = 7;
            // 
            // lbl_nomEmp
            // 
            this.lbl_nomEmp.AutoSize = true;
            this.lbl_nomEmp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_nomEmp.Location = new System.Drawing.Point(102, 81);
            this.lbl_nomEmp.Name = "lbl_nomEmp";
            this.lbl_nomEmp.Size = new System.Drawing.Size(53, 20);
            this.lbl_nomEmp.TabIndex = 6;
            this.lbl_nomEmp.Text = "Nom : ";
            // 
            // txt_Matricule
            // 
            this.txt_Matricule.Location = new System.Drawing.Point(161, 55);
            this.txt_Matricule.Name = "txt_Matricule";
            this.txt_Matricule.Size = new System.Drawing.Size(226, 20);
            this.txt_Matricule.TabIndex = 5;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Annuler.Location = new System.Drawing.Point(302, 378);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(74, 29);
            this.btn_Annuler.TabIndex = 4;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click_1);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Valider.Location = new System.Drawing.Point(59, 378);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(74, 29);
            this.btn_Valider.TabIndex = 3;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click_1);
            // 
            // txt_NomEmp
            // 
            this.txt_NomEmp.Location = new System.Drawing.Point(161, 81);
            this.txt_NomEmp.Name = "txt_NomEmp";
            this.txt_NomEmp.Size = new System.Drawing.Size(226, 20);
            this.txt_NomEmp.TabIndex = 1;
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_matricule.Location = new System.Drawing.Point(77, 55);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(82, 20);
            this.lbl_matricule.TabIndex = 0;
            this.lbl_matricule.Text = "Matricule : ";
            // 
            // EmployesAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.GB_AjoutModif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployesAM";
            this.Text = "EmployesAM";
            this.GB_AjoutModif.ResumeLayout(false);
            this.GB_AjoutModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GB_AjoutModif;
        private CheckBox CHK_Groupe;
        private TextBox txt_NomEmp;
        private Label lbl_matricule;
        private Button btn_Annuler;
        private Button btn_Valider;
        private TextBox txt_Matricule;
        private Label lbl_nomEmp;
        private Label lbl_DateEntree;
        private Label lbl_DateNaiss;
        private Label lbl_prenomEmp;
        private TextBox txt_PrenomEmp;
        private CheckBox check_mdp;
        private Label lbl_titre;
        private CheckBox check_resp;
        private CheckBox check_backoffice;
        private DateTimePicker dateP_DateEntree;
        private DateTimePicker dateP_DateSortie;
        private DateTimePicker dateP_DateNaiss;
        private ComboBox cb_Prod;
        private Label lbl_Prod;
        private ComboBox cb_Resp;
        private Label lbl_Resp;
        private ComboBox cb_Fonc;
        private Label lbl_Fonc;
        private CheckBox check_sortie;
    }
}