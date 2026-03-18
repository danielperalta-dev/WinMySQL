namespace WinMySQL.Listas
{
    partial class frmProfesor
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
            txtProfesor = new TextBox();
            btnAceptar = new Button();
            txtClaveprof = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Profesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 112);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Clave";
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new Point(50, 65);
            txtProfesor.Margin = new Padding(3, 2, 3, 2);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new Size(498, 23);
            txtProfesor.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(574, 140);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtClaveprof
            // 
            txtClaveprof.Location = new Point(50, 140);
            txtClaveprof.Margin = new Padding(3, 2, 3, 2);
            txtClaveprof.Name = "txtClaveprof";
            txtClaveprof.Size = new Size(498, 23);
            txtClaveprof.TabIndex = 3;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 189);
            Controls.Add(btnAceptar);
            Controls.Add(txtClaveprof);
            Controls.Add(txtProfesor);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProfesor";
            Text = "FrmProfesor";
            Load += FrmProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProfesor;
        private Button btnAceptar;
        private TextBox txtClaveprof;
    }
}