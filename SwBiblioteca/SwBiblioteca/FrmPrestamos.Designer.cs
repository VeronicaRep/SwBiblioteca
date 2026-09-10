namespace SwBiblioteca
{
    partial class FrmPrestamos
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlDatos = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechadevolucion = new Label();
            lblFechaprestamo = new Label();
            cmbLibro = new ComboBox();
            lblLibro = new Label();
            cmbUsuario = new ComboBox();
            lblUsuario = new Label();
            pnlLista = new Panel();
            dgvPrestamos = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1344, 70);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(413, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(447, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PRÉSTAMOS";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.WhiteSmoke;
            pnlDatos.Controls.Add(btnCancelar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(btnEditar);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnNuevo);
            pnlDatos.Controls.Add(dtpFechaDevolucion);
            pnlDatos.Controls.Add(dtpFechaPrestamo);
            pnlDatos.Controls.Add(lblFechadevolucion);
            pnlDatos.Controls.Add(lblFechaprestamo);
            pnlDatos.Controls.Add(cmbLibro);
            pnlDatos.Controls.Add(lblLibro);
            pnlDatos.Controls.Add(cmbUsuario);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 70);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1344, 514);
            pnlDatos.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(982, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(811, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(638, 420);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 42);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(472, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 42);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(293, 420);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 42);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Checked = false;
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(655, 321);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Size = new Size(300, 31);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(655, 237);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(300, 31);
            dtpFechaPrestamo.TabIndex = 6;
            dtpFechaPrestamo.Value = new DateTime(2026, 9, 10, 2, 6, 20, 0);
            // 
            // lblFechadevolucion
            // 
            lblFechadevolucion.AutoSize = true;
            lblFechadevolucion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechadevolucion.Location = new Point(370, 320);
            lblFechadevolucion.Name = "lblFechadevolucion";
            lblFechadevolucion.Size = new Size(222, 32);
            lblFechadevolucion.TabIndex = 5;
            lblFechadevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaprestamo
            // 
            lblFechaprestamo.AutoSize = true;
            lblFechaprestamo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaprestamo.Location = new Point(370, 236);
            lblFechaprestamo.Name = "lblFechaprestamo";
            lblFechaprestamo.Size = new Size(200, 32);
            lblFechaprestamo.TabIndex = 4;
            lblFechaprestamo.Text = "Fecha Préstamo:";
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(655, 147);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(292, 33);
            cmbLibro.TabIndex = 3;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(370, 147);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(80, 32);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(655, 60);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(292, 33);
            cmbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(370, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 32);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvPrestamos);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(0, 584);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(1344, 366);
            pnlLista.TabIndex = 2;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.Location = new Point(0, 0);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersWidth = 62;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1344, 366);
            dgvPrestamos.TabIndex = 0;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 950);
            Controls.Add(pnlLista);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrestamos";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlDatos;
        private Panel pnlLista;
        private Label lblTitulo;
        private Label lblUsuario;
        private ComboBox cmbLibro;
        private Label lblLibro;
        private ComboBox cmbUsuario;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaPrestamo;
        private Label lblFechadevolucion;
        private Label lblFechaprestamo;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvPrestamos;
    }
}