using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    public class Jugador
    {
        String nombre;
        Double vida;
        int ataque;
        int dinero;
        Double defensa;

        public Jugador()
        {
        }

        public Jugador(string nombre, double vida, int ataque, int dinero, double defensa)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Dinero = dinero;
            this.Defensa = defensa;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Vida { get => vida; set => vida = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Dinero { get => dinero; set => dinero = value; }
        public double Defensa { get => defensa; set => defensa = value; }

        public void recibirAtaque(int ataqueEnemigo) {
            this.Vida = this.Vida - ataqueEnemigo;
        }

        public int generarAtaque()
        {
            //ramdom entre ataque y ataque - 10
            Random rnd = new Random();
            int ataquegenerado = rnd.Next(this.Ataque-10, this.Ataque);

            return ataquegenerado;
        }
    }


}
