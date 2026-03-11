using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WINMYSQL.VISTAS
{
    public partial class FrmAlumno : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmAlumno()
        {
            InitializeComponent();
        }

        public FrmAlumno(int id, string Alumno, string num)
        {
            InitializeComponent();
            this.id = id;
            txtPaterno.Text = Alumno;
            txtNumControl.Text = num;
            updating = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Alumnos (Control, Paterno, Materno, Nombre) " +
                    $"values ('{txtNumControl.Text}', '{txtPaterno.Text}', '{txtMaterno.Text}', '{txtNombre.Text}')");

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
                    $"Update Alumnos set Paterno='{txtPaterno.Text}', Materno='{txtMaterno.Text}', " +
                    $"Nombre='{txtNombre.Text}' where Control='{id}'");

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
