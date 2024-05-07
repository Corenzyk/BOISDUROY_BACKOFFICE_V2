using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BOISDUROY_BACKOFFICE
{
    partial class ListeEmployes
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
            this.dgv_Employe = new System.Windows.Forms.DataGridView();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.cb_prod = new System.Windows.Forms.ComboBox();
            this.cb_fonc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_Recherche = new System.Windows.Forms.Label();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employe)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Employe
            // 
            this.dgv_Employe.AllowUserToAddRows = false;
            this.dgv_Employe.AllowUserToDeleteRows = false;
            this.dgv_Employe.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Employe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employe.Location = new System.Drawing.Point(12, 125);
            this.dgv_Employe.Name = "dgv_Employe";
            this.dgv_Employe.RowTemplate.Height = 25;
            this.dgv_Employe.Size = new System.Drawing.Size(696, 286);
            this.dgv_Employe.TabIndex = 0;
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.cb_prod);
            this.gb_recherche.Controls.Add(this.cb_fonc);
            this.gb_recherche.Controls.Add(this.label3);
            this.gb_recherche.Controls.Add(this.label2);
            this.gb_recherche.Controls.Add(this.label1);
            this.gb_recherche.Controls.Add(this.txt_search);
            this.gb_recherche.Controls.Add(this.lbl_Recherche);
            this.gb_recherche.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gb_recherche.Location = new System.Drawing.Point(246, -1);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(542, 120);
            this.gb_recherche.TabIndex = 1;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Rechercher";
            // 
            // cb_prod
            // 
            this.cb_prod.FormattingEnabled = true;
            this.cb_prod.Location = new System.Drawing.Point(174, 83);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(352, 28);
            this.cb_prod.TabIndex = 11;
            this.cb_prod.SelectedIndexChanged += new System.EventHandler(this.cb_prod_SelectedIndexChanged);
            // 
            // cb_fonc
            // 
            this.cb_fonc.FormattingEnabled = true;
            this.cb_fonc.Location = new System.Drawing.Point(174, 49);
            this.cb_fonc.Name = "cb_fonc";
            this.cb_fonc.Size = new System.Drawing.Size(352, 28);
            this.cb_fonc.TabIndex = 10;
            this.cb_fonc.SelectedIndexChanged += new System.EventHandler(this.cb_fonc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fonction :";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(174, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(352, 27);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_Recherche
            // 
            this.lbl_Recherche.AutoSize = true;
            this.lbl_Recherche.Location = new System.Drawing.Point(54, 19);
            this.lbl_Recherche.Name = "lbl_Recherche";
            this.lbl_Recherche.Size = new System.Drawing.Size(114, 20);
            this.lbl_Recherche.TabIndex = 2;
            this.lbl_Recherche.Text = "Nom - Prenom :";
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(228, 32);
            this.lbl_Titre.TabIndex = 2;
            this.lbl_Titre.Text = "Liste des employés";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_ajouter.Location = new System.Drawing.Point(714, 124);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(74, 29);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click_1);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_modifier.Location = new System.Drawing.Point(714, 159);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(74, 30);
            this.btn_modifier.TabIndex = 4;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click_1);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_supprimer.Location = new System.Drawing.Point(714, 195);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(74, 29);
            this.btn_supprimer.TabIndex = 5;
            this.btn_supprimer.Text = "Suppr";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click_1);
            // 
            // ListeEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.lbl_Titre);
            this.Controls.Add(this.gb_recherche);
            this.Controls.Add(this.dgv_Employe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeEmployes";
            this.Text = "ListesGroupes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employe)).EndInit();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gb_recherche;
        private Label lbl_Recherche;
        private Label lbl_Titre;
        private Button btn_ajouter;
        private Button btn_modifier;
        private Button btn_supprimer;
        private DataGridView dgv_Employe;
        private TextBox txt_search;
        private Label label2;
        private Label label1;
        private ComboBox cb_prod;
        private ComboBox cb_fonc;
        private Label label3;
    }
}