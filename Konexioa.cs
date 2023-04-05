using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERRONKA7
{
    internal class Konexioa
    {
        public static MySqlConnection connection; 
        public bool konexioaBurutu(string erabiltzailea, string pasahitza) 
        {
            bool konexioa = false;


            string connectionString = "server=localhost;port=3306;database=db_erronka7;uid="+ erabiltzailea +";password=" + pasahitza;

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                konexioa = true;
            }
            catch (Exception ex)
            {
                konexioa=false;
            }
            //finally
            //{
            //    connection.Close();
            //}
            return konexioa;
        }

    }
    
}
