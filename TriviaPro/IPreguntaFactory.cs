using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public interface IPreguntaFactory
    {
        List<Pregunta> CrearPreguntas(string nivel);
    }
}
