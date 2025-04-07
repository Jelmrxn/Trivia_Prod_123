namespace TriviaPro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblJugador = new System.Windows.Forms.Label();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.progressBarTiempo = new System.Windows.Forms.ProgressBar();
            this.timerPregunta = new System.Windows.Forms.Timer(this.components);
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblRestantes = new System.Windows.Forms.Label();
            this.lstPreguntas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(63, 37);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(102, 13);
            this.lblJugador.TabIndex = 0;
            this.lblJugador.Text = "Nombre del jugador:";
            // 
            // txtJugador
            // 
            this.txtJugador.Location = new System.Drawing.Point(172, 37);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(100, 20);
            this.txtJugador.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "culturas ",
            "ciencias "});
            this.cbCategoria.Location = new System.Drawing.Point(306, 37);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.Text = "selecciona";
            // 
            // cbDificultad
            // 
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Items.AddRange(new object[] {
            "Fácil",
            "Medio",
            "Difícil"});
            this.cbDificultad.Location = new System.Drawing.Point(466, 37);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(121, 21);
            this.cbDificultad.TabIndex = 3;
            this.cbDificultad.Text = "Dificultad";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(611, 37);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Juego";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(64, 90);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(148, 13);
            this.lblPregunta.TabIndex = 5;
            this.lblPregunta.Text = "¿cual es la capital de francia?";
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Location = new System.Drawing.Point(66, 123);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(48, 17);
            this.rbOpcion1.TabIndex = 6;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "Paris";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Location = new System.Drawing.Point(66, 146);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(57, 17);
            this.rbOpcion2.TabIndex = 7;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "Madrid";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Location = new System.Drawing.Point(66, 169);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(63, 17);
            this.rbOpcion3.TabIndex = 8;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "Londres";
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbOpcion4
            // 
            this.rbOpcion4.AutoSize = true;
            this.rbOpcion4.Location = new System.Drawing.Point(67, 192);
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.Size = new System.Drawing.Size(51, 17);
            this.rbOpcion4.TabIndex = 9;
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.Text = "Berlin";
            this.rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(76, 224);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 10;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            // 
            // progressBarTiempo
            // 
            this.progressBarTiempo.Location = new System.Drawing.Point(51, 274);
            this.progressBarTiempo.Name = "progressBarTiempo";
            this.progressBarTiempo.Size = new System.Drawing.Size(100, 23);
            this.progressBarTiempo.TabIndex = 11;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(551, 123);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(51, 13);
            this.lblPuntaje.TabIndex = 12;
            this.lblPuntaje.Text = "puntaje:0";
            this.lblPuntaje.Click += new System.EventHandler(this.lblPuntaje_Click);
            // 
            // lblRestantes
            // 
            this.lblRestantes.AutoSize = true;
            this.lblRestantes.Location = new System.Drawing.Point(551, 146);
            this.lblRestantes.Name = "lblRestantes";
            this.lblRestantes.Size = new System.Drawing.Size(100, 13);
            this.lblRestantes.TabIndex = 13;
            this.lblRestantes.Text = "preguntas restantes";
            // 
            // lstPreguntas
            // 
            this.lstPreguntas.FormattingEnabled = true;
            this.lstPreguntas.Location = new System.Drawing.Point(554, 169);
            this.lstPreguntas.Name = "lstPreguntas";
            this.lstPreguntas.Size = new System.Drawing.Size(120, 95);
            this.lstPreguntas.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPreguntas);
            this.Controls.Add(this.lblRestantes);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.progressBarTiempo);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cbDificultad);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.lblJugador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.RadioButton rbOpcion4;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.ProgressBar progressBarTiempo;
        private System.Windows.Forms.Timer timerPregunta;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblRestantes;
        private System.Windows.Forms.ListBox lstPreguntas;
        private System.Windows.Forms.Button button1;
    }
}

