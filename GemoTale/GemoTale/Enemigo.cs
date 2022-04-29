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
        String sonidoIntro;
        String sonidoDerrota = "../../Sounds/SFX/crash_victory.wav";

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

        public Enemigo(string nombre, double vida, int ataque, string foto, string sonidoIntro, string sonidoDerrota)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Foto = foto;
            this.SonidoIntro = sonidoIntro;
            this.SonidoDerrota = sonidoDerrota;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Vida { get => vida; set => vida = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public string Foto { get => foto; set => foto = value; }
        public string SonidoIntro { get => sonidoIntro; set => sonidoIntro = value; }
        public string SonidoDerrota { get => sonidoDerrota; set => sonidoDerrota = value; }

        public int generarAtaque()
        {
            //ramdom entre 10 y ataque del enemigo
            Random rnd = new Random();
            int ataquegenerado = rnd.Next(10, this.Ataque);

            return ataquegenerado;
        }
        public void recibirAtaque(int ataqueEnemigo)
        {
            this.Vida = this.Vida - ataqueEnemigo;
        }

    }
}
