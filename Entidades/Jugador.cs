using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private string nombre;
        private string tema;

        public Jugador(string nombre, string tema)
        {
            this.nombre = nombre;
            this.tema = tema;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
    }
}
