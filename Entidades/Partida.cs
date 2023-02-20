using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        int numeroVidas;
        int numeroAciertos;
        string palabraSecreta;        
        private List<string> paises;
        private List<string> nombres;
        private List<string> animales;
        private List<string> colores;


        public Partida(int numeroVidas, int numeroAciertos, string palabraSecreta)
        {
            paises = new List<string>();
            nombres = new List<string>();
            animales = new List<string>();
            colores = new List<string>();
            this.numeroVidas = numeroVidas;
            this.numeroAciertos = numeroAciertos;
            this.palabraSecreta = palabraSecreta;
        }

        public List<string> Paises
        { 
            get { return paises; }
            set { paises = value; }
        }
        public List<string> Nombres
        { 
            get { return nombres; }
            set { nombres = value; }
        }
        public List<string> Animales
        { 
            get { return animales; }
            set { animales = value; }
        }
        public List<string> Colores
        { 
            get { return colores; }
            set { colores = value; }
        }
        public int NumeroVidas { get { return numeroVidas; } set { numeroVidas = value; } }
        public int NumeroAciertos { get { return numeroAciertos; } set { numeroAciertos = value; } }
        public string PalabraSecreta { get { return palabraSecreta; } set {palabraSecreta= value; } }




    }              
}
