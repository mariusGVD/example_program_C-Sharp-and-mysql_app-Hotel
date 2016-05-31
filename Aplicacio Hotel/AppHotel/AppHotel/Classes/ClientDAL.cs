using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppHotel.Classes
{
    class ClientDAL
    {
        //Metode per obtenir les dades del client que ocupa l'habitacio per un dni 
        public static Client obtenirDadesClient(string cdni)
        {
            Client c = new Client();

            MySqlConnection con = FuncionsDB.obtenirConnexio();
            string sql = "SELECT * FROM clients WHERE dni=@cdni"; 
            MySqlCommand comandaSQL = new MySqlCommand(sql, con);
            comandaSQL.Parameters.AddWithValue("@cdni", cdni);
            MySqlDataReader dr = comandaSQL.ExecuteReader();
            while (dr.Read())
            {
                //Obtenim les dades del client
                c.dni = cdni;
                c.nom = dr.GetString("nom");
                c.cognoms = dr.GetString("cognoms");
                c.telefon = dr.GetString("telefon");
  
            }

            FuncionsDB.tancarConnexio(con);

            return c;
        }
    }
}
