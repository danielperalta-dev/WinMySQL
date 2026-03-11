namespace WINMYSQL.VISTAS
{
    partial class FrmProfesores
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
            btnAgregar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dgvProfesor = new DataGridView();
            cmsDataP = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).BeginInit();
            cmsDataP.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProfesor);
            splitContainer1.Size = new Size(700, 338);
            splitContainer1.SplitterDistance = 105;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(574, 47);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 47);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(498, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // dgvProfesor
            // 
            dgvProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesor.Dock = DockStyle.Fill;
            dgvProfesor.Location = new Point(0, 0);
            dgvProfesor.Margin = new Padding(3, 2, 3, 2);
            dgvProfesor.Name = "dgvProfesor";
            dgvProfesor.RowHeadersWidth = 51;
            dgvProfesor.Size = new Size(700, 230);
            dgvProfesor.TabIndex = 0;
            dgvProfesor.CellContentDoubleClick += dgvProfesor_CellContentDoubleClick;
            // 
            // cmsDataP
            // 
            cmsDataP.ImageScalingSize = new Size(20, 20);
            cmsDataP.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsDataP.Name = "contextMenuStrip1";
            cmsDataP.Size = new Size(181, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(180, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProfesores";
            Text = "FrmProfesores";
            Activated += FrmProfesores_Activated;
            Load += FrmProfesores_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).EndInit();
            cmsDataP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregar;
        private TextBox textBox1;
        private Label label1;
        private ContextMenuStrip cmsDataP;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private DataGridView dgvProfesor;
    }
}