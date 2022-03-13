using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaDeJugadores
{
    public class Lista
    {
        public List<Jugador> Jugadores { set; get; }

        public Lista()
        {
            Jugadores = new List<Jugador>();
        }
        public void Agregar(Jugador Jugador)
        {
            Jugadores.Add(Jugador);
        }
    }
}
