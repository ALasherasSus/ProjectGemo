﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    public class Globales
    {
        public static List<Nivel> niveles; //Listado de niveles generados - GUARDAR
        public static Jugador Jugador; //El objeto jugador - GUARDAR
        public static Double vidaMaximaTope = 650;
        public static int ataqueMaximo = 300;
        public static int defensaMaxima = 5;

        public static Boolean modoDebug; //Si está activado permitirá el movimiento libre por todo el mapa
    }
}
