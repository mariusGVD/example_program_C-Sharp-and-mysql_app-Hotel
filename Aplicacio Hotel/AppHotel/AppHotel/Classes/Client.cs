using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Classes
{
    class Client
    {
        #region Definició dels atributs

        public string dni { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }
        public string telefon { get; set; }
       
        #endregion

        //Constructors
        public Client()
        { }

        public Client(string dni, string nom, string cognoms, string telefon)
        {
            this.dni = dni;
            this.nom = nom;
            this.cognoms = cognoms;
            this.telefon = telefon;
        }
    }
}
