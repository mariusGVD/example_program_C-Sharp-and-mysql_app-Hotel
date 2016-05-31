using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Classes
{
    class Reserva
    {
        public Habitacio dadesHabitacio { get; set; }
        public Client dadesClient { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSortida { get; set; }
        public bool habitacioNeta { get; set; }

        public Reserva() { }
        public Reserva(Habitacio dh, Client dc, DateTime de, DateTime ds, bool hn)
        {
            this.dadesHabitacio = dh;
            this.dadesClient = dc;
            this.dataEntrada = de;
            this.dataSortida = ds;
            this.habitacioNeta = hn;
        }
    }
}
