using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista
{
    public partial class Form_Fin : Form
    {
        int auxFin;
        Jugador jugador;
        public Form_Fin(int aux, Jugador player)
        {
            InitializeComponent();
            jugador = player;
            auxFin = aux;   
        }

        private void Form_Fin_Load(object sender, EventArgs e)
        {
            if(auxFin == 0)
            {
                ptbFin.BackgroundImage = Resources.ganado;
                lblTexto.BackColor = Color.Green;
                lblTexto.Text = "FELIDADES HAS GANADO!!!" + "\n" + "ERES EL MEJOR";
            }else
            {
                ptbFin.BackgroundImage = Resources.perdiste;
                lblTexto.BackColor = Color.OrangeRed;
                lblTexto.Text = "ESTA VEZ NO SE PUDO" + "\n" + "MAS SUERTE LA PROXIMA";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Juego nuevo = new Form_Juego(jugador);
            this.Close();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_MenuInicio inicio = new Form_MenuInicio();
            this.Close();
            inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
