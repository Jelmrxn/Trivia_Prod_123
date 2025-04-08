using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TriviaPro
{
    public class JuegoTrivia
    {
        private List<Pregunta> preguntasDisponibles;
        private int totalPreguntas = 15;
        private int preguntasRespondidas;
        private Jugador jugador;
        private Pregunta preguntaActual;
        private string nivelActual;

        public void IniciarJuego(string categoria, string nivel)
        {
            var factory = PreguntaFactory.ObtenerFactory(categoria);
            preguntasDisponibles = factory.CrearPreguntas(nivel);
            preguntasDisponibles = preguntasDisponibles.OrderBy(p => Guid.NewGuid()).Take(totalPreguntas).ToList();
            jugador = new Jugador();
            preguntasRespondidas = 0;
            nivelActual = nivel;
        }

        public Pregunta ObtenerSiguientePregunta() 
        {
            if (preguntasRespondidas >= preguntasDisponibles.Count)
                return null;

            preguntaActual = preguntasDisponibles[preguntasRespondidas];
            return preguntaActual;
        }

        public bool Responder(string respuestaUsuario)
        {
            if (preguntaActual == null)
                return false;

            bool correcta = respuestaUsuario != null && preguntaActual.RespuestaCorrecta.Equals(respuestaUsuario, StringComparison.OrdinalIgnoreCase);

            if (respuestaUsuario == null)
            {
                jugador.Puntaje = Math.Max(0, jugador.Puntaje - 2);
            }
            else if (correcta)
            {
                int puntos = 0;
                switch (preguntaActual.Nivel.ToLower()) 
                {
                    case "fácil": puntos = 5; break;
                    case "medio": puntos = 10; break;
                    case "difícil": puntos = 15; break;
                }
                jugador.AumentarPuntaje(puntos);
            }
            else
            {
                jugador.Puntaje = Math.Max(0, jugador.Puntaje - 2); // puntaje 
            }

            preguntasRespondidas++; // Mover este incremento aquí

            return correcta;
        }

        public int ObtenerPuntaje()
        {
            return jugador.Puntaje;
            
        }

        public string ObtenerNivel()
        {
            return nivelActual;
        }

        public int ObtenerPreguntasRestantes()
        {
            return preguntasDisponibles.Count - preguntasRespondidas;
        }

        public Pregunta ObtenerPreguntaActual()
        {
            return preguntaActual;
        }
    }
}
