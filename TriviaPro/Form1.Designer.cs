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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rbtnOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.progressTiempo = new System.Windows.Forms.ProgressBar();
            this.timerPregunta = new System.Windows.Forms.Timer(this.components);
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(239, 111);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(146, 21);
            this.cmbCategoria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione categoria";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(239, 155);
            this.cmbNivel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(146, 21);
            this.cmbNivel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione nivel de dificultad";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(95, 196);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(99, 13);
            this.lblPregunta.TabIndex = 4;
            this.lblPregunta.Text = "Aqui va la pregunta";
            // 
            // rbtnOpcion1
            // 
            this.rbtnOpcion1.AutoSize = true;
            this.rbtnOpcion1.Location = new System.Drawing.Point(98, 228);
            this.rbtnOpcion1.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnOpcion1.Name = "rbtnOpcion1";
            this.rbtnOpcion1.Size = new System.Drawing.Size(85, 17);
            this.rbtnOpcion1.TabIndex = 5;
            this.rbtnOpcion1.TabStop = true;
            this.rbtnOpcion1.Text = "radioButton1";
            this.rbtnOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion2
            // 
            this.rbtnOpcion2.AutoSize = true;
            this.rbtnOpcion2.Location = new System.Drawing.Point(98, 264);
            this.rbtnOpcion2.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnOpcion2.Name = "rbtnOpcion2";
            this.rbtnOpcion2.Size = new System.Drawing.Size(85, 17);
            this.rbtnOpcion2.TabIndex = 6;
            this.rbtnOpcion2.TabStop = true;
            this.rbtnOpcion2.Text = "radioButton2";
            this.rbtnOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion3
            // 
            this.rbtnOpcion3.AutoSize = true;
            this.rbtnOpcion3.Location = new System.Drawing.Point(208, 264);
            this.rbtnOpcion3.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnOpcion3.Name = "rbtnOpcion3";
            this.rbtnOpcion3.Size = new System.Drawing.Size(85, 17);
            this.rbtnOpcion3.TabIndex = 7;
            this.rbtnOpcion3.TabStop = true;
            this.rbtnOpcion3.Text = "radioButton3";
            this.rbtnOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(157, 355);
            this.btnResponder.Margin = new System.Windows.Forms.Padding(2);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(95, 36);
            this.btnResponder.TabIndex = 8;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click_1);
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.Location = new System.Drawing.Point(574, 440);
            this.btnNuevaPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(95, 36);
            this.btnNuevaPartida.TabIndex = 9;
            this.btnNuevaPartida.Text = "Nueva partida";
            this.btnNuevaPartida.UseVisualStyleBackColor = true;
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click_1);
            // 
            // progressTiempo
            // 
            this.progressTiempo.Location = new System.Drawing.Point(157, 12);
            this.progressTiempo.Margin = new System.Windows.Forms.Padding(2);
            this.progressTiempo.Name = "progressTiempo";
            this.progressTiempo.Size = new System.Drawing.Size(738, 22);
            this.progressTiempo.TabIndex = 10;
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(454, 129);
            this.lstHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(465, 277);
            this.lstHistorial.TabIndex = 11;
            this.lstHistorial.SelectedIndexChanged += new System.EventHandler(this.lstHistorial_SelectedIndexChanged);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(723, 77);
            this.lblPuntaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 12;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.Location = new System.Drawing.Point(505, 51);
            this.lblTiempoRestante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(83, 13);
            this.lblTiempoRestante.TabIndex = 13;
            this.lblTiempoRestante.Text = "Tiempo restante";
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(853, 77);
            this.lblPreguntasRestantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(101, 13);
            this.lblPreguntasRestantes.TabIndex = 14;
            this.lblPreguntasRestantes.Text = "Preguntas restantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "TIEMPO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPreguntasRestantes);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.progressTiempo);
            this.Controls.Add(this.btnNuevaPartida);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbtnOpcion3);
            this.Controls.Add(this.rbtnOpcion2);
            this.Controls.Add(this.rbtnOpcion1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbtnOpcion1;
        private System.Windows.Forms.RadioButton rbtnOpcion2;
        private System.Windows.Forms.RadioButton rbtnOpcion3;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnNuevaPartida;
        private System.Windows.Forms.ProgressBar progressTiempo;
        private System.Windows.Forms.Timer timerPregunta;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Label lblPreguntasRestantes;
        private System.Windows.Forms.Label label3;
    }
}

