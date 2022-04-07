using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    [DataContract]
    public class partida
    {

        [DataMember] List<Nivel> niveles;
        [DataMember] string mapaAnterior;
        [DataMember] Nivel mapaActual;
        [DataMember] Jugador jugador;

        public partida(List<Nivel> niveles, string mapaAnterior, Nivel mapaActual, Jugador jugador)
        {
            this.Niveles = niveles;
            this.MapaAnterior = mapaAnterior;
            this.MapaActual = mapaActual;
            this.Jugador = jugador;
        }

        public List<Nivel> Niveles { get => niveles; set => niveles = value; }
        public string MapaAnterior { get => mapaAnterior; set => mapaAnterior = value; }
        public Nivel MapaActual { get => mapaActual; set => mapaActual = value; }
        public Jugador Jugador { get => jugador; set => jugador = value; }
    }
}
