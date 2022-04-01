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
        public Jugador(String nombre, Double vida, int ataque, int dinero, Double defensa)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.ataque = ataque;
            this.dinero = dinero;
            this.defensa = defensa;
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
        public int getDinero()
        {
            return this.dinero;
        }
        public double getDefensa() {
            return this.defensa;
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
        public void setDinero(int dinero)
        {
            this.dinero=dinero;
        }
        public void setDefensa(Double defensa)
        {
            this.defensa = defensa;
        }
        public void recibirAtaque(int ataqueEnemigo) {
            this.vida = this.vida - ataqueEnemigo;
        }

        public int generarAtaque()
        {
            //ramdom entre ataque y ataque - 10
            Random rnd = new Random();
            int ataquegenerado = rnd.Next(this.ataque-10, this.ataque);

            return ataquegenerado;
        }
    }


}
