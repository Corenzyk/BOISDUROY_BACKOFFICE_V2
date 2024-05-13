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
    public partial class ListeNotes : Form
    {
        private Notes note;
        private SF SousForm;

        public ListeNotes()
        {
            InitializeComponent();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pan_menu);
            note = new Notes();
            dgv_Notes.DataSource = note.GetListeNotes(false);
            dgv_Notes.Columns[0].HeaderText = "Date";
            dgv_Notes.Columns[0].Width = 80;
            dgv_Notes.Columns[1].HeaderText = "Description";
            dgv_Notes.Columns[1].Width = 150;
            dgv_Notes.Columns[2].HeaderText = "Employe";
            dgv_Notes.Columns[2].Width = 80;
            dgv_Notes.Columns[3].HeaderText = "Montant";
            dgv_Notes.Columns[3].Width = 50;
            dgv_Notes.Columns[4].HeaderText = "Raison Refus";
            dgv_Notes.Columns[4].Width = 300;
            dgv_Notes.Columns[5].HeaderText = "Decision";
            dgv_Notes.Columns[5].Width = 200;
        }
    }
}
