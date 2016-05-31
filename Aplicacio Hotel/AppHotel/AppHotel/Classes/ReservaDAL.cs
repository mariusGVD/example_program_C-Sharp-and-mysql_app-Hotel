using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppHotel.Classes
{
    class ReservaDAL
    {
        //Metode per obtenir una llista de reserves fetes en una data concreta per plantes
        public static List<Reserva> obtenirReservesData(int numPlanta, DateTime dataActual)
        {
            List<Reserva> res = new List<Reserva>();
            MySqlConnection con = FuncionsDB.obtenirConnexio();
            string sql = "";
            if (numPlanta == 1)
            {
                sql = sql = @"SELECT * FROM reserves WHERE num_hab between 101 and 112 and data_ent <= @data and data_sort >= @data"; ;
            }

            if (numPlanta == 2)
            {
                sql = sql = @"SELECT * FROM reserves WHERE num_hab between 201 and 212 and data_ent <= @data and data_sort >= @data";
            }
            if (numPlanta == 3)
            {
                sql = @"SELECT * FROM reserves WHERE num_hab between 301 and 312 and data_ent <= @data and data_sort >= @data";
            }

            MySqlCommand comandaSQL = new MySqlCommand(sql, con);
            comandaSQL.Parameters.AddWithValue("@data", dataActual);
            MySqlDataReader llegirDades = comandaSQL.ExecuteReader();
            while (llegirDades.Read())
            {
                Reserva reserva = new Reserva();
                //Obtenim el numero d'habitacio el dni i les dades d'entrada i sortida
                int n = llegirDades.GetInt32("num_hab");
                reserva.dadesHabitacio = HabitacioDAL.obtenirDadesHabitacio(n);

                string dni = llegirDades.GetString("dni");
                reserva.dadesClient = ClientDAL.obtenirDadesClient(dni);

                reserva.dataEntrada = llegirDades.GetDateTime("data_ent");
                reserva.dataSortida = llegirDades.GetDateTime("data_sort");

                res.Add(reserva);
            }


            FuncionsDB.tancarConnexio(con);

            return res;

        }

        //Metode per obtenir el dni del client que te reservada l'habitacio en una data concreta

        public static string obtenirReservaHabitacio(int num_hab, DateTime data)
        {


            MySqlConnection con = FuncionsDB.obtenirConnexio();

            string sql = "SELECT * FROM reserves WHERE num_hab=@numHab AND data_ent<=@data and data_sort>=@data";

            MySqlCommand comandaSQL = new MySqlCommand(sql, con);
            comandaSQL.Parameters.AddWithValue("@data", data);
            comandaSQL.Parameters.AddWithValue("@numHab", num_hab);
            MySqlDataReader dr = comandaSQL.ExecuteReader();
            
            if (dr.Read())
            {
                return dr.GetString("dni");
            }
            else
            {
                return null;
            }

        }
    }
}
