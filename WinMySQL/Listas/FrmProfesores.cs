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
    public partial class FrmProfesores : Form
    {
        Datos Datos = new Datos();
        DataSet ds;
        public FrmProfesores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProfesor profes = new FrmProfesor();
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

        private void dgvProfesor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProfesor profe = new FrmProfesor(
                 Convert.ToInt32(dgvProfesor.CurrentRow.Cells[0].Value),
              dgvProfesor.CurrentRow.Cells[1].Value.ToString(),
             dgvProfesor.CurrentRow.Cells[2].Value.ToString());

            profe.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idProfesor = Convert.ToInt32(dgvProfesor.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas Eliminar El Profesor:"
                + dgvProfesor.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = Datos.ejecutarComando($"Delete from Profesores where idProfesor={idProfesor}");
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
    }
}
