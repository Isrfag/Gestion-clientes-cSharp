namespace GestionClientes
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            btnGuardar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            txtTlf = new TextBox();
            lblTlf = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            textCredit = new TextBox();
            lblTarjeta = new Label();
            button1 = new Button();
            lblshowId = new Label();
            label3 = new Label();
            lblId = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(386, 34);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(368, 319);
            listClientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(158, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(98, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(158, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(386, 359);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtTlf
            // 
            txtTlf.Location = new Point(158, 177);
            txtTlf.Name = "txtTlf";
            txtTlf.Size = new Size(194, 23);
            txtTlf.TabIndex = 6;
            // 
            // lblTlf
            // 
            lblTlf.AutoSize = true;
            lblTlf.Location = new Point(98, 180);
            lblTlf.Name = "lblTlf";
            lblTlf.Size = new Size(55, 15);
            lblTlf.TabIndex = 5;
            lblTlf.Text = "Teléfono:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(158, 136);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 139);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Apellido:";
            // 
            // textCredit
            // 
            textCredit.Location = new Point(206, 217);
            textCredit.Name = "textCredit";
            textCredit.Size = new Size(131, 23);
            textCredit.TabIndex = 10;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(98, 220);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(102, 15);
            lblTarjeta.TabIndex = 9;
            lblTarjeta.Text = "Tarjeta de Crédito:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(527, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lblshowId
            // 
            lblshowId.AutoSize = true;
            lblshowId.Location = new Point(98, 56);
            lblshowId.Name = "lblshowId";
            lblshowId.Size = new Size(21, 15);
            lblshowId.TabIndex = 12;
            lblshowId.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 56);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 13;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(164, 56);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(608, 359);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lblId);
            Controls.Add(label3);
            Controls.Add(lblshowId);
            Controls.Add(button1);
            Controls.Add(textCredit);
            Controls.Add(lblTarjeta);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtTlf);
            Controls.Add(lblTlf);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(listClientes);
            Name = "GestionClientes";
            Text = "Form2";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Button btnGuardar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnEliminar;
        private TextBox txtTlf;
        private Label lblTlf;
        private TextBox txtApellido;
        private Label label1;
        private TextBox textCredit;
        private Label lblTarjeta;
        private Button button1;
        private Label lblshowId;
        private Label label3;
        private Label lblId;
        private Button btnAgregar;
    }
}