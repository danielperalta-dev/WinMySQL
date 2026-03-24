using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinMySQL.Listas
{
    public partial class frmProfesores : Form
    {
        Datos Datos = new Datos();
        DataSet ds;
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProfesor profes = new frmProfesor();
            profes.ShowDialog();
        }

        private void FrmProfesores_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = Datos.ejecutar("Select * from Profesores");
                if (ds != null)
                {
                    dgvProfesor.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void FrmProfesores_Load(object sender, EventArgs e)
        {
            busqueda();
        }

        private void dgvProfesor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProfesor profe = new frmProfesor(
                 Convert.ToInt32(dgvProfesor.CurrentRow.Cells[0].Value),
              dgvProfesor.CurrentRow.Cells[1].Value.ToString(),
             dgvProfesor.CurrentRow.Cells[2].Value.ToString());

            profe.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idProfesor = Convert.ToInt32(dgvProfesor.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas Eliminar El Profesor: "
                + dgvProfesor.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = Datos.ejecutarComando($"Delete from Profesores where idProfesores={idProfesor}");
                if (f)
                {
                    MessageBox.Show("Profesor Eliminado", "Sistema");

                }
                else
                {
                    MessageBox.Show("Error", "Sistema");
                }
            }
        }

        private void busqueda()
        {
            ds = Datos.ejecutar($"Select * from Profesores where Nombre like ('%{txtProfesores.Text}%')");
            if (ds != null)
            {
                dgvProfesor.DataSource = ds.Tables[0];
            }
        }

        private void txtProfesores_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

    }
}
