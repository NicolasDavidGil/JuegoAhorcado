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

namespace Vista
{
    public partial class Form_Juego : Form, IGame
    {       
        Jugador miJugador = new Jugador("aa", "aa");        
        Partida juego = new Partida(6, 0, "aa");
        public string name { get => lblNombre.Text; set => lblNombre.Text = value; }
        public string tema { get => lblTematica.Text; set => lblTematica.Text = value; }        

        public Form_Juego(Jugador player)
        {
            InitializeComponent();
            miJugador = player;
            name = "Bienvenido " + miJugador.Nombre;
            tema = "Jugaremos con la temática: " + miJugador.Tema;
            Inicializador.IniciarPaises(juego.Paises);
            Inicializador.IniciarNombres(juego.Nombres);
            Inicializador.IniciarColores(juego.Colores);
            Inicializador.IniciarAnimales(juego.Animales);
        }

        private void Form_Juego_Load(object sender, EventArgs e)
        {                        
            ElegirPalabra(juego);

            MostrarPalabra(juego);

            MostrarVidas();

            lblConsigna.Text = "Juego en curso, elija una letra.";

        }
        
        public void MostrarVidas()
        {
            lblVidasRestantes.Text = juego.NumeroVidas.ToString();
            lblVidasRestantes.Refresh();
        }

        public bool BuscarLetra(char letra, Partida game)
        {
            bool encontro = false;
            List<int> posiciones = new List<int>();

            for(int i = 0; i < game.PalabraSecreta.Length; i++)
            {
                if(letra == game.PalabraSecreta[i])
                {
                    posiciones.Add(i+1);
                    encontro = true;
                }
            }

            if(encontro)
            {
                for(int i = 0; i < posiciones.Count; i++)
                {
                    switch(posiciones[i])
                    {
                        case 1:
                            lbl1.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 2:
                            lbl2.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 3:
                            lbl3.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 4:
                            lbl4.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 5:
                            lbl5.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 6:
                            lbl6.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 7:
                            lbl7.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 8:
                            lbl8.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 9:
                            lbl9.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                        case 10:
                            lbl10.Text = letra.ToString();
                            juego.NumeroAciertos++;
                            break;
                    }
                }
            }            
            return encontro;
        }

        public void FinDelJuego()
        {
            if (juego.NumeroVidas == 0)
            {
                Form_Fin final = new Form_Fin(1, miJugador);
                this.Close();
                final.Show();
            }
            if (juego.NumeroAciertos == juego.PalabraSecreta.Length)
            {
                Form_Fin final = new Form_Fin(0, miJugador);
                this.Close();
                final.Show();
            }
        }
        public void MostrarPalabra(Partida game)
        {
            int largo = 0;
            for(int i = 0; i < game.PalabraSecreta.Length; i++)
            {
                largo++;
            }

            switch (largo)
            {
                case 4:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "";
                    lbl6.Text = "";
                    lbl7.Text = "";
                    lbl8.Text = "";
                    lbl9.Text = "";
                    lbl10.Text = "";
                    break;
                case 5:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "_";
                    lbl6.Text = "";
                    lbl7.Text = "";
                    lbl8.Text = "";
                    lbl9.Text = "";
                    lbl10.Text = "";
                    break;
                case 6:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "_";
                    lbl6.Text = "_";
                    lbl7.Text = "";
                    lbl8.Text = "";
                    lbl9.Text = "";
                    lbl10.Text = "";
                    break;
                case 7:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "_";
                    lbl6.Text = "_";
                    lbl7.Text = "_";
                    lbl8.Text = "";
                    lbl9.Text = "";
                    lbl10.Text = "";
                    break;
                case 8:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "_";
                    lbl6.Text = "_";
                    lbl7.Text = "_";
                    lbl8.Text = "_";
                    lbl9.Text = "";
                    lbl10.Text = "";
                    break;
                case 9:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "_";
                    lbl6.Text = "_";
                    lbl7.Text = "_";
                    lbl8.Text = "_";
                    lbl9.Text = "_"; 
                    lbl10.Text = "";
                    break;
                case 10:
                    lbl1.Text = "_";
                    lbl2.Text = "_";
                    lbl3.Text = "_";
                    lbl4.Text = "_";
                    lbl5.Text = "_";
                    lbl6.Text = "_";
                    lbl7.Text = "_";
                    lbl8.Text = "_";
                    lbl9.Text = "_";
                    lbl10.Text = "_";
                    break;
            }
        }
           
        public void ElegirPalabra(Partida juego)
        {
            int numero;
            Random number = new Random();
            numero = number.Next(1, 12);             
            switch (miJugador.Tema)
            {
                case "Paises":
                    for(int i = 0; i <= juego.Paises.Count; i++)
                    {
                        if(i == numero)
                        {
                            juego.PalabraSecreta = juego.Paises[i];
                            break;
                        }
                    }
                    break;
                case "Animales":
                    for (int i = 0; i <= juego.Animales.Count; i++)
                    {
                        if (i == numero)
                        {
                            juego.PalabraSecreta = juego.Paises[i];
                            break;
                        }
                    }
                    break;
                case "Nombres":
                    for (int i = 0; i <= juego.Nombres.Count; i++)
                    {
                        if (i == numero)
                        {
                            juego.PalabraSecreta = juego.Nombres[i];
                            break;
                        }
                    }
                    break;
                case "Colores":
                    for (int i = 0; i <= juego.Colores.Count; i++)
                    {
                        if (i == numero)
                        {
                            juego.PalabraSecreta = juego.Colores[i];
                            break;
                        }
                    }
                    break;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('a', juego);
            
            if(acierto)
            {
                btnA.Enabled = false;
                btnA.BackColor = Color.Green;                
            }else
            {
                btnA.Enabled = false;
                btnA.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('b', juego);

            if (acierto)
            {
                btnB.Enabled = false;
                btnB.BackColor = Color.Green;                
            }
            else
            {
                btnB.Enabled = false;
                btnB.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('c', juego);

            if (acierto)
            {
                btnC.Enabled = false;
                btnC.BackColor = Color.Green;                
            }
            else
            {
                btnC.Enabled = false;
                btnC.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('d', juego);

            if (acierto)
            {
                btnD.Enabled = false;
                btnD.BackColor = Color.Green;                
            }
            else
            {
                btnD.Enabled = false;
                btnD.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('e', juego);

            if (acierto)
            {
                btnE.Enabled = false;
                btnE.BackColor = Color.Green;                
            }
            else
            {
                btnE.Enabled = false;
                btnE.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('f', juego);

            if (acierto)
            {
                btnF.Enabled = false;
                btnF.BackColor = Color.Green;                
            }
            else
            {
                btnF.Enabled = false;
                btnF.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('g', juego);

            if (acierto)
            {
                btnG.Enabled = false;
                btnG.BackColor = Color.Green;                
            }
            else
            {
                btnG.Enabled = false;
                btnG.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('h', juego);

            if (acierto)
            {
                btnH.Enabled = false;
                btnH.BackColor = Color.Green;                
            }
            else
            {
                btnH.Enabled = false;
                btnH.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('i', juego);

            if (acierto)
            {
                btnI.Enabled = false;
                btnI.BackColor = Color.Green;                
            }
            else
            {
                btnI.Enabled = false;
                btnI.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('j', juego);

            if (acierto)
            {
                btnJ.Enabled = false;
                btnJ.BackColor = Color.Green;               
            }
            else
            {
                btnJ.Enabled = false;
                btnJ.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('k', juego);

            if (acierto)
            {
                btnK.Enabled = false;
                btnK.BackColor = Color.Green;                
            }
            else
            {
                btnK.Enabled = false;
                btnK.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('l', juego);

            if (acierto)
            {
                btnL.Enabled = false;
                btnL.BackColor = Color.Green;                
            }
            else
            {
                btnL.Enabled = false;
                btnL.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('m', juego);

            if (acierto)
            {
                btnM.Enabled = false;
                btnM.BackColor = Color.Green;               
            }
            else
            {
                btnM.Enabled = false;
                btnM.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('n', juego);

            if (acierto)
            {
                btnN.Enabled = false;
                btnN.BackColor = Color.Green;                
            }
            else
            {
                btnN.Enabled = false;
                btnN.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnÑ_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('ñ', juego);

            if (acierto)
            {
                btnÑ.Enabled = false;
                btnÑ.BackColor = Color.Green;                
            }
            else
            {
                btnÑ.Enabled = false;
                btnÑ.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('o', juego);

            if (acierto)
            {
                btnO.Enabled = false;
                btnO.BackColor = Color.Green;                
            }
            else
            {
                btnO.Enabled = false;
                btnO.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('p', juego);

            if (acierto)
            {
                btnP.Enabled = false;
                btnP.BackColor = Color.Green;                
            }
            else
            {
                btnP.Enabled = false;
                btnP.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('q', juego);

            if (acierto)
            {
                btnQ.Enabled = false;
                btnQ.BackColor = Color.Green;                
            }
            else
            {
                btnQ.Enabled = false;
                btnQ.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('r', juego);

            if (acierto)
            {
                btnR.Enabled = false;
                btnR.BackColor = Color.Green;                
            }
            else
            {
                btnR.Enabled = false;
                btnR.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('s', juego);

            if (acierto)
            {
                btnS.Enabled = false;
                btnS.BackColor = Color.Green;               
            }
            else
            {
                btnS.Enabled = false;
                btnS.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('t', juego);

            if (acierto)
            {
                btnT.Enabled = false;
                btnT.BackColor = Color.Green;                
            }
            else
            {
                btnT.Enabled = false;
                btnT.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('u', juego);

            if (acierto)
            {
                btnU.Enabled = false;
                btnU.BackColor = Color.Green;                
            }
            else
            {
                btnU.Enabled = false;
                btnU.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('v', juego);

            if (acierto)
            {
                btnV.Enabled = false;
                btnV.BackColor = Color.Green;                
            }
            else
            {
                btnV.Enabled = false;
                btnV.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('w', juego);

            if (acierto)
            {
                btnW.Enabled = false;
                btnW.BackColor = Color.Green;                
            }
            else
            {
                btnW.Enabled = false;
                btnW.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('x', juego);

            if (acierto)
            {
                btnX.Enabled = false;
                btnX.BackColor = Color.Green;                
            }
            else
            {
                btnX.Enabled = false;
                btnX.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('y', juego);

            if (acierto)
            {
                btnY.Enabled = false;
                btnY.BackColor = Color.Green;               
            }
            else
            {
                btnY.Enabled = false;
                btnY.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            bool acierto;
            acierto = BuscarLetra('z', juego);

            if (acierto)
            {
                btnZ.Enabled = false;
                btnZ.BackColor = Color.Green;                
            }
            else
            {
                btnZ.Enabled = false;
                btnZ.BackColor = Color.Red;
                juego.NumeroVidas--;
            }
            MostrarVidas();
            FinDelJuego();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
