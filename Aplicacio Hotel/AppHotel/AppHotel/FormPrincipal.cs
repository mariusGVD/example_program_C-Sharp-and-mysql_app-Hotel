using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHotel.Classes;

namespace AppHotel
{
    public partial class FormPrincipal : Form
    {
        static int numPlanta = 1;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            List<Reserva> res = ReservaDAL.obtenirReservesData(numPlanta, Convert.ToDateTime(dataTimeReserva.Text));
            canviarColorHabitacio(res);
        }

        //Metodes per carregar el numero de les habitacions per les plantes
        private void btnPlanta1_Click(object sender, EventArgs e)
        {
            int numPlanta = 1;
            DateTime data = dataTimeReserva.Value;
            txtPlanta1.Text = "Planta 1";
            txtHab101.Text = "101";
            txtHab102.Text = "102";
            txtHab103.Text = "103";
            txtHab104.Text = "104";
            txtHab105.Text = "105";
            txtHab106.Text = "106";
            txtHab107.Text = "107";
            txtHab108.Text = "108";
            txtHab109.Text = "109";
            txtHab110.Text = "110";
            txtHab111.Text = "111";
            txtHab112.Text = "112";

            List<Reserva> res = ReservaDAL.obtenirReservesData(numPlanta, Convert.ToDateTime(dataTimeReserva.Text));
            refreshHabitacio();
            canviarColorHabitacio(res);
        }

        private void btnPlanta2_Click(object sender, EventArgs e)
        {
            int numPlanta = 2;
            DateTime data = dataTimeReserva.Value;
            txtPlanta1.Text = "Planta 2";
            txtHab101.Text = "201";
            txtHab102.Text = "202";
            txtHab103.Text = "203";
            txtHab104.Text = "204";
            txtHab105.Text = "205";
            txtHab106.Text = "206";
            txtHab107.Text = "207";
            txtHab108.Text = "208";
            txtHab109.Text = "209";
            txtHab110.Text = "210";
            txtHab111.Text = "211";
            txtHab112.Text = "212";

            List<Reserva> res = ReservaDAL.obtenirReservesData(numPlanta, Convert.ToDateTime(dataTimeReserva.Text));
            refreshHabitacio();
            canviarColorHabitacio(res);

        }

        private void btnPlanta3_Click(object sender, EventArgs e)
        {
            int numPlanta = 3;
            DateTime data = dataTimeReserva.Value;
            txtPlanta1.Text = "Planta 3";
            txtHab101.Text = "301";
            txtHab102.Text = "302";
            txtHab103.Text = "303";
            txtHab104.Text = "304";
            txtHab105.Text = "305";
            txtHab106.Text = "306";
            txtHab107.Text = "307";
            txtHab108.Text = "308";
            txtHab109.Text = "309";
            txtHab110.Text = "310";
            txtHab111.Text = "311";
            txtHab112.Text = "312";

            List<Reserva> res = ReservaDAL.obtenirReservesData(numPlanta, Convert.ToDateTime(dataTimeReserva.Text));
            refreshHabitacio();
            canviarColorHabitacio(res);

        }

        //Metode per refrescar les dades i els colors a les habitacions un cop han estat ocupades
        private void refreshHabitacio()
        {
            //Pintarem les habitacions altra vegada verdes
            panel101.BackColor = Color.Green;
            panel102.BackColor = Color.Green;
            panel103.BackColor = Color.Green;
            panel104.BackColor = Color.Green;
            panel105.BackColor = Color.Green;
            panel106.BackColor = Color.Green;
            panel107.BackColor = Color.Green;
            panel107.BackColor = Color.Green;
            panel109.BackColor = Color.Green;
            panel110.BackColor = Color.Green;
            panel111.BackColor = Color.Green;
            panel112.BackColor = Color.Green;

            //Refrescar dades habitacions
            txtData101.Text = "";
            txtData1012.Text = "";
            txtData102.Text = "";
            txtData1022.Text = "";
            txtData103.Text = "";
            txtData1032.Text = "";
            txtData104.Text = "";
            txtData1042.Text = "";
            txtData105.Text = "";
            txtData1052.Text = "";
            txtData106.Text = "";
            txtData1062.Text = "";
            txtData107.Text = "";
            txtData1072.Text = "";
            txtData108.Text = "";
            txtData1082.Text = "";
            txtData109.Text = "";
            txtData1092.Text = "";
            txtData110.Text = "";
            txtData1102.Text = "";
            txtData111.Text = "";
            txtData1112.Text = "";
            txtData112.Text = "";
            txtData1122.Text = "";
            

        }

        private void dataTimeReserva_ValueChanged(object sender, EventArgs e)
        {
            List<Reserva> res = ReservaDAL.obtenirReservesData(numPlanta, Convert.ToDateTime(dataTimeReserva.Text));
            refreshHabitacio();
            canviarColorHabitacio(res);
        }

        //Metode per canviar el color  per les habitacions ocupades
        private void canviarColorHabitacio(List<Reserva> res)
        {
            for (int i = 0; i < res.Count(); i++)
            {
                switch (res[i].dadesHabitacio.num_hab)
                {
                    case 101:
                    case 201:
                    case 301:
                        txtData101.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1012.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel101.BackColor = Color.Red;
                        break;

                    case 102:
                    case 202:
                    case 302:
                        txtData102.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1022.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel102.BackColor = Color.Red;
                        break;

                    case 103:
                    case 203:
                    case 303:
                        txtData103.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1032.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel103.BackColor = Color.Red;
                        break;

                    case 104:
                    case 204:
                    case 304:
                        txtData104.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1042.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel104.BackColor = Color.Red;
                        break;

                    case 105:
                    case 205:
                    case 305:
                        txtData105.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1052.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel105.BackColor = Color.Red;
                        break;

                    case 106:
                    case 206:
                    case 306:
                        txtData106.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1062.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel106.BackColor = Color.Red;
                        break;

                    case 107:
                    case 207:
                    case 307:
                        txtData107.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1072.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel107.BackColor = Color.Red;
                        break;

                    case 108:
                    case 208:
                    case 308:
                        txtData108.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1082.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel108.BackColor = Color.Red;
                        break;

                    case 109:
                    case 209:
                    case 309:
                        txtData109.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1092.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel109.BackColor = Color.Red;
                        break;

                    case 110:
                    case 210:
                    case 310:
                        txtData110.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1102.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel110.BackColor = Color.Red;
                        break;

                    case 111:
                    case 211:
                    case 311:
                        txtData111.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1112.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel111.BackColor = Color.Red;
                        break;

                    case 112:
                    case 212:
                    case 312:
                        txtData112.Text = "Entrada : "+res[i].dataEntrada.ToString("dd-MM-yyyy");
                        txtData1122.Text = "Sortida : "+res[i].dataSortida.ToString("dd-MM-yyyy");
                        panel112.BackColor = Color.Red;
                        break;
                }
            }
        }

        private void panel101_Paint(object sender, PaintEventArgs e)
        {

        }

        //Metode per carregar els formularis al fer click a l'habitacio
        private void panel101_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab101.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
                
            
            }
        

        private void panel102_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab102.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
            }
        
        private void panel103_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab103.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        private void panel104_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab104.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        private void panel105_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab105.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        private void panel107_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab107.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        private void panel106_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab106.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        private void panel108_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab108.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }

        }

        private void panel109_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab109.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }

        }

        private void panel110_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab110.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        private void panel111_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab111.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();

            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }

        }

        private void panel112_Click(object sender, EventArgs e)
        {
            int num_hab = Convert.ToInt32(txtHab112.Text);
            string dni = ReservaDAL.obtenirReservaHabitacio(num_hab, dataTimeReserva.Value);

            if (dni == null)
            {

                Form fh = new FormDadesHabitacio(num_hab);
                fh.ShowDialog();
                
            }
            else
            {
                Form fc = new FormDadesClient(dni);
                fc.ShowDialog();
            }
        }

        


    }
}
