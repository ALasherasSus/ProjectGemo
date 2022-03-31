using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    internal class Enemigo
    {

        String nombre;
        Double vida;
        int atk;
        String foto;

        public Enemigo()
        {
        }
        public Enemigo(String nombre, Double vida, int atk, String foto)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.atk = atk;
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
        public int getAtk()
        {
            return this.atk;
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
        public void setAtk(int Atk)
        {
            this.atk = Atk;
        }

        public void setFoto(String foto) {

            this.foto = foto;
        }

        public int generarAtaque()
        {
            //ramdom entre atk y atk - 10
            Random rnd = new Random();
            int atkgenerado = rnd.Next(this.atk - 10, this.atk);

            return atkgenerado;
        }
        public void recibirAtaque(int atkEnemigo)
        {
            this.vida = this.vida - atkEnemigo;
        }



    }
}
