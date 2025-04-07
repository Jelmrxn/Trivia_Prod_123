using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Modelos
{
    public class PreguntaFacil : Pregunta
    {
        public override int EvaluarRespuesta(string respuesta)
        {
            return respuesta == RespuestaCorrecta ? 5 : -2;
        }
    }
}
