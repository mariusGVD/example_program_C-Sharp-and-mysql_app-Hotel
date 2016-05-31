using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppHotel.Classes
{
    class FuncionsDB
    {
        //Funcions per accedir a la BD
        //1r metode --> Accedir a la BD
        public static MySqlConnection obtenirConnexio()
        {
            MySqlConnection connexio = new MySqlConnection("Server=10.10.10.10;Port=3306;Database=m7_hotel;Uid=root;Pwd=minerva14;");
            //MySqlConnection connexio = new MySqlConnection("Server=localhost;Port=3306;Database=m7_hotel;Uid=root;Pwd=root;");

            connexio.Open(); //obra la connexio i la deixa oberta
            return connexio;
        }

        //2n metode --> tancar la conexió a la base de dades
        public static void tancarConnexio(MySqlConnection connexio)
        {
            connexio.Close();
        }
    }
}
