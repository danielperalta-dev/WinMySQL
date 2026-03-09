namespace WinMySQL.Listas
{
    partial class frmMateria
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
            txtMateria = new TextBox();
            txtClaveMateria = new TextBox();
            lblMateria = new Label();
            lblClaveMateria = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(32, 50);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(268, 23);
            txtMateria.TabIndex = 0;
            // 
            // txtClaveMateria
            // 
            txtClaveMateria.Location = new Point(32, 140);
            txtClaveMateria.Name = "txtClaveMateria";
            txtClaveMateria.Size = new Size(268, 23);
            txtClaveMateria.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(40, 19);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia";
            // 
            // lblClaveMateria
            // 
            lblClaveMateria.AutoSize = true;
            lblClaveMateria.Location = new Point(40, 110);
            lblClaveMateria.Name = "lblClaveMateria";
            lblClaveMateria.Size = new Size(79, 15);
            lblClaveMateria.TabIndex = 3;
            lblClaveMateria.Text = "Clave Materia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(340, 102);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 223);
            Controls.Add(btnAceptar);
            Controls.Add(lblClaveMateria);
            Controls.Add(lblMateria);
            Controls.Add(txtClaveMateria);
            Controls.Add(txtMateria);
            Name = "frmMateria";
            Text = "frmMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMateria;
        private TextBox txtClaveMateria;
        private Label lblMateria;
        private Label lblClaveMateria;
        private Button btnAceptar;
    }
}