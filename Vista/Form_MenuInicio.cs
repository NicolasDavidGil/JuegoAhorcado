using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entidades;

namespace Vista
{
    public partial class Form_MenuInicio : Form
    {
        public Form_MenuInicio()
        {
            InitializeComponent();
        }

        private void Form_MenuInicio_Load(object sender, EventArgs e)
        {
            lblLogin.Visible = false;
            lblErrorTematica.Visible = false;
            cmbTematica.Items.Add("Paises");
            cmbTematica.Items.Add("Animales");
            cmbTematica.Items.Add("Colores");
            cmbTematica.Items.Add("Nombres");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool nombre = true;

            if(txtNombre.Text.Length != 0)
            {
                for(int i = 0; i < txtNombre.Text.Length; i++)
                {
                    if (!char.IsLetter(txtNombre.Text[i]))
                    {
                        nombre = false;
                        lblLogin.Visible = true;
                        break;
                    }
                }                               
            }

            if (cmbTematica.Text == "Paises" || cmbTematica.Text == "Animales" || cmbTematica.Text == "Colores" || cmbTematica.Text == "Nombres" && nombre)
            {
                Jugador jugador = new Jugador(txtNombre.Text, cmbTematica.Text);
                Form_Juego juego = new Form_Juego(jugador);
                this.Hide();
                juego.ShowDialog();
            }
            else
            {
                lblErrorTematica.Visible = true;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
