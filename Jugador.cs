using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaDeJugadores
{
    public class Jugador
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Posicion { set; get; }
        public long Precio { set; get; }
        public int Edad { set; get; }

        public Jugador()
        {
        }

        public Jugador(string nombre, string apellidos, string posicion, long precio,int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Posicion = posicion;
            Precio = precio;
            Edad = edad;
        }
    }
}
