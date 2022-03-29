using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    internal class Jugador
    {
        String nombre;
        Double vida;
        int atk;
        int dinero;
        Double defensa;

        public Jugador()
        {
        }
        public Jugador(String nombre, Double vida, int atk, int dinero, Double defensa)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.atk = atk;
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
        public int getAtk()
        {
            return this.atk;
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
        public void setAtk(int Atk)
        {
            this.atk = Atk;
        }
        public void setDinero(int dinero)
        {
            this.dinero=dinero;
        }
        public void setDefensa(Double defensa)
        {
            this.defensa = defensa;
        }
        public void recibirAtaque(int atkEnemigo) {
            this.vida = this.vida - atkEnemigo;
        }

        public int generarAtaque()
        {
            //ramdom entre atk y atk - 10
            return atk;
        }
    }


}
