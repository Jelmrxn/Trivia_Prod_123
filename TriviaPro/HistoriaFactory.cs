using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class HistoriaFactory : IPreguntaFactory
    {
        public List<Pregunta> CrearPreguntas(string nivel)
        {
            var preguntas = new List<Pregunta>();

            if (nivel == "Fácil")
            {
                preguntas.Add(new Pregunta("¿En qué año se descubrió América?", new List<string> { "1492", "1500", "1453" }, "1492", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién fue el primer presidente de Estados Unidos?", new List<string> { "Abraham Lincoln", "George Washington", "Thomas Jefferson" }, "George Washington", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué imperio construyó las pirámides?", new List<string> { "Romano", "Egipcio", "Maya" }, "Egipcio", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué civilización vivió en Machu Picchu?", new List<string> { "Azteca", "Inca", "Maya" }, "Inca", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué guerra terminó en 1945?", new List<string> { "Primera Guerra Mundial", "Segunda Guerra Mundial", "Guerra Fría" }, "Segunda Guerra Mundial", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué país colonizó India?", new List<string> { "Francia", "Portugal", "Reino Unido" }, "Reino Unido", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿En qué continente ocurrió el Renacimiento?", new List<string> { "Asia", "América", "Europa" }, "Europa", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién fue Cristóbal Colón?", new List<string> { "Un pintor", "Un explorador", "Un rey" }, "Un explorador", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Dónde se encuentra la Gran Muralla?", new List<string> { "Japón", "China", "Corea" }, "China", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué imperio fundó Roma?", new List<string> { "Griego", "Romano", "Persa" }, "Romano", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Cuál es la ciudad más antigua del mundo?", new List<string> { "Damasco", "Roma", "Atenas" }, "Damasco", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién pintó la Última Cena?", new List<string> { "Miguel Ángel", "Leonardo da Vinci", "Rafael" }, "Leonardo da Vinci", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿En qué país nació Napoleón?", new List<string> { "España", "Francia", "Italia" }, "Francia", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué faraón construyó la Gran Pirámide?", new List<string> { "Tutankamón", "Keops", "Ramsés" }, "Keops", "Fácil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué ciudad fue destruida por el Vesubio?", new List<string> { "Atenas", "Pompeya", "Cartago" }, "Pompeya", "Fácil", "Historia"));
            }
            else if (nivel == "Medio")
            {
                preguntas.Add(new Pregunta("¿En qué año comenzó la Segunda Guerra Mundial?", new List<string> { "1935", "1939", "1941" }, "1939", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué civilización construyó Machu Picchu?", new List<string> { "Azteca", "Maya", "Inca" }, "Inca", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Quién escribió 'El Príncipe'?", new List<string> { "Maquiavelo", "Hobbes", "Platón" }, "Maquiavelo", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué emperador dividió el Imperio Romano?", new List<string> { "Constantino", "Teodosio", "Diocleciano" }, "Diocleciano", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Quién fue el último emperador de Rusia?", new List<string> { "Pedro el Grande", "Nicolás II", "Iván el Terrible" }, "Nicolás II", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Dónde se firmó el Tratado de Versalles?", new List<string> { "Londres", "Versalles", "París" }, "Versalles", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué dinastía gobernó China por más tiempo?", new List<string> { "Ming", "Han", "Zhou" }, "Zhou", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué país lanzó la primera bomba atómica?", new List<string> { "Alemania", "Japón", "EE. UU." }, "EE. UU.", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué líder fue asesinado en Dallas en 1963?", new List<string> { "Martin Luther King", "John F. Kennedy", "Ronald Reagan" }, "John F. Kennedy", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué cultura inventó el calendario de 365 días?", new List<string> { "Griega", "Egipcia", "Maya" }, "Egipcia", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿En qué siglo ocurrió la Revolución Francesa?", new List<string> { "XVIII", "XIX", "XVII" }, "XVIII", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Cuál fue la primera civilización conocida?", new List<string> { "Egipcia", "Mesopotámica", "Griega" }, "Mesopotámica", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Qué guerra enfrentó a los Aliados y las Potencias Centrales?", new List<string> { "Guerra Civil", "Primera Guerra Mundial", "Segunda Guerra Mundial" }, "Primera Guerra Mundial", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Quién fue el líder de Alemania Nazi?", new List<string> { "Stalin", "Mussolini", "Hitler" }, "Hitler", "Medio", "Historia"));
                preguntas.Add(new Pregunta("¿Dónde se construyó el Muro de Berlín?", new List<string> { "Alemania Occidental", "Alemania Oriental", "Berlín" }, "Berlín", "Medio", "Historia"));
            }
            else if (nivel == "Difícil")
            {
                preguntas.Add(new Pregunta("¿Cuál fue el tratado que terminó la Primera Guerra Mundial?", new List<string> { "Tratado de París", "Tratado de Versalles", "Tratado de Tordesillas" }, "Tratado de Versalles", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué imperio fue gobernado por Justiniano I?", new List<string> { "Imperio Bizantino", "Imperio Otomano", "Imperio Romano Occidental" }, "Imperio Bizantino", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué batalla marcó el fin de Napoleón?", new List<string> { "Austerlitz", "Trafalgar", "Waterloo" }, "Waterloo", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién escribió la obra 'Guerra y Paz'?", new List<string> { "Tolstoi", "Dostoievski", "Chejov" }, "Tolstoi", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué papa convocó la primera cruzada?", new List<string> { "Urbano II", "Inocencio III", "Gregorio VII" }, "Urbano II", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué país tuvo una guerra civil entre republicanos y nacionalistas?", new List<string> { "Francia", "Italia", "España" }, "España", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién fue el último emperador azteca?", new List<string> { "Moctezuma", "Cuitláhuac", "Cuauhtémoc" }, "Cuauhtémoc", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué líder africano luchó contra el apartheid?", new List<string> { "Mandela", "Lumumba", "Nkrumah" }, "Mandela", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿En qué año cayó Constantinopla?", new List<string> { "1453", "1492", "1517" }, "1453", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué tratado estableció las esferas de influencia en América?", new List<string> { "Tordesillas", "Versalles", "París" }, "Tordesillas", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué presidente renunció por el escándalo Watergate?", new List<string> { "Nixon", "Ford", "Carter" }, "Nixon", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién fue Ramsés II?", new List<string> { "Faraón egipcio", "Rey romano", "Emperador persa" }, "Faraón egipcio", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Dónde nació Alejandro Magno?", new List<string> { "Atenas", "Esparta", "Macedonia" }, "Macedonia", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Qué cultura inventó la escritura cuneiforme?", new List<string> { "Egipcia", "China", "Sumeria" }, "Sumeria", "Difícil", "Historia"));
                preguntas.Add(new Pregunta("¿Quién unificó Alemania en el siglo XIX?", new List<string> { "Bismarck", "Guillermo II", "Lutero" }, "Bismarck", "Difícil", "Historia"));
            }

            return preguntas;
        }
    }
}
