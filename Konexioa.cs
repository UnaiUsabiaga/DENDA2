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
        public static MySqlConnection connection; //declare an static connection to use all along the program
        public bool konexioaBurutu(string erabiltzailea, string pasahitza) 
        {
            bool konexioa = false;

            string server = "10.23.28.156"; //ip where the server/database is located
            string datubasea = "db_erronka7";//name of the database
            //sql sentence to connect to the database
            string connectionString = "server="+ server +";port=3306;database="+ datubasea +";uid="+ erabiltzailea +";password=" + pasahitza;

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();//open the connection
                konexioa = true;//if opens, turn boolean konexia = true
            }
            catch (Exception ex)
            {
                konexioa=false;//if the connection fails, turn konexioa = false
            }
            //finally
            //{
            //    connection.Close(); close the connection if needed
            //}
            return konexioa;// return the konexioa boolean
        }

    }
    
}
