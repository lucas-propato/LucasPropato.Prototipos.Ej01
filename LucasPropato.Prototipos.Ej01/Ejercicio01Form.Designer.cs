namespace LucasPropato.Prototipos.Ej01
{
    partial class Ejercicio01Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BotonAceptar = new Button();
            txtDocumento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtFechaNacimiento = new TextBox();
            SuspendLayout();
            // 
            // BotonAceptar
            // 
            BotonAceptar.Location = new Point(472, 66);
            BotonAceptar.Name = "BotonAceptar";
            BotonAceptar.Size = new Size(75, 23);
            BotonAceptar.TabIndex = 0;
            BotonAceptar.Text = "&Aceptar";
            BotonAceptar.UseVisualStyleBackColor = true;
            BotonAceptar.Click += BotonAceptar_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(12, 27);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(129, 23);
            txtDocumento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(282, 27);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(129, 23);
            txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 9);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de nacimiento";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(417, 27);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(129, 23);
            txtFechaNacimiento.TabIndex = 7;
            // 
            // Ejercicio01Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 108);
            Controls.Add(label4);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtDocumento);
            Controls.Add(BotonAceptar);
            Name = "Ejercicio01Form";
            Text = "Ejercicio 01";
            Load += Ejercicio01Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonAceptar;
        private TextBox txtDocumento;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtFechaNacimiento;
    }
}
