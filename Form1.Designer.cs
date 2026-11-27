namespace BoletinCalificaciones.Practica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBoletin = new ListBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtEstudiante = new TextBox();
            rdbVespertina = new RadioButton();
            rdbMatutina = new RadioButton();
            groupBox2 = new GroupBox();
            txtP4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbAsignatura = new ComboBox();
            txtP1 = new TextBox();
            txtP2 = new TextBox();
            txtP3 = new TextBox();
            btnRegistrar = new Button();
            chkAsistencia = new CheckBox();
            btnResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblSituacion = new Label();
            lblReprobadas = new Label();
            lblRecuperacion = new Label();
            lblAprobadas = new Label();
            lblPromedioGeneral = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lstBoletin
            // 
            lstBoletin.FormattingEnabled = true;
            lstBoletin.Location = new Point(500, 21);
            lstBoletin.Name = "lstBoletin";
            lstBoletin.Size = new Size(261, 186);
            lstBoletin.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEstudiante);
            groupBox1.Controls.Add(rdbVespertina);
            groupBox1.Controls.Add(rdbMatutina);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 152);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 108);
            label2.Name = "label2";
            label2.Size = new Size(38, 14);
            label2.TabIndex = 4;
            label2.Text = "Tanda:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(47, 14);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(97, 39);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(285, 23);
            txtEstudiante.TabIndex = 2;
            // 
            // rdbVespertina
            // 
            rdbVespertina.AutoSize = true;
            rdbVespertina.Location = new Point(212, 108);
            rdbVespertina.Name = "rdbVespertina";
            rdbVespertina.Size = new Size(73, 18);
            rdbVespertina.TabIndex = 1;
            rdbVespertina.TabStop = true;
            rdbVespertina.Text = "Vespertina";
            rdbVespertina.UseVisualStyleBackColor = true;
            // 
            // rdbMatutina
            // 
            rdbMatutina.AutoSize = true;
            rdbMatutina.Location = new Point(95, 108);
            rdbMatutina.Name = "rdbMatutina";
            rdbMatutina.Size = new Size(67, 18);
            rdbMatutina.TabIndex = 0;
            rdbMatutina.TabStop = true;
            rdbMatutina.Text = "Matutina";
            rdbMatutina.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtP4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbAsignatura);
            groupBox2.Controls.Add(txtP1);
            groupBox2.Controls.Add(txtP2);
            groupBox2.Controls.Add(txtP3);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(chkAsistencia);
            groupBox2.Location = new Point(12, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 248);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de la asignatura";
            // 
            // txtP4
            // 
            txtP4.Location = new Point(323, 121);
            txtP4.Name = "txtP4";
            txtP4.Size = new Size(100, 23);
            txtP4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 94);
            label4.Name = "label4";
            label4.Size = new Size(167, 14);
            label4.TabIndex = 11;
            label4.Text = "Calificaciones por periodo (0-100):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 48);
            label3.Name = "label3";
            label3.Size = new Size(61, 14);
            label3.TabIndex = 10;
            label3.Text = "Asignatura:";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(111, 48);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(260, 22);
            cmbAsignatura.TabIndex = 9;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(6, 121);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(100, 23);
            txtP1.TabIndex = 3;
            // 
            // txtP2
            // 
            txtP2.Location = new Point(112, 121);
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(100, 23);
            txtP2.TabIndex = 4;
            // 
            // txtP3
            // 
            txtP3.Location = new Point(218, 121);
            txtP3.Name = "txtP3";
            txtP3.Size = new Size(100, 23);
            txtP3.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(112, 209);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(188, 23);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // chkAsistencia
            // 
            chkAsistencia.AutoSize = true;
            chkAsistencia.Location = new Point(6, 167);
            chkAsistencia.Name = "chkAsistencia";
            chkAsistencia.Size = new Size(176, 18);
            chkAsistencia.TabIndex = 0;
            chkAsistencia.Text = "Cumple la asistencia minima (80%)";
            chkAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(119, 457);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(122, 23);
            btnResumen.TabIndex = 5;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(350, 457);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(111, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(577, 457);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lblSituacion);
            groupBox3.Controls.Add(lblReprobadas);
            groupBox3.Controls.Add(lblRecuperacion);
            groupBox3.Controls.Add(lblAprobadas);
            groupBox3.Controls.Add(lblPromedioGeneral);
            groupBox3.Location = new Point(500, 218);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(261, 200);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 123);
            label8.Name = "label8";
            label8.Size = new Size(65, 14);
            label8.TabIndex = 19;
            label8.Text = "Reprobadas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 91);
            label7.Name = "label7";
            label7.Size = new Size(83, 14);
            label7.TabIndex = 18;
            label7.Text = "En Recuperacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 62);
            label6.Name = "label6";
            label6.Size = new Size(61, 14);
            label6.TabIndex = 17;
            label6.Text = "Aprobadas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 32);
            label5.Name = "label5";
            label5.Size = new Size(90, 14);
            label5.TabIndex = 16;
            label5.Text = "Promedio general:";
            // 
            // lblSituacion
            // 
            lblSituacion.AutoSize = true;
            lblSituacion.Location = new Point(20, 149);
            lblSituacion.Name = "lblSituacion";
            lblSituacion.Size = new Size(51, 14);
            lblSituacion.TabIndex = 15;
            lblSituacion.Text = "Situacion";
            lblSituacion.Click += lblSituacion_Click;
            // 
            // lblReprobadas
            // 
            lblReprobadas.AutoSize = true;
            lblReprobadas.Location = new Point(148, 123);
            lblReprobadas.Name = "lblReprobadas";
            lblReprobadas.Size = new Size(65, 14);
            lblReprobadas.TabIndex = 14;
            lblReprobadas.Text = "Reprobadas:";
            // 
            // lblRecuperacion
            // 
            lblRecuperacion.AutoSize = true;
            lblRecuperacion.Location = new Point(148, 91);
            lblRecuperacion.Name = "lblRecuperacion";
            lblRecuperacion.Size = new Size(83, 14);
            lblRecuperacion.TabIndex = 13;
            lblRecuperacion.Text = "En Recuperacion:";
            // 
            // lblAprobadas
            // 
            lblAprobadas.AutoSize = true;
            lblAprobadas.Location = new Point(148, 62);
            lblAprobadas.Name = "lblAprobadas";
            lblAprobadas.Size = new Size(61, 14);
            lblAprobadas.TabIndex = 12;
            lblAprobadas.Text = "Aprobadas:";
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Location = new Point(148, 32);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(90, 14);
            lblPromedioGeneral.TabIndex = 11;
            lblPromedioGeneral.Text = "Promedio general:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(groupBox3);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstBoletin);
            Name = "Form1";
            Text = "Boletin de Calificaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBoletin;
        private GroupBox groupBox1;
        private RadioButton rdbVespertina;
        private RadioButton rdbMatutina;
        private GroupBox groupBox2;
        private Button btnRegistrar;
        private CheckBox chkAsistencia;
        private Button btnResumen;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label2;
        private Label label1;
        private TextBox txtEstudiante;
        private Label label4;
        private Label label3;
        private ComboBox cmbAsignatura;
        private TextBox txtP1;
        private TextBox txtP2;
        private TextBox txtP3;
        private GroupBox groupBox3;
        private TextBox txtP4;
        private Label lblSituacion;
        private Label lblReprobadas;
        private Label lblRecuperacion;
        private Label lblAprobadas;
        private Label lblPromedioGeneral;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
