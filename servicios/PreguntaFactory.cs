using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaPro.Modelos;

namespace TriviaPro.servicios
{
    public static class PreguntaFactory
    {
        public static Pregunta CrearPregunta(string categoria, string nivel, string texto, List<string> opciones, string respuestaCorrecta)
        {
            Pregunta pregunta;

            if (nivel == "Fácil")
            {
                pregunta = new PreguntaFacil();
            }
            else if (nivel == "Medio")
            {
                pregunta = new PreguntaMedia();
            }
            else if (nivel == "Difícil")
            {
                pregunta = new PreguntaDificil();
            }
            else
            {
                throw new ArgumentException("Nivel no válido");
            }

            pregunta.Categoria = categoria;
            pregunta.Nivel = nivel;
            pregunta.Texto = texto;
            pregunta.Opciones = opciones;
            pregunta.RespuestaCorrecta = respuestaCorrecta;

            return pregunta;
        }
    }
}