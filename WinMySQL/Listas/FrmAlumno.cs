using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Listas
{
    public partial class frmAlumno : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int id, string nombre, string sNombre, string apPat, string apMat, int numControl, string semestre, string carrera)
        { 
            this.id = id;
            txtNombre.Text = nombre;
            txtSNombre.Text = sNombre;
            txtPaterno.Text = apPat;
            txtMaterno.Text = apMat;
            txtNumControl.Text = numControl.ToString();
            txtSemestre.Text = semestre;
            txtCarrera.Text = carrera;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Alumnos (Nombre, SegundoNombre, ApellidoPat, ApellidoMat, NumeroControl, Semestre, Carrera) " +
                    $"values ('{txtNombre.Text}', '{txtSNombre.Text}', '{txtPaterno.Text}', '{txtMaterno.Text}','{txtNumControl.Text}','{txtSemestre.Text}','{txtCarrera.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: El número de control ya existe o faltan datos.");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"UPDATE Alumnos SET " +
                    $"Nombre = '{txtNombre.Text}', " +
                    $"SegundoNombre = '{txtSNombre.Text}', " +
                    $"ApellidoPat = '{txtPaterno.Text}', " +
                    $"ApellidoMat = '{txtMaterno.Text}', " +
                    $"NumeroControl = '{txtNumControl.Text}', " +
                    $"Semestre = '{txtSemestre.Text}', " +
                    $"Carrera = '{txtCarrera.Text}' " +
                    $"WHERE idAlumno = {id}");

                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Alumno");
                }
            }
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
