using System;
using System.Windows.Forms;

namespace BoletinCalificaciones.Practica
{
    public partial class Form1 : Form
    {
        // constantes
        private const double NOTA_APROBADO = 70;
        private const double NOTA_RECUPERACION = 60;
        private const int CANT_PERIODOS = 4;
        private const double NOTA_MIN = 0;
        private const double NOTA_MAX = 100;

        // acumuladores y contadores
        private double sumaPromedios = 0;
        private int cantAprobadas = 0;
        private int cantRecuperacion = 0;
        private int cantReprobadas = 0;

        public Form1()
        {
            InitializeComponent();

            // conecta los eventos
            Load += Form1_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnResumen.Click += btnResumen_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // carga las asignaturas y deja el formulario inicial
        private void Form1_Load(object? sender, EventArgs e)
        {
            cmbAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsignatura.Items.Add("Matemática");
            cmbAsignatura.Items.Add("Lengua Española");
            cmbAsignatura.Items.Add("Ciencias Naturales");
            cmbAsignatura.Items.Add("Inglés");
            cmbAsignatura.Items.Add("Informática");

            ReiniciarFormulario();
        }

        // registra una asignatura
        private void btnRegistrar_Click(object? sender, EventArgs e)
        {
            // valida nombre
            if (txtEstudiante.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el nombre del estudiante.");
                txtEstudiante.Focus();
                return;
            }

            // valida tanda
            if (!rdbMatutina.Checked && !rdbVespertina.Checked)
            {
                MessageBox.Show("Seleccione la tanda.");
                return;
            }

            // valida asignatura
            if (cmbAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una asignatura.");
                cmbAsignatura.Focus();
                return;
            }

            // valida las 4 notas
            double p1, p2, p3, p4;
            if (!LeerNota(txtP1, "P1", out p1)) return;
            if (!LeerNota(txtP2, "P2", out p2)) return;
            if (!LeerNota(txtP3, "P3", out p3)) return;
            if (!LeerNota(txtP4, "P4", out p4)) return;

            // calcula el promedio
            double promedio = (p1 + p2 + p3 + p4) / CANT_PERIODOS;

            // define la situación
            string situacion;
            if (!chkAsistencia.Checked)
            {
                situacion = "Reprobada por asistencia";
                cantReprobadas++;
            }
            else if (promedio >= NOTA_APROBADO)
            {
                situacion = "Aprobada";
                cantAprobadas++;
            }
            else if (promedio >= NOTA_RECUPERACION)
            {
                situacion = "En recuperación";
                cantRecuperacion++;
            }
            else
            {
                situacion = "Reprobada";
                cantReprobadas++;
            }

            // agrega la línea a la lista y acumula el promedio
            lstBoletin.Items.Add(cmbAsignatura.Text + " · " + promedio.ToString("0.00") + " · " + situacion);
            sumaPromedios += promedio;

            // prepara la siguiente asignatura
            LimpiarAsignatura();
            cmbAsignatura.Focus();
        }

        // muestra el resumen
        private void btnResumen_Click(object? sender, EventArgs e)
        {
            int total = cantAprobadas + cantRecuperacion + cantReprobadas;

            // no muestra el resumen sin asignaturas
            if (total == 0)
            {
                MessageBox.Show("Registre al menos una asignatura.");
                return;
            }

            // promedio de los promedios
            double promedioGeneral = sumaPromedios / total;

            lblPromedioGeneral.Text = promedioGeneral.ToString("0.00");
            lblAprobadas.Text = cantAprobadas.ToString();
            lblRecuperacion.Text = cantRecuperacion.ToString();
            lblReprobadas.Text = cantReprobadas.ToString();

            // situación general
            if (cantReprobadas > 0)
                lblSituacion.Text = "Situación: Tiene asignaturas reprobadas";
            else if (cantRecuperacion > 0)
                lblSituacion.Text = "Situación: Tiene asignaturas en recuperación";
            else
                lblSituacion.Text = "Situación: Aprobó todas las asignaturas";
        }

        // deja el formulario como al iniciar
        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        // cierra la aplicación
        private void btnSalir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        // lee una nota y verifica que sea de 0 a 100
        private bool LeerNota(TextBox caja, string periodo, out double nota)
        {
            if (!double.TryParse(caja.Text, out nota) || nota < NOTA_MIN || nota > NOTA_MAX)
            {
                MessageBox.Show("La nota de " + periodo + " debe ser un número entre "
                    + NOTA_MIN + " y " + NOTA_MAX + ".");
                caja.Focus();
                caja.SelectAll();
                return false;
            }
            return true;
        }

        // limpia los datos de la asignatura
        private void LimpiarAsignatura()
        {
            cmbAsignatura.SelectedIndex = -1;
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();
            chkAsistencia.Checked = true;
        }

        // deja todo en su estado inicial
        private void ReiniciarFormulario()
        {
            txtEstudiante.Clear();
            rdbMatutina.Checked = true;
            LimpiarAsignatura();
            lstBoletin.Items.Clear();

            sumaPromedios = 0;
            cantAprobadas = 0;
            cantRecuperacion = 0;
            cantReprobadas = 0;

            lblPromedioGeneral.Text = "0.00";
            lblAprobadas.Text = "0";
            lblRecuperacion.Text = "0";
            lblReprobadas.Text = "0";
            lblSituacion.Text = "Situación:";
        }

        private void lblSituacion_Click(object sender, EventArgs e)
        {

        }
    }
}
