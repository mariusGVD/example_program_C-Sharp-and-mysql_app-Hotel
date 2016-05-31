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
    public partial class FormDadesHabitacio : Form
    {
        public FormDadesHabitacio(int num_hab)
        {
            InitializeComponent();

            Habitacio hab = HabitacioDAL.obtenirDadesHabitacio(num_hab);

            textBox1.Text = Convert.ToString(num_hab);
            textBox2.Text = hab.llits.ToString();
            //textBox3.Text = hab.nevera.ToString();
            //textBox4.Text = hab.tv.ToString();
            //textBox5.Text = hab.bany.ToString();
            if (hab.nevera == false)
            {
                textBox3.Text = "SI";
            }
            else
            {
                textBox3.Text = "NO";
            }
            if (hab.tv == false)
            {
                textBox4.Text = "SI";
            }
            else
            {
                textBox5.Text = "NO";
            }
            if (hab.bany == false)
            {
                textBox5.Text = "SI";
            }
            else
            {
                textBox5.Text = "NO";
            }
            textBox6.Text = hab.m2.ToString();

            
        }

        private void FormDadesHabitacio_Load(object sender, EventArgs e)
        {

        }

        
          

            
            
    }
}
