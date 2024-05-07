using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOISDUROY_BACKOFFICE.Controllers;
using BOISDUROY_BACKOFFICE.Models;
using MySql.Data.MySqlClient;

namespace BOISDUROY_BACKOFFICE.Controllers
{
    public class Logging
    {
        private DataTable dtLog;
        private Connexion conn;

        public int LogPossible(string id, string mdp)
        {
            conn = new Connexion();
            dtLog = new DataTable();
            string rqtSql = "SELECT ID_EMP FROM EMPLOYES WHERE ID_EMP=@id AND DATE_SORTIE IS NULL AND EST_AUTO=1 AND MDP_EMP = MD5(@mdp);";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                {
                    conn.Connection.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@mdp", mdp);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtLog.Load(reader);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtLog.Rows.Count;
        }
    }
}
