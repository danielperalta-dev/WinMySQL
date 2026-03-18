namespace WinMySQL.Listas
{
    partial class frmAlumno
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
            label1 = new Label();
            label2 = new Label();
            txtPaterno = new TextBox();
            txtNumControl = new TextBox();
            btnAceptar = new Button();
            lblMaterno = new Label();
            lblNombre = new Label();
            txtMaterno = new TextBox();
            txtNombre = new TextBox();
            lblPaterno = new Label();
            lblSemestre = new Label();
            txtSemestre = new TextBox();
            txtCarrera = new TextBox();
            lblCarrera = new Label();
            lblSnombre = new Label();
            txtSNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 348);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Num. Control";
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(36, 209);
            txtPaterno.Margin = new Padding(3, 2, 3, 2);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(423, 23);
            txtPaterno.TabIndex = 2;
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(36, 378);
            txtNumControl.Margin = new Padding(3, 2, 3, 2);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(423, 23);
            txtNumControl.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(508, 267);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(93, 26);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblMaterno
            // 
            lblMaterno.AutoSize = true;
            lblMaterno.Location = new Point(36, 265);
            lblMaterno.Name = "lblMaterno";
            lblMaterno.Size = new Size(102, 15);
            lblMaterno.TabIndex = 5;
            lblMaterno.Text = "Apelllido materno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(36, 292);
            txtMaterno.Margin = new Padding(3, 2, 3, 2);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(423, 23);
            txtMaterno.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 80);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(423, 23);
            txtNombre.TabIndex = 9;
            // 
            // lblPaterno
            // 
            lblPaterno.AutoSize = true;
            lblPaterno.Location = new Point(36, 181);
            lblPaterno.Name = "lblPaterno";
            lblPaterno.Size = new Size(95, 15);
            lblPaterno.TabIndex = 10;
            lblPaterno.Text = "Apellido paterno";
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Location = new Point(36, 426);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(55, 15);
            lblSemestre.TabIndex = 11;
            lblSemestre.Text = "Semestre";
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(36, 456);
            txtSemestre.Margin = new Padding(3, 2, 3, 2);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(423, 23);
            txtSemestre.TabIndex = 12;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(36, 522);
            txtCarrera.Margin = new Padding(3, 2, 3, 2);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(423, 23);
            txtCarrera.TabIndex = 13;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(36, 505);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 14;
            lblCarrera.Text = "Carrera";
            // 
            // lblSnombre
            // 
            lblSnombre.AutoSize = true;
            lblSnombre.Location = new Point(35, 114);
            lblSnombre.Name = "lblSnombre";
            lblSnombre.Size = new Size(99, 15);
            lblSnombre.TabIndex = 15;
            lblSnombre.Text = "Segundo nombre";
            // 
            // txtSNombre
            // 
            txtSNombre.Location = new Point(36, 142);
            txtSNombre.Margin = new Padding(3, 2, 3, 2);
            txtSNombre.Name = "txtSNombre";
            txtSNombre.Size = new Size(423, 23);
            txtSNombre.TabIndex = 16;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 570);
            Controls.Add(txtSNombre);
            Controls.Add(lblSnombre);
            Controls.Add(lblCarrera);
            Controls.Add(txtCarrera);
            Controls.Add(txtSemestre);
            Controls.Add(lblSemestre);
            Controls.Add(lblPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtMaterno);
            Controls.Add(lblNombre);
            Controls.Add(lblMaterno);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumControl);
            Controls.Add(txtPaterno);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAlumno";
            Text = "FrmAlumno";
            Load += FrmAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPaterno;
        private TextBox txtNumControl;
        private Button btnAceptar;
        private Label lblMaterno;
        private Label lblNombre;
        private TextBox txtMaterno;
        private TextBox txtNombre;
        private Label lblPaterno;
        private Label lblSemestre;
        private TextBox txtSemestre;
        private TextBox txtCarrera;
        private Label lblCarrera;
        private Label lblSnombre;
        private TextBox txtSNombre;
    }
}