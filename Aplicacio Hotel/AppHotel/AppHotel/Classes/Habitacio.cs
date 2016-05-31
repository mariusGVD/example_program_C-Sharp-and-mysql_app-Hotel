using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Classes
{
    class Habitacio
    {
        #region Definició dels atributs

        public int num_hab { get; set; }
        public int llits { get; set; }
        public bool nevera { get; set; }
        public bool bany { get; set; }
        public bool tv { get; set; }
        public int m2 { get; set; }

        #endregion

        //Constructors
        public Habitacio()
        { }

        public Habitacio(int num_hab, int llits, bool nevera, bool bany, bool tv, int m2)
        {
            this.num_hab = num_hab;
            this.llits = llits;
            this.nevera = nevera;
            this.bany = bany;
            this.tv = tv;
            this.m2 = m2;
        }
    }
}
