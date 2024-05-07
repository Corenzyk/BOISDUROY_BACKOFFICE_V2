using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BOISDUROY_BACKOFFICE.Models
{
    public class Connexion
    {
        private MySqlConnection connection;
        public MySqlConnection Connection
        { get { return connection; } }
        private string server;
        private string database;
        private string uid;
        private string password;

        private void Initialise()
        {
            server = "192.168.150.6";
            database = "boisDuRoy_gestionFrais";
            uid = "BDR_compta";
            password = "C0mPt@!2024G3sT10n";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public Connexion()
        {
            Initialise();
        }


    }
}
