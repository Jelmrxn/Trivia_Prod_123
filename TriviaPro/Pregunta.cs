using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class Pregunta
    {

        //Esta clase representa una pregunta con su enunciado, opciones, respuesta correcta, etc.

        public string Enunciado { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string Nivel { get; set; }
        public string Categoria { get; set; }

        public Pregunta(string enunciado, List<string> opciones, string respuestaCorrecta, string nivel, string categoria)
        {
            Enunciado = enunciado;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            Nivel = nivel;
            Categoria = categoria;
        }

        public bool ValidarRespuesta(string respuestaSeleccionada)
        {
            return respuestaSeleccionada == RespuestaCorrecta;
        }
    }
}
