using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    [DataContract]
    public class Jugador
    {
        [DataMember] Double vida;
        [DataMember] Double vidaMaxima;
        [DataMember] int ataque;
        [DataMember] int dinero;
        [DataMember] int defensa;
        [DataMember] int huidas;

        public Jugador()
        {
        }

        public Jugador(double vida, double vidaMaxima, int ataque, int dinero, int defensa)
        {
            this.Vida = vida;
            this.VidaMaxima = vidaMaxima;
            this.Ataque = ataque;
            this.Dinero = dinero;
            this.Defensa = defensa;
            this.Huidas = 0;
        }

        public double Vida { get => vida; set => vida = value; }
        public double VidaMaxima { get => vidaMaxima; set => vidaMaxima = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Dinero { get => dinero; set => dinero = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Huidas { get => huidas; set => huidas = value; }

        public void recibirAtaque(double ataqueEnemigo)
        {
            this.Vida = ((this.Vida * 10) - (ataqueEnemigo * (10 - defensa))) / 10;
        }

        public int generarAtaque()
        {
            //ramdom entre ataque y ataque - 10
            Random rnd = new Random();
            int ataquegenerado = rnd.Next(this.Ataque - 10, this.Ataque);

            return ataquegenerado;
        }
    }


}
