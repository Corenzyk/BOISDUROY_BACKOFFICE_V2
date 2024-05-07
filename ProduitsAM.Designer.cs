namespace BOISDUROY_BACKOFFICE
{
    partial class ProduitsAM
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.check_dispo = new System.Windows.Forms.CheckBox();
            this.lbl_lib = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.txt_lib = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.GB_AjoutModif = new System.Windows.Forms.GroupBox();
            this.GB_AjoutModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_titre.Location = new System.Drawing.Point(73, 23);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(0, 20);
            this.lbl_titre.TabIndex = 1;
            // 
            // check_dispo
            // 
            this.check_dispo.AutoSize = true;
            this.check_dispo.BackColor = System.Drawing.Color.Transparent;
            this.check_dispo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.check_dispo.Location = new System.Drawing.Point(64, 141);
            this.check_dispo.Name = "check_dispo";
            this.check_dispo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_dispo.Size = new System.Drawing.Size(111, 24);
            this.check_dispo.TabIndex = 19;
            this.check_dispo.Text = "? Disponible";
            this.check_dispo.UseVisualStyleBackColor = false;
            // 
            // lbl_lib
            // 
            this.lbl_lib.AutoSize = true;
            this.lbl_lib.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_lib.Location = new System.Drawing.Point(94, 115);
            this.lbl_lib.Name = "lbl_lib";
            this.lbl_lib.Size = new System.Drawing.Size(60, 20);
            this.lbl_lib.TabIndex = 6;
            this.lbl_lib.Text = "Libellé :";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(160, 89);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(226, 20);
            this.txt_code.TabIndex = 5;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Annuler.Location = new System.Drawing.Point(293, 201);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(74, 29);
            this.btn_Annuler.TabIndex = 4;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Valider.Location = new System.Drawing.Point(86, 201);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(74, 29);
            this.btn_Valider.TabIndex = 3;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // txt_lib
            // 
            this.txt_lib.Location = new System.Drawing.Point(160, 115);
            this.txt_lib.Name = "txt_lib";
            this.txt_lib.Size = new System.Drawing.Size(226, 20);
            this.txt_lib.TabIndex = 1;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_code.Location = new System.Drawing.Point(51, 89);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(103, 20);
            this.lbl_code.TabIndex = 0;
            this.lbl_code.Text = "Code Produit :";
            // 
            // GB_AjoutModif
            // 
            this.GB_AjoutModif.Controls.Add(this.lbl_titre);
            this.GB_AjoutModif.Controls.Add(this.check_dispo);
            this.GB_AjoutModif.Controls.Add(this.lbl_lib);
            this.GB_AjoutModif.Controls.Add(this.txt_code);
            this.GB_AjoutModif.Controls.Add(this.btn_Annuler);
            this.GB_AjoutModif.Controls.Add(this.btn_Valider);
            this.GB_AjoutModif.Controls.Add(this.txt_lib);
            this.GB_AjoutModif.Controls.Add(this.lbl_code);
            this.GB_AjoutModif.Location = new System.Drawing.Point(186, 75);
            this.GB_AjoutModif.Name = "GB_AjoutModif";
            this.GB_AjoutModif.Size = new System.Drawing.Size(428, 283);
            this.GB_AjoutModif.TabIndex = 1;
            this.GB_AjoutModif.TabStop = false;
            // 
            // ProduitsAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.GB_AjoutModif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduitsAM";
            this.Text = "Form1";
            this.GB_AjoutModif.ResumeLayout(false);
            this.GB_AjoutModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.CheckBox check_dispo;
        private System.Windows.Forms.Label lbl_lib;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.TextBox txt_lib;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.GroupBox GB_AjoutModif;
    }
}