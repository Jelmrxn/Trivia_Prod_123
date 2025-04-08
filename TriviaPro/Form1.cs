using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TriviaPro
{
    public partial class Form1 : Form
    {

        private JuegoTrivia juego;
        private System.Windows.Forms.Timer temporizador;
        private int tiempoRestante;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string nivel = cmbNivel.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(nivel))
            {
                MessageBox.Show("Debe seleccionar una categoría y un nivel de dificultad.");
                return;
            }

            juego = new JuegoTrivia();
            juego.IniciarJuego(categoria, nivel);

            lstHistorial.Items.Clear();
            lblPuntaje.Text = "0";
            lblPreguntasRestantes.Text = "15";

            MostrarSiguientePregunta();
        }

        private void MostrarSiguientePregunta()
        {
            Pregunta p = juego.ObtenerSiguientePregunta();

            lblPregunta.Text = p.Enunciado;
            rbtnOpcion1.Text = p.Opciones[0];
            rbtnOpcion2.Text = p.Opciones[1];
            rbtnOpcion3.Text = p.Opciones[2];

            rbtnOpcion1.Checked = false;
            rbtnOpcion2.Checked = false;
            rbtnOpcion3.Checked = false;

            lblPreguntasRestantes.Text = $"Faltan: {juego.ObtenerPreguntasRestantes()}";
            lblPuntaje.Text = $"Puntaje: {juego.ObtenerPuntaje()}";

            IniciarTemporizador(juego.ObtenerNivel());
            btnResponder.Enabled = true;
        }

        private void IniciarTemporizador(string nivel)
        {
            if (temporizador != null)
            {
                temporizador.Stop();
                temporizador.Dispose();
            }

            switch (nivel.ToLower())
            {
                case "fácil": tiempoRestante = 20; break;
                case "medio": tiempoRestante = 15; break;
                case "difícil": tiempoRestante = 10; break;
                default: tiempoRestante = 15; break;
            }

            lblTiempoRestante.Text = $"{tiempoRestante}";
            progressTiempo.Maximum = tiempoRestante;
            progressTiempo.Value = tiempoRestante;

            temporizador = new System.Windows.Forms.Timer();
            temporizador.Interval = 1000;
            temporizador.Tick += (s, e) =>
            {
                tiempoRestante--;
                lblTiempoRestante.Text = $"{tiempoRestante}";
                progressTiempo.Value = Math.Max(0, tiempoRestante);

                if (tiempoRestante <= 0)
                {
                    temporizador.Stop();
                    MarcarRespuesta(null); // No respondió a tiempo
                }
            };
            temporizador.Start();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string seleccion = null;
            if (rbtnOpcion1.Checked) seleccion = rbtnOpcion1.Text;
            else if (rbtnOpcion2.Checked) seleccion = rbtnOpcion2.Text;
            else if (rbtnOpcion3.Checked) seleccion = rbtnOpcion3.Text;

            MarcarRespuesta(seleccion);
        }

        private void MarcarRespuesta(string seleccion)
        {
            temporizador?.Stop();

            bool esCorrecta = juego.Responder(seleccion);

            string resultado = seleccion == null ? "No respondió a tiempo" : esCorrecta ? "Correcta" : "Incorrecta";
            lstHistorial.Items.Add($"{juego.ObtenerPreguntaActual().Enunciado} - {resultado}");

            lblPuntaje.Text = $"Puntaje: {juego.ObtenerPuntaje()}";

            if (juego.ObtenerPreguntasRestantes() == 0)
            {
                MessageBox.Show($"¡Juego terminado! Puntaje final: {juego.ObtenerPuntaje()}");
                btnResponder.Enabled = false;
                lblPregunta.Text = "Juego finalizado.";
                return;
            }

            MostrarSiguientePregunta();// h
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Ciencia");
            cmbCategoria.Items.Add("Historia");
            cmbCategoria.Items.Add("Cultura General");

            cmbNivel.Items.Clear();
            cmbNivel.Items.Add("Fácil");
            cmbNivel.Items.Add("Medio");
            cmbNivel.Items.Add("Difícil");

            cmbCategoria.SelectedIndex = 0;
            cmbNivel.SelectedIndex = 0;

            lblPuntaje.Text = "Puntaje: 0";
            lblPreguntasRestantes.Text = "Faltan: 15";
            lblPregunta.Text = "Presiona 'Nueva Partida' para comenzar";
            lblTiempoRestante.Text = "0";

            progressTiempo.Value = 0;
        }

        private void btnNuevaPartida_Click_1(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string nivel = cmbNivel.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(nivel))
            {
                MessageBox.Show("Debe seleccionar una categoría y un nivel de dificultad.");
                return;
            }

            juego = new JuegoTrivia();
            juego.IniciarJuego(categoria, nivel);

            lstHistorial.Items.Clear();
            lblPuntaje.Text = "0";
            lblPreguntasRestantes.Text = "15";

            MostrarSiguientePregunta();
        }

        private void btnResponder_Click_1(object sender, EventArgs e)
        {
            string seleccion = null;
            if (rbtnOpcion1.Checked) seleccion = rbtnOpcion1.Text;
            else if (rbtnOpcion2.Checked) seleccion = rbtnOpcion2.Text;
            else if (rbtnOpcion3.Checked) seleccion = rbtnOpcion3.Text;

            MarcarRespuesta(seleccion);
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
