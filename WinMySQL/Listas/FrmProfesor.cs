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
    public partial class FrmProfesor : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmProfesor()
        {
            InitializeComponent();
        }

        public FrmProfesor(int id, string Profesor, string cve)
        {
            InitializeComponent();
            this.id = id;
            txtProfesor.Text = Profesor;
            txtClaveprof.Text = cve;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                string sql = $"INSERT INTO Profesores (Nombre, CVE) VALUES ('{txtProfesor.Text}', '{txtClaveprof.Text}')";

                bool resultado = dt.ejecutarComando(sql);

                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar al Profesor. Verifica que la CVE no esté repetida.");
                }
            }
            else
            {
                string sqlUpdate = $"UPDATE Profesores SET Nombre='{txtProfesor.Text}', CVE='{txtClaveprof.Text}' WHERE idProfesores={id}";
                bool resultado = dt.ejecutarComando(sqlUpdate);

                if (resultado)
                {
                    MessageBox.Show("Profesor actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Profesor");
                }
            }
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
