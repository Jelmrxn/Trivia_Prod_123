using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class CienciaFactory : IPreguntaFactory
    {
        public List<Pregunta> CrearPreguntas(string nivel)
        {
            var preguntas = new List<Pregunta>();

            if (nivel == "Fácil")
            {
                preguntas.Add(new Pregunta("¿Cuál es el planeta más cercano al sol?", new List<string> { "Mercurio", "Venus", "Tierra" }, "Mercurio", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuántos planetas hay en el sistema solar?", new List<string> { "7", "8", "9" }, "8", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué gas respiramos para vivir?", new List<string> { "Oxígeno", "Nitrógeno", "Dióxido de carbono" }, "Oxígeno", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es el estado del agua a temperatura ambiente?", new List<string> { "Sólido", "Líquido", "Gaseoso" }, "Líquido", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué órgano se encarga de bombear sangre?", new List<string> { "Cerebro", "Pulmón", "Corazón" }, "Corazón", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué astro ilumina la Tierra?", new List<string> { "La Luna", "El Sol", "Marte" }, "El Sol", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué parte del cuerpo usamos para ver?", new List<string> { "Oídos", "Nariz", "Ojos" }, "Ojos", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es el animal más grande del mundo?", new List<string> { "Elefante", "Ballena azul", "Rinoceronte" }, "Ballena azul", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué necesitamos para respirar?", new List<string> { "Luz", "Comida", "Aire" }, "Aire", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es el sentido que usamos para oír?", new List<string> { "Oído", "Vista", "Tacto" }, "Oído", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cómo se llama el satélite natural de la Tierra?", new List<string> { "Luna", "Marte", "Sol" }, "Luna", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué líquido necesitamos para vivir?", new List<string> { "Agua", "Aceite", "Alcohol" }, "Agua", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué planeta es conocido como el planeta rojo?", new List<string> { "Venus", "Marte", "Júpiter" }, "Marte", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué usamos para medir la temperatura?", new List<string> { "Barómetro", "Termómetro", "Higrómetro" }, "Termómetro", "Fácil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué animal pone huevos?", new List<string> { "Perro", "Gallina", "Vaca" }, "Gallina", "Fácil", "Ciencia"));
            }
            else if (nivel == "Medio")
            {
                preguntas.Add(new Pregunta("¿Qué tipo de energía produce el Sol?", new List<string> { "Nuclear", "Solar", "Eólica" }, "Solar", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es el principal gas del aire?", new List<string> { "Oxígeno", "Dióxido de carbono", "Nitrógeno" }, "Nitrógeno", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué célula transporta oxígeno en la sangre?", new List<string> { "Glóbulos blancos", "Plaquetas", "Glóbulos rojos" }, "Glóbulos rojos", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué científico desarrolló la teoría de la relatividad?", new List<string> { "Newton", "Einstein", "Galileo" }, "Einstein", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué fuerza nos mantiene en el suelo?", new List<string> { "Magnetismo", "Gravedad", "Fricción" }, "Gravedad", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué órgano filtra la sangre?", new List<string> { "Pulmones", "Riñones", "Hígado" }, "Riñones", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué parte de la célula contiene el ADN?", new List<string> { "Citoplasma", "Mitocondria", "Núcleo" }, "Núcleo", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué planeta tiene un gran anillo?", new List<string> { "Saturno", "Marte", "Venus" }, "Saturno", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué sustancia da el color verde a las plantas?", new List<string> { "Clorofila", "Hemoglobina", "Glucosa" }, "Clorofila", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué órgano controla el cuerpo humano?", new List<string> { "Corazón", "Estómago", "Cerebro" }, "Cerebro", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué estado de la materia tiene forma y volumen propios?", new List<string> { "Gas", "Líquido", "Sólido" }, "Sólido", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué animal puede regenerar partes de su cuerpo?", new List<string> { "Perro", "Estrella de mar", "Gato" }, "Estrella de mar", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cómo se llama el proceso por el cual las plantas producen su alimento?", new List<string> { "Fotosíntesis", "Respiración", "Germinación" }, "Fotosíntesis", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué mineral es necesario para los huesos?", new List<string> { "Hierro", "Calcio", "Zinc" }, "Calcio", "Medio", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es la unidad para medir la fuerza?", new List<string> { "Newton", "Pascal", "Joule" }, "Newton", "Medio", "Ciencia"));
            }
            else if (nivel == "Difícil")
            {
                preguntas.Add(new Pregunta("¿Cuál es el símbolo químico del oro?", new List<string> { "Au", "Ag", "Fe" }, "Au", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué científico formuló las leyes del movimiento?", new List<string> { "Einstein", "Newton", "Tesla" }, "Newton", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué parte del cuerpo produce insulina?", new List<string> { "Riñón", "Hígado", "Páncreas" }, "Páncreas", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué planeta es el más grande del sistema solar?", new List<string> { "Saturno", "Júpiter", "Neptuno" }, "Júpiter", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es la fórmula química del agua?", new List<string> { "H2O", "CO2", "NaCl" }, "H2O", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué es un electrón?", new List<string> { "Una partícula positiva", "Una partícula sin carga", "Una partícula negativa" }, "Una partícula negativa", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué capa de la Tierra está justo debajo de la corteza?", new List<string> { "Núcleo", "Manto", "Astenosfera" }, "Manto", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué tipo de célula no tiene núcleo?", new List<string> { "Eucariota", "Procariota", "Animal" }, "Procariota", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué científico es famoso por sus experimentos con guisantes?", new List<string> { "Darwin", "Mendel", "Lamarck" }, "Mendel", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es la velocidad de la luz en el vacío?", new List<string> { "300,000 km/s", "150,000 km/s", "1,000,000 km/s" }, "300,000 km/s", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué ácido se encuentra en el estómago humano?", new List<string> { "Ácido sulfúrico", "Ácido acético", "Ácido clorhídrico" }, "Ácido clorhídrico", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué es el bosón de Higgs?", new List<string> { "Una partícula subatómica", "Una célula", "Una proteína" }, "Una partícula subatómica", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué nombre recibe la ciencia que estudia los fósiles?", new List<string> { "Biología", "Paleontología", "Geología" }, "Paleontología", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Qué planeta tiene un día más largo que su año?", new List<string> { "Venus", "Júpiter", "Mercurio" }, "Venus", "Difícil", "Ciencia"));
                preguntas.Add(new Pregunta("¿Cuál es el número atómico del oxígeno?", new List<string> { "8", "16", "2" }, "8", "Difícil", "Ciencia"));
            }

            return preguntas;
        }
    }
}