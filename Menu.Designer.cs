namespace BOISDUROY_BACKOFFICE
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lab_BDR = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_menu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_BDR
            // 
            this.lab_BDR.AutoSize = true;
            this.lab_BDR.BackColor = System.Drawing.Color.White;
            this.lab_BDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_BDR.Location = new System.Drawing.Point(295, 382);
            this.lab_BDR.Name = "lab_BDR";
            this.lab_BDR.Size = new System.Drawing.Size(214, 41);
            this.lab_BDR.TabIndex = 3;
            this.lab_BDR.Text = "Bois du Roy";
            this.lab_BDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.BackgroundImage")));
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(251, 79);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(296, 300);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 2;
            this.pb_Logo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employésToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.notesDeFraisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employésToolStripMenuItem
            // 
            this.employésToolStripMenuItem.Name = "employésToolStripMenuItem";
            this.employésToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.employésToolStripMenuItem.Text = "Employés";
            this.employésToolStripMenuItem.Click += new System.EventHandler(this.employésToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // notesDeFraisToolStripMenuItem
            // 
            this.notesDeFraisToolStripMenuItem.Name = "notesDeFraisToolStripMenuItem";
            this.notesDeFraisToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.notesDeFraisToolStripMenuItem.Text = "Notes de frais";
            this.notesDeFraisToolStripMenuItem.Click += new System.EventHandler(this.notesDeFraisToolStripMenuItem_Click);
            // 
            // pan_menu
            // 
            this.pan_menu.Location = new System.Drawing.Point(0, 27);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(800, 423);
            this.pan_menu.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_BDR);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pan_menu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Gestion des notes";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_BDR;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesDeFraisToolStripMenuItem;
        public System.Windows.Forms.Panel pan_menu;
    }
}