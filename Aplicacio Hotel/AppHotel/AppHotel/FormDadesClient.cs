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
    public partial class FormDadesClient : Form
    {
        public FormDadesClient(string dni)
        {
            InitializeComponent();

            Client c = new Client();
          
            
            c = ClientDAL.obtenirDadesClient(dni);
            textBox1.Text = dni;
            textBox2.Text = c.nom;
            textBox3.Text = c.cognoms;
            textBox4.Text = c.telefon;
            
        }
    }
}
