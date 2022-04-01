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
        public Enemigo(String nombre, Double vida, int ataque, String foto)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.ataque = ataque;
            this.foto = foto;
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public Double getVida()
        {
            return this.vida;
        }
        public int getataque()
        {
            return this.ataque;
        }
        public String getFoto()
        {
            return this.foto;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setVida(Double vida)
        {
            this.vida = vida;
        }
        public void setataque(int ataque)
        {
            this.ataque = ataque;
        }

        public void setFoto(String foto) {

            this.foto = foto;
        }

        public int generarAtaque()
        {
            //ramdom entre ataque y ataque - 10
            Random rnd = new Random();
            int ataquegenerado = rnd.Next(this.ataque - 10, this.ataque);

            return ataquegenerado;
        }
        public void recibirAtaque(int ataqueEnemigo)
        {
            this.vida = this.vida - ataqueEnemigo;
        }



    }
}
