using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppHotel.Classes
{
    class HabitacioDAL
    {
        //Metode per obtenir les dades de l'habitacio que esta ocupada pel numero d'habitació
        public static Habitacio obtenirDadesHabitacio(int hnumHab)
        {
            Habitacio hab = new Habitacio();

            MySqlConnection con = FuncionsDB.obtenirConnexio();
            string sql = "SELECT * FROM habitacions WHERE num_hab=@hnumHab";
            MySqlCommand comandaSQL = new MySqlCommand(sql, con);
            comandaSQL.Parameters.AddWithValue("@hnumHab", hnumHab);
            MySqlDataReader dr = comandaSQL.ExecuteReader();
            while (dr.Read())
            {
                //Obtenimi les dades de l'habitacio
                hab.num_hab = dr.GetInt32("num_hab");
                hab.llits = dr.GetInt32("llits");
                hab.m2 = dr.GetInt32("m2");
                hab.nevera = dr.GetBoolean("nevera");
                hab.bany = dr.GetBoolean("bany");
                hab.tv = dr.GetBoolean("tv");
                
                
            }

            FuncionsDB.tancarConnexio(con);

            return hab;
        }
    }
        }
