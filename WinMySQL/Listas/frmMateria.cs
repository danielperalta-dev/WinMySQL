using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Listas
{
    public partial class frmMateria : Form
    {
        int id = 0;
        bool updating = false;
        Datos datos = new Datos();
        public frmMateria()
        {
            InitializeComponent();
        }


        public frmMateria(int id, string materia, string cve)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = materia;
            txtClaveMateria.Text = cve;
            updating = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = datos.ejecutarComando(
                    $"Insert into Materias (Materia,CVE) " +
                    $"values ('{txtMateria.Text}','{txtClaveMateria.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia");
                }
            }
            else
            {
                bool resultado = datos.ejecutarComando(
                    $"Update Materias set Materia='{txtMateria.Text}', CVE='{txtClaveMateria.Text}' " +
                    $"where idMateria={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }


        }
        }
}
