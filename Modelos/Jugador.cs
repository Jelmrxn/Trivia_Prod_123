using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Modelos
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Puntaje { get; private set; }

        public void ActualizarPuntaje(int puntos)
        {
            Puntaje = Math.Max(0, Puntaje + puntos);
        }
    }
}
