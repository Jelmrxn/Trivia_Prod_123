using System.Collections.Generic;

namespace TriviaPro.Modelos
{
    // Clase base abstracta
    public abstract class Pregunta
    {
        public string Texto { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string Categoria { get; set; }
        public string Nivel { get; set; }

        // Método abstracto que se implementará en clases hijas
        public abstract int EvaluarRespuesta(string respuesta);
    }
}
