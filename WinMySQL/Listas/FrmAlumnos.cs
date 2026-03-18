using OfficeOpenXml;
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
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        OpenFileDialog ofdExcel = new OpenFileDialog();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
        }

        private void frmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            busqueda();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAlumno alumno = new frmAlumno(
        Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
        dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),     
        dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),     
        dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),      
        dgvAlumnos.CurrentRow.Cells[4].Value.ToString(),      
        Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[5].Value), 
        dgvAlumnos.CurrentRow.Cells[6].Value.ToString(),      
        dgvAlumnos.CurrentRow.Cells[7].Value.ToString()      
    );

            alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idAlu = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas Eliminar el Alumno:  "
                + dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"Delete from Alumnos where idAlumno={idAlu}");
                if (f)
                {
                    MessageBox.Show("Alumno Eliminado", "Sistema");

                }
                else

                    MessageBox.Show("Error", "Sistema");
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;

                ExcelPackage.License.SetNonCommercialPersonal("Daniel");
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int i = 0; i < columnCount; i++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, i + 1].Value.ToString());
                    }
                    for (int i = 2; i <= rowCount; i++)
                    {
                        DataRow drNew = dt.NewRow();
                        for (int col = 1; col <= columnCount; col++)
                        {
                            if (worksheet.Cells[i, col].Value == null)
                            {
                                drNew[col - 1] = "";
                                continue;
                            }
                            else
                            {
                                try
                                {
                                    drNew[col - 1] = worksheet.Cells[i, col].Value.ToString();
                                }
                                catch (Exception ex)
                                {
                                    drNew[col - 1] = worksheet.Cells[i, col].Value;
                                }
                            }
                        }
                        dt.Rows.Add(drNew);
                        string comando = $"Insert into Alumnos(Nombre, SegundoNombre, ApellidoPat, ApellidoMat, NumeroControl, Semestre, Carrera)" +
                            $" values('{drNew[0]}', '{drNew[1]}', '{drNew[2]}', '{drNew[3]}', {drNew[4]} , {drNew[5]} , '{drNew[6]}')";
                        datos.ejecutarComando(comando);
                    }
                }
            }
        }

        private void txtAlumnos_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        private void busqueda()
        {
            ds = datos.ejecutar($"Select * from Alumnos where Nombre like ('%{txtAlumnos.Text}%')");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int idAlum = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas Eliminar el Alumno: "
                + dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"Delete from Alumnos where idAlumno={idAlum}");
                if (f)
                {
                    MessageBox.Show("Alumno Eliminado", "Sistema");

                }
                else
                {
                    MessageBox.Show("Error", "Sistema");
                }
            }
        }
    }
}
