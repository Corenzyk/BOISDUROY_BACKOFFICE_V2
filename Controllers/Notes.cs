using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOISDUROY_BACKOFFICE.Controllers;
using BOISDUROY_BACKOFFICE.Models;
using MySql.Data.MySqlClient;

namespace BOISDUROY_BACKOFFICE.Controllers
{
    internal class Notes
    {
        private DataTable dtListeNotes;
        private Connexion conn;

        public DataTable GetListeNotes(bool combo)
        {
            dtListeNotes = new DataTable();
            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT N.DATE_NOTE AS Date, N.DESC_NOTE AS Description, CONCAT(E.NOM_EMP,' ',E.PRENOM_EMP) AS Employe, CONCAT(SUM(LN.QUANT_FRAIS*F.MONTANT_REMB),' €') AS Montant, V.MOTIF_REFUS AS 'Raison Refus', ER.LIB_REMB AS Decision " +
                    "FROM NOTES N INNER JOIN LIGNES_NOTES LN ON N.NUM_NOTE=LN.NUM_NOTE INNER JOIN TYPES_FRAIS F ON LN.CODE_FRAIS=F.CODE_FRAIS INNER JOIN EMPLOYES E ON N. ID_EMP=E. ID_EMP INNER JOIN ETRE_VALIDE EV ON N.NUM_NOTE=EV.NUM_NOTE INNER JOIN VALIDATION V ON EV.IDVALID=V.IDVALID INNER JOIN ETAT_REMBOURSEMENT ER ON V.CODE_REMB=ER.CODE_REMB " +
                    "GROUP BY N.NUM_NOTE, N.DATE_NOTE, N.DESC_NOTE, CONCAT(E.NOM_EMP,' ',E.PRENOM_EMP), V.MOTIF_REFUS, ER.LIB_REMB;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeNotes.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeNotes.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeNotes.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeNotes;
        }
    }
}
