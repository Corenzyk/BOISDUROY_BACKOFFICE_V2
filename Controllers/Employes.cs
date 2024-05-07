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
    public class Employes
    {
        private DataTable dtListeEmp;
        private Connexion conn;

        public DataTable GetListeEmp(bool combo)
        {
            dtListeEmp = new DataTable();
            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ID_EMP,NOM_EMP,PRENOM_EMP,F.LIB_FONC,P.LIB_PROD,DATE_NAISS,DATE_ENTREE,DATE_SORTIE,ID_EMP_ETRE_SUPERVISE,EST_AUTO,EST_RESP " +
                    "FROM EMPLOYES E LEFT JOIN PRODUITS P ON E.CODE_PROD = P.CODE_PROD LEFT JOIN FONCTIONS F ON E.CODE_FONCT=F.CODE_FONCT ;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeEmp.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeEmp.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeEmp.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeEmp;
        }

        public DataTable GetListeRespComb(bool combo)
        {
            dtListeEmp = new DataTable();
            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ID_EMP, CONCAT(NOM_EMP,' ', PRENOM_EMP) FROM EMPLOYES WHERE EST_RESP = 1 AND DATE_SORTIE IS NULL;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeEmp.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeEmp.NewRow();
                        workRow[0] = "";
                        dtListeEmp.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
            return dtListeEmp;
        }

        public DataTable GetEmpByNom(string NomPrenomEmp)
        {
            dtListeEmp = new DataTable();
            conn = new Connexion();
            string rqtSql = "SELECT ID_EMP,NOM_EMP,PRENOM_EMP,F.LIB_FONC,P.LIB_PROD,DATE_NAISS,DATE_ENTREE,DATE_SORTIE,ID_EMP_ETRE_SUPERVISE,EST_AUTO,EST_RESP " +
                "FROM EMPLOYES E LEFT JOIN PRODUITS P ON E.CODE_PROD = P.CODE_PROD LEFT JOIN FONCTIONS F ON E.CODE_FONCT=F.CODE_FONCT";

            if (NomPrenomEmp != "")
            {
                rqtSql += "WHERE NOM_EMP LIKE '%" + NomPrenomEmp + "%' OR PRENOM_EMP LIKE '%" + NomPrenomEmp + "%' OR CONCAT(NOM_EMP,' ',PRENOM_EMP) LIKE '%" + NomPrenomEmp + "%';";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmp.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                conn.Connection.Close();
                return dtListeEmp;
            }
            else
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql+";", conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmp.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                conn.Connection.Close();
                return dtListeEmp;
            }
        }

        public DataTable GetEmpByFonc(string Fonc)
        {
            dtListeEmp = new DataTable();
            conn = new Connexion();
            string rqtSql = "SELECT ID_EMP,NOM_EMP,PRENOM_EMP,F.LIB_FONC,P.LIB_PROD,DATE_NAISS,DATE_ENTREE,DATE_SORTIE,ID_EMP_ETRE_SUPERVISE,EST_AUTO,EST_RESP " +
                "FROM EMPLOYES E LEFT JOIN PRODUITS P ON E.CODE_PROD = P.CODE_PROD RIGHT JOIN FONCTIONS F ON E.CODE_FONCT=F.CODE_FONCT";

            if (Fonc != "")
            {
                rqtSql += "WHERE LIB_FONC = '"+ Fonc+"';";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmp.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                conn.Connection.Close();
                return dtListeEmp;
            }
            else
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql+";", conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmp.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                conn.Connection.Close();
                return dtListeEmp;
            }
        }

        public DataTable GetEmpByProd(string Prod)
        {
            dtListeEmp = new DataTable();
            conn = new Connexion();
            string rqtSql = "SELECT ID_EMP,NOM_EMP,PRENOM_EMP,F.LIB_FONC,P.LIB_PROD,DATE_NAISS,DATE_ENTREE,DATE_SORTIE,ID_EMP_ETRE_SUPERVISE,EST_AUTO,EST_RESP " +
                "FROM EMPLOYES E RIGHT JOIN PRODUITS P ON E.CODE_PROD = P.CODE_PROD LEFT JOIN FONCTIONS F ON E.CODE_FONCT=F.CODE_FONCT";

            if (Prod != "")
            {
                rqtSql += "WHERE LIB_PROD = '" + Prod + "';";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmp.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                conn.Connection.Close();
                return dtListeEmp;
            }
            else
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql + ";", conn.Connection))
                    {
                        conn.Connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeEmp.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                conn.Connection.Close();
                return dtListeEmp;
            }
        }

        public void InsertEmp(string matricule, string nom, string prenom, string dateNaiss, string dateEntree, string codeFonc, string codeProd, string matResp, bool estResp, bool estAuto)
        {
            conn = new Connexion();
            string rqtSql = "INSERT INTO EMPLOYES (ID_EMP, CODE_FONCT, CODE_PROD, ID_EMP_ETRE_SUPERVISE, NOM_EMP, PRENOM_EMP, DATE_NAISS, DATE_ENTREE, DATE_SORTIE, PREM_CO, EST_AUTO, EST_RESP) " +
                "VALUES (@id, @codeFonc, @codeProd, @idResp, @nom, @prenom, @dateNaiss, @dateEntree, NULL, 1, @estAuto, @estResp);" +
                "UPDATE EMPLOYES SET MDP_EMP = PASSWORD(CONCAT(SUBSTRING(PRENOM_EMP,1,1),SUBSTRING(NOM_EMP,1,1),SUBSTRING(NOM_EMP,LENGTH(NOM_EMP),1),SUBSTRING(ID_EMP,3))) WHERE ID_EMP=@id;";
            try
            {
                conn.Connection.Open();
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);
                cmd.Parameters.AddWithValue("@id", matricule);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@date", dateNaiss);
                cmd.Parameters.AddWithValue("@dateEntree", dateEntree);
                cmd.Parameters.AddWithValue("@codeFonc", codeFonc);
                cmd.Parameters.AddWithValue("@codeProd", codeProd);
                cmd.Parameters.AddWithValue("@idResp", matResp);
                cmd.Parameters.AddWithValue("@estResp", estResp);
                cmd.Parameters.AddWithValue("@estAuto", estAuto);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
        }

        public void UpdateEmp(string matricule, string nom, string prenom, string dateNaiss, string dateEntree, string dateSortie, string codeFonc, string codeProd, string matResp, bool estResp, bool estAuto, bool resetMDP)
        {
            conn = new Connexion();
            string rqtSql = "UPDATE EMPLOYES SET CODE_FONCTION=@codeFonc, CODE_PROD=@codeProd, NOM_EMP=@nom, PRENOM_EMP=@prenom, " +
                "DATE_NAISS=@dateNaiss, DATE_ENTREE=@dateEntree, DATE_SORTIE=@dateSortie, EST_AUTO=@estAuto, EST_RESP=@estResp WHERE ID_EMP=@id;";
            if (resetMDP)
            {
                rqtSql += "UPDATE EMPLOYES SET PREM_CO=1, MDP_EMP=MDP_EMP = PASSWORD(CONCAT(SUBSTRING(PRENOM_EMP,1,1),SUBSTRING(NOM_EMP,1,1),SUBSTRING(NOM_EMP,LENGTH(NOM_EMP),1),SUBSTRING(ID_EMP,3))) " +
                    "WHERE ID_EMP=@id;";
            }

            try
            {
                conn.Connection.Open();
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);
                cmd.Parameters.AddWithValue("@id", matricule);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@date", dateNaiss);
                cmd.Parameters.AddWithValue("@dateEntree", dateEntree);
                cmd.Parameters.AddWithValue("@dateSortie", dateSortie);
                cmd.Parameters.AddWithValue("@codeFonc", codeFonc);
                cmd.Parameters.AddWithValue("@codeProd", codeProd);
                cmd.Parameters.AddWithValue("@idResp", matResp);
                cmd.Parameters.AddWithValue("@estResp", estResp);
                cmd.Parameters.AddWithValue("@estAuto", estAuto);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Connection.Close();
        }

        public bool DeleteEmp(int idEmp)
        {
            bool result = false;
            conn = new Connexion();
            string rqtSql = "UPDATE EMPLOYES SET DATE_SORTIE=DATE(NOW()), EST_AUTO=0; WHERE ID_EMP=@id";
            try
            {
                conn.Connection.Open();
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection);
                cmd.Parameters.AddWithValue("@id", idEmp);
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
