namespace WinMySQL.Listas
{
    partial class frmMaterias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnAgregarMateria = new Button();
            lblBuscar = new Label();
            txtMaterias = new TextBox();
            dgvMaterias = new DataGridView();
            cmsData = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            cmsData.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregarMateria);
            splitContainer1.Panel1.Controls.Add(lblBuscar);
            splitContainer1.Panel1.Controls.Add(txtMaterias);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvMaterias);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 94;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(663, 35);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(75, 23);
            btnAgregarMateria.TabIndex = 2;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(23, 25);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar";
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(12, 55);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(571, 23);
            txtMaterias.TabIndex = 0;
            txtMaterias.TextChanged += txtMaterias_TextChanged;
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.ContextMenuStrip = cmsData;
            dgvMaterias.Location = new Point(3, 3);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.Size = new Size(794, 346);
            dgvMaterias.TabIndex = 0;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            dgvMaterias.CellContentClick += dgvMaterias_CellContentClick;
            dgvMaterias.CellContentDoubleClick += dgvMaterias_CellContentDoubleClick;
            // 
            // cmsData
            // 
            cmsData.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsData.Name = "cmsData";
            cmsData.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmMaterias";
            Text = "frmMaterias";
            Activated += frmMaterias_Activated;
            Load += frmMaterias_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            cmsData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregarMateria;
        private Label lblBuscar;
        private TextBox txtMaterias;
        private ContextMenuStrip cmsData;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private DataGridView dgvMaterias;
    }
}