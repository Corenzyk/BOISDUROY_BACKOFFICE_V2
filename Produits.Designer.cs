using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BOISDUROY_BACKOFFICE
{
    partial class ListeProduits
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
            this.dgv_Produit = new System.Windows.Forms.DataGridView();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.txt_RechercheP = new System.Windows.Forms.TextBox();
            this.lbl_Recherche = new System.Windows.Forms.Label();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.cb_dispo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produit)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Produit
            // 
            this.dgv_Produit.AllowUserToAddRows = false;
            this.dgv_Produit.AllowUserToDeleteRows = false;
            this.dgv_Produit.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produit.Location = new System.Drawing.Point(12, 115);
            this.dgv_Produit.Name = "dgv_Produit";
            this.dgv_Produit.RowTemplate.Height = 25;
            this.dgv_Produit.Size = new System.Drawing.Size(696, 296);
            this.dgv_Produit.TabIndex = 0;
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.txt_RechercheP);
            this.gb_recherche.Controls.Add(this.cb_dispo);
            this.gb_recherche.Controls.Add(this.lbl_Recherche);
            this.gb_recherche.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gb_recherche.Location = new System.Drawing.Point(246, 9);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(542, 100);
            this.gb_recherche.TabIndex = 1;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Rechercher";
            // 
            // txt_RechercheP
            // 
            this.txt_RechercheP.Location = new System.Drawing.Point(162, 26);
            this.txt_RechercheP.Name = "txt_RechercheP";
            this.txt_RechercheP.Size = new System.Drawing.Size(264, 27);
            this.txt_RechercheP.TabIndex = 5;
            // 
            // lbl_Recherche
            // 
            this.lbl_Recherche.AutoSize = true;
            this.lbl_Recherche.Location = new System.Drawing.Point(16, 29);
            this.lbl_Recherche.Name = "lbl_Recherche";
            this.lbl_Recherche.Size = new System.Drawing.Size(113, 20);
            this.lbl_Recherche.TabIndex = 2;
            this.lbl_Recherche.Text = "Libellé produit :";
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(216, 32);
            this.lbl_Titre.TabIndex = 2;
            this.lbl_Titre.Text = "Liste des produits";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_ajouter.Location = new System.Drawing.Point(714, 115);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(74, 29);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_modifier.Location = new System.Drawing.Point(714, 150);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(74, 30);
            this.btn_modifier.TabIndex = 4;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_supprimer.Location = new System.Drawing.Point(714, 186);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(74, 29);
            this.btn_supprimer.TabIndex = 5;
            this.btn_supprimer.Text = "Suppr";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // cb_dispo
            // 
            this.cb_dispo.AutoSize = true;
            this.cb_dispo.Location = new System.Drawing.Point(20, 70);
            this.cb_dispo.Name = "cb_dispo";
            this.cb_dispo.Size = new System.Drawing.Size(193, 24);
            this.cb_dispo.TabIndex = 4;
            this.cb_dispo.Text = "Le produit est disponible";
            this.cb_dispo.UseVisualStyleBackColor = true;
            // 
            // ListeProduits
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
            this.Controls.Add(this.dgv_Produit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeProduits";
            this.Text = "ListesGroupes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produit)).EndInit();
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
        private DataGridView dgv_Produit;
        private TextBox txt_RechercheP;
        private CheckBox cb_dispo;
    }
}