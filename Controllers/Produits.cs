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
    public class Produits
    {
        private DataTable dtListeProd;
        private Connexion conn;

        public DataTable GetListeProd(bool combo)
        {
            dtListeProd = new DataTable();
            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CODE_PROD, LIB_PROD, EST_DISPO FROM PRODUITS;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeProd.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeProd.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeProd.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeProd;
        }

        public DataTable GetListeProdComb(bool combo)
        {
            dtListeProd = new DataTable();
            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CODE_PROD, LIB_PROD FROM PRODUITS;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeProd.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeProd.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeProd.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeProd;
        }

        public DataTable GetListeProd(bool combo, string IdProd)
        {
            dtListeProd = new DataTable();
            conn = new Connexion();
            string rqtSql = "SELECT CODE_PROD, LIB_PROD, EST_DISPO FROM PRODUITS";
            if (IdProd != "")
            {
                rqtSql += " WHERE CODE_PROD = " + IdProd;
            }
            rqtSql += ";";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeProd.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeProd.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeProd.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeProd;
        }

        public String GetProdById(string codeP)
        {
            String leproduit = "";
            if (codeP != "")
            {
                string rqtSql = "SELECT CODE_PROD, LIB_PROD WHERE CODE_PROD = '" + codeP + "';";
                dtListeProd = new DataTable();
                conn = new Connexion();

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeProd.Load(reader);

                    }
                    conn.Connection.Close();
                    if (dtListeProd.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtListeProd.Rows)
                        {
                            leproduit = row["LIB_PROD"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return leproduit;
        }


        public void InsertProd(string code, string nom, bool dispo)
        {
            conn = new Connexion();
            string rqtSql = "INSERT INTO PRODUITS (CODE_PROD, LIB_PROD, EST_DISPO) VALUES (@id, @nom, @estDispo);";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);
                cmd.Parameters.AddWithValue("@id", code);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@estDispo", dispo); 
                conn.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
        }

        public void UpdateProd(string code, string nom, bool dispo)
        {
            conn = new Connexion();
            string rqtSql = "UPDATE PRODUITS SET LIB_PROD=@nom, EST_DISPO=@estDispo WHERE CODE_PROD=@id;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);
                cmd.Parameters.AddWithValue("@id", code);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@estDispo", dispo);
                conn.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
        }

        public bool DeleteProd(int idProd)
        {
            bool result = false;
            conn = new Connexion();
            string rqtSql = "UPDATE PRODUITS SET EST_DISPO=0 WHERE CODE_PROD=@id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);

                cmd.Parameters.AddWithValue("@id", idProd);
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
