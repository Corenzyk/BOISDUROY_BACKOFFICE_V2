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
    public class Fonctions
    {
        private DataTable dtListeFonc;
        private Connexion conn;

        public DataTable GetListeFonc(bool combo)
        {
            dtListeFonc = new DataTable();
            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CODE_FONCT, LIB_FONC FROM FONCTIONS;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeFonc.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeFonc.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeFonc.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeFonc;
        }
    }
}
