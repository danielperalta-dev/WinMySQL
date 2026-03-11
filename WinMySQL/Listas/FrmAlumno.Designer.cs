namespace WINMYSQL.VISTAS
{
    partial class FrmAlumno
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
            label2.Location = new Point(36, 318);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Num. Control";
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(36, 104);
            txtPaterno.Margin = new Padding(3, 2, 3, 2);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(423, 23);
            txtPaterno.TabIndex = 2;
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(36, 335);
            txtNumControl.Margin = new Padding(3, 2, 3, 2);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(423, 23);
            txtNumControl.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(531, 200);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(93, 26);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // lblMaterno
            // 
            lblMaterno.AutoSize = true;
            lblMaterno.Location = new Point(36, 169);
            lblMaterno.Name = "lblMaterno";
            lblMaterno.Size = new Size(102, 15);
            lblMaterno.TabIndex = 5;
            lblMaterno.Text = "Apelllido materno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 241);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(36, 200);
            txtMaterno.Margin = new Padding(3, 2, 3, 2);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(423, 23);
            txtMaterno.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 268);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(423, 23);
            txtNombre.TabIndex = 9;
            // 
            // lblPaterno
            // 
            lblPaterno.AutoSize = true;
            lblPaterno.Location = new Point(36, 76);
            lblPaterno.Name = "lblPaterno";
            lblPaterno.Size = new Size(95, 15);
            lblPaterno.TabIndex = 10;
            lblPaterno.Text = "Apellido paterno";
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
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
    }
}