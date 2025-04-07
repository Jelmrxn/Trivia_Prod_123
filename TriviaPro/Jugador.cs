using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Puntaje { get; set; }

        public Jugador() // ← Este constructor resuelve tu problema
        {
            Nombre = "Invitado";
            Puntaje = 0;
        }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Puntaje = 0;
        }

        public void AumentarPuntaje(int puntos)
        {
            Puntaje += puntos;
        }
    }
}
