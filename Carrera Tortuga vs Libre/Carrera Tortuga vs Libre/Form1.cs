using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera_Tortuga_vs_Libre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Liebre liebre;
        Tortuga tortuga;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTablero.Clear();
            string Cliebre;
            string Ctortuga;
            Ctortuga = Convert.ToString((txtCtortuga.Text));
            Cliebre = Convert.ToString(txtCliebre.Text);
            liebre = new Liebre(Cliebre);
            tortuga = new Tortuga(Ctortuga);

            while (liebre.Pocision < 80 && tortuga.Pocision < 80)

            {
                liebre.avanzar();
                txtTablero.Text += liebre.ToString();
                tortuga.avanzar();
                txtTablero.Text += tortuga.ToString();
            }
            if (liebre.Pocision >= 80)
            {
                txtTablero.Text += "la liebre gano";
            }
            else if (liebre.Pocision == tortuga.Pocision)
                txtTablero.Text += " la carrera esta empatada";

            else
                txtTablero.Text += "la tortuga gano ";
        }

    }

}