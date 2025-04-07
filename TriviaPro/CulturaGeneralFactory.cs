using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class CulturaGeneralFactory : IPreguntaFactory
    {
        public List<Pregunta> CrearPreguntas(string nivel)
        {
            var preguntas = new List<Pregunta>();

            if (nivel == "Fácil")
            {
                preguntas.Add(new Pregunta("¿De qué color es el sol?", new List<string> { "Rojo", "Amarillo", "Azul" }, "Amarillo", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuántos días tiene un año normal?", new List<string> { "364", "365", "366" }, "365", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es la capital de Francia?", new List<string> { "París", "Madrid", "Roma" }, "París", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué gas respiramos principalmente?", new List<string> { "Oxígeno", "Dióxido de carbono", "Hidrógeno" }, "Oxígeno", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué instrumento tiene teclas blancas y negras?", new List<string> { "Violín", "Piano", "Guitarra" }, "Piano", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es el océano más grande?", new List<string> { "Atlántico", "Índico", "Pacífico" }, "Pacífico", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuántos continentes hay?", new List<string> { "5", "6", "7" }, "7", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué día sigue al viernes?", new List<string> { "Sábado", "Domingo", "Lunes" }, "Sábado", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué deporte se juega con un bate?", new List<string> { "Béisbol", "Fútbol", "Voleibol" }, "Béisbol", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿De qué país es originario el sushi?", new List<string> { "China", "Japón", "Corea" }, "Japón", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué bebida se obtiene del grano tostado?", new List<string> { "Té", "Café", "Cacao" }, "Café", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es el animal terrestre más rápido?", new List<string> { "Leopardo", "Tigre", "Guepardo" }, "Guepardo", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué número representa el valor de PI redondeado?", new List<string> { "3.14", "2.71", "1.62" }, "3.14", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es el metal más usado en la industria?", new List<string> { "Hierro", "Cobre", "Oro" }, "Hierro", "Fácil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué color resulta de mezclar azul y amarillo?", new List<string> { "Verde", "Naranja", "Violeta" }, "Verde", "Fácil", "Cultura General"));
            }
            else if (nivel == "Medio")
            {
                preguntas.Add(new Pregunta("¿Cuál es la capital de Australia?", new List<string> { "Sídney", "Canberra", "Melbourne" }, "Canberra", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué instrumento mide los terremotos?", new List<string> { "Barómetro", "Sismógrafo", "Anemómetro" }, "Sismógrafo", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Quién escribió 'Don Quijote'?", new List<string> { "Cervantes", "Shakespeare", "Lope de Vega" }, "Cervantes", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué órgano produce la insulina?", new List<string> { "Páncreas", "Hígado", "Riñón" }, "Páncreas", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué país tiene forma de bota?", new List<string> { "España", "Italia", "Grecia" }, "Italia", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es el río más largo del mundo?", new List<string> { "Nilo", "Amazonas", "Yangtsé" }, "Amazonas", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué científico formuló la ley de la gravedad?", new List<string> { "Einstein", "Newton", "Galileo" }, "Newton", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Quién pintó la Mona Lisa?", new List<string> { "Van Gogh", "Picasso", "Da Vinci" }, "Da Vinci", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es el idioma más hablado del mundo?", new List<string> { "Inglés", "Chino mandarín", "Español" }, "Chino mandarín", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuántos elementos hay en la tabla periódica?", new List<string> { "118", "108", "98" }, "118", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué país inventó la pólvora?", new List<string> { "India", "China", "Egipto" }, "China", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué año cayó el muro de Berlín?", new List<string> { "1987", "1989", "1991" }, "1989", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Quién fue el primer hombre en el espacio?", new List<string> { "Neil Armstrong", "Yuri Gagarin", "Buzz Aldrin" }, "Yuri Gagarin", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué símbolo químico representa al oro?", new List<string> { "Ag", "Au", "Pt" }, "Au", "Medio", "Cultura General"));
                preguntas.Add(new Pregunta("¿En qué continente está Egipto?", new List<string> { "Asia", "África", "Europa" }, "África", "Medio", "Cultura General"));
            }
            else if (nivel == "Difícil")
            {
                preguntas.Add(new Pregunta("¿Cuál es el metal más caro del mundo?", new List<string> { "Oro", "Rodio", "Platino" }, "Rodio", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es la capital de Mongolia?", new List<string> { "Ulán Bator", "Astana", "Hanoi" }, "Ulán Bator", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿En qué año nació Albert Einstein?", new List<string> { "1879", "1889", "1869" }, "1879", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Quién escribió 'La divina comedia'?", new List<string> { "Dante", "Homero", "Virgilio" }, "Dante", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué país tiene más islas en el mundo?", new List<string> { "Filipinas", "Suecia", "Indonesia" }, "Suecia", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué filósofo dijo 'Solo sé que nada sé'?", new List<string> { "Platón", "Sócrates", "Descartes" }, "Sócrates", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué civilización usó jeroglíficos?", new List<string> { "Mesopotámica", "Egipcia", "Romana" }, "Egipcia", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Quién descubrió la penicilina?", new List<string> { "Pasteur", "Fleming", "Curie" }, "Fleming", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿En qué país nació Nikola Tesla?", new List<string> { "Croacia", "Serbia", "Eslovenia" }, "Croacia", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué año se fundó Roma?", new List<string> { "753 a.C.", "509 a.C.", "476 d.C." }, "753 a.C.", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué país tiene más volcanes activos?", new List<string> { "Indonesia", "Japón", "Chile" }, "Indonesia", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué científico propuso el principio de incertidumbre?", new List<string> { "Heisenberg", "Bohr", "Fermi" }, "Heisenberg", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Cuál es la isla más grande del mundo?", new List<string> { "Groenlandia", "Australia", "Nueva Guinea" }, "Groenlandia", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué emperador romano legalizó el cristianismo?", new List<string> { "Nerón", "Constantino", "Julio César" }, "Constantino", "Difícil", "Cultura General"));
                preguntas.Add(new Pregunta("¿Qué reina inglesa tuvo el reinado más largo antes de Isabel II?", new List<string> { "Victoria", "Ana", "Isabel I" }, "Victoria", "Difícil", "Cultura General"));
            }

            return preguntas;
        }
    }
}
