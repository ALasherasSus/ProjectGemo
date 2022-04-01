using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    public class Nivel
    {
        String nombre;
        String imagenFondo;
        Boolean flechaArriba;
        Boolean flechaAbajo;
        Boolean flechaIzquierda;
        Boolean flechaDerecha;
        Boolean tiendaIzquierda;
        Boolean tiendaDerecha;
        String direccionArriba;
        String direccionAbajo;
        String direccionIzquierda;
        String direccionDerecha;
        Boolean enemigoAcechante;
        Enemigo enemigo;

        public Nivel()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ImagenFondo { get => imagenFondo; set => imagenFondo = value; }
        public bool FlechaArriba { get => flechaArriba; set => flechaArriba = value; }
        public bool FlechaAbajo { get => flechaAbajo; set => flechaAbajo = value; }
        public bool FlechaIzquierda { get => flechaIzquierda; set => flechaIzquierda = value; }
        public bool FlechaDerecha { get => flechaDerecha; set => flechaDerecha = value; }
        public bool TiendaIzquierda { get => tiendaIzquierda; set => tiendaIzquierda = value; }
        public bool TiendaDerecha { get => tiendaDerecha; set => tiendaDerecha = value; }
        public string DireccionArriba { get => direccionArriba; set => direccionArriba = value; }
        public string DireccionAbajo { get => direccionAbajo; set => direccionAbajo = value; }
        public string DireccionIzquierda { get => direccionIzquierda; set => direccionIzquierda = value; }
        public string DireccionDerecha { get => direccionDerecha; set => direccionDerecha = value; }
        public bool EnemigoAcechante { get => enemigoAcechante; set => enemigoAcechante = value; }
        internal Enemigo Enemigo { get => enemigo; set => enemigo = value; }
    }
}
