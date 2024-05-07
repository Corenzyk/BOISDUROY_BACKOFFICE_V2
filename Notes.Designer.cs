namespace BOISDUROY_BACKOFFICE
{
    partial class ListeNotes
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
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_val = new System.Windows.Forms.Button();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.dgv_Notes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_export.Location = new System.Drawing.Point(12, 124);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(101, 54);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Exporter la liste";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // btn_val
            // 
            this.btn_val.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_val.Location = new System.Drawing.Point(12, 64);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(101, 54);
            this.btn_val.TabIndex = 9;
            this.btn_val.Text = "Valider ou refuser";
            this.btn_val.UseVisualStyleBackColor = true;
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(182, 32);
            this.lbl_Titre.TabIndex = 8;
            this.lbl_Titre.Text = "Liste des notes";
            // 
            // dgv_Notes
            // 
            this.dgv_Notes.AllowUserToAddRows = false;
            this.dgv_Notes.AllowUserToDeleteRows = false;
            this.dgv_Notes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notes.Location = new System.Drawing.Point(119, 44);
            this.dgv_Notes.Name = "dgv_Notes";
            this.dgv_Notes.RowTemplate.Height = 25;
            this.dgv_Notes.Size = new System.Drawing.Size(669, 367);
            this.dgv_Notes.TabIndex = 6;
            // 
            // ListeNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.lbl_Titre);
            this.Controls.Add(this.dgv_Notes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeNotes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.DataGridView dgv_Notes;
    }
}