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
                using (MySqlCommand cmd = new MySqlCommand("SELECT NUM_NOTE, DESC_NOTE, DATE_NOTE, CONCAT(E.NOM_EMP,' ',E.PRENOM_EMP,' (',E.ID_EMP,')') FROM NOTES INNER JOIN EMPLOYES E ON NOTES.ID_EMP=E.ID_EMP;", conn.Connection))
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

        public DataTable GetListeNotes(bool combo, int IdNote)
        {
            dtListeNotes = new DataTable();
            conn = new Connexion();
            string rqtSql = "SELECT NUM_NOTE, DESC_NOTE, DATE_NOTE, CONCAT(E.NOM_EMP,' ',E.PRENOM_EMP,' (',E.ID_EMP,')') FROM NOTES INNER JOIN EMPLOYES E ON NOTES.ID_EMP=E.ID_EMP";
            if (IdNote > -1)
            {
                rqtSql += " WHERE NUM_NOTE = " + IdNote;
            }
            rqtSql += ";";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
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

        public String GetNoteById(int idArtiste)
        {
            String difficultePartie = "";
            if (idArtiste > -1)
            {
                string rqtSql = "SELECT IDARTISTE,LABELARTISTE,GROUPEARTISTE FROM artiste WHERE IDARTISTE = " + idArtiste + ";";
                dtListeNotes = new DataTable();
                conn = new Connexion();

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeNotes.Load(reader);

                    }
                    conn.Connection.Close();
                    if (dtListeNotes.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtListeNotes.Rows)
                        {
                            difficultePartie = row["LABELARTISTE"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            return difficultePartie;

        }

        public void InsertNote(string labelArtiste, bool groupeArtiste)
        {
            conn = new Connexion();
            string rqtSql = "INSERT INTO artiste (LABELARTISTE,GROUPEARTISTE) VALUES (@labelA,@groupeA);";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);

                cmd.Parameters.AddWithValue("@labelA", labelArtiste);
                cmd.Parameters.AddWithValue("@groupeA", groupeArtiste);
                conn.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
        }

        public void UpdateNote(int idArtiste, string labelArtiste, bool groupeArtiste)
        {
            conn = new Connexion();
            string rqtSql = "UPDATE artiste SET LABELARTISTE = @labelA, GROUPEARTISTE = @groupeA WHERE IDARTISTE = @idA;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);
                cmd.Parameters.AddWithValue("@labelA", labelArtiste);
                cmd.Parameters.AddWithValue("@groupeA", groupeArtiste);
                cmd.Parameters.AddWithValue("@idA", idArtiste);
                conn.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
        }

        public bool DeleteNote(int idArtiste)
        {
            bool result = false;
            conn = new Connexion();
            string rqtSql = "DELETE FROM artiste WHERE IDARTISTE = @idA;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);

                cmd.Parameters.AddWithValue("@idA", idArtiste);
                conn.Connection.Open();
                cmd.ExecuteNonQuery();
                result = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                result = false;
            }
            conn.Connection.Close();
            return result;
        }
    }
}
