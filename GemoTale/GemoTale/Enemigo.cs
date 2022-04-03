using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    public class Enemigo
    {

        String nombre;
        Double vida;
        int ataque;
        String foto;

        public Enemigo()
        {
        }

        public Enemigo(string nombre, double vida, int ataque, string foto)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Foto = foto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Vida { get => vida; set => vida = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public string Foto { get => foto; set => foto = value; }

        public int generarAtaque()
        {
            //ramdom entre ataque y ataque - 10
            Random rnd = new Random();
            int ataquegenerado = rnd.Next(this.Ataque - 10, this.Ataque);

            return ataquegenerado;
        }
        public void recibirAtaque(int ataqueEnemigo)
        {
            this.Vida = this.Vida - ataqueEnemigo;
        }



    }
}
