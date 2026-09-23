namespace WinFormsApp1
{
    partial class Form1
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
            dgvClientes = new DataGridView();
            label = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label5 = new Label();
            txtBuscarId = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(61, 266);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(552, 145);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(192, 255, 192);
            label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Blue;
            label.Location = new Point(221, 9);
            label.Name = "label";
            label.Size = new Size(281, 90);
            label.TabIndex = 1;
            label.Text = "      DATOS DEL CLIENTE\r\n  Autor: Domingo Martínez\r\n\r\n";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 121);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 124);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(103, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 23);
            txtApellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 154);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellidos:";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 23);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 183);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(103, 208);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(361, 23);
            txtTelefono.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 211);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Teléfono:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(103, 237);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(389, 237);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(194, 237);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(286, 237);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 124);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "ID Cliente:";
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(551, 121);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 23);
            txtBuscarId.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(669, 121);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarId);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(label);
            Controls.Add(dgvClientes);
            Name = "Form1";
            Text = "Gestión de Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label label;
        private TextBox txtNombre;
        
        private Label label1;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label5;
        private TextBox txtBuscarId;
        private Button btnBuscar;
        //private TextBox txtNombre;
    }
}