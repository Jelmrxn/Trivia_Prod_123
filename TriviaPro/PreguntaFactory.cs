using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public static class PreguntaFactory
    {
        public static IPreguntaFactory ObtenerFactory(string categoria)
        {
            switch (categoria)
            {
                case "Ciencia":
                    return new CienciaFactory();
                case "Historia":
                    return new HistoriaFactory();
                case "Cultura General":
                    return new CulturaGeneralFactory(); 

                // Puedes añadir Historia, Cultura General más adelante 
                default:
                    throw new ArgumentException("Categoría no válida");// 
            }
        }
    }
}
