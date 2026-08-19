namespace SwBiblioteca
{
    partial class FrmLibros
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
            pnlBusqueda = new Panel();
            lblTitulo2 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            pnlDatos = new Panel();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAnio = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            txtTitulo2 = new Label();
            lblISBN = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1347, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(474, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(361, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(lblTitulo2);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1347, 69);
            pnlBusqueda.TabIndex = 1;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Location = new Point(383, 18);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(50, 25);
            lblTitulo2.TabIndex = 3;
            lblTitulo2.Text = "ISBN";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(781, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(508, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(217, 31);
            txtBuscar.TabIndex = 1;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(comboBox2);
            pnlDatos.Controls.Add(comboBox1);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAnio);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(txtTitulo2);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 129);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1347, 320);
            pnlDatos.TabIndex = 2;
            pnlDatos.Paint += pnlDatos_Paint;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(596, 279);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(342, 31);
            txtExistencias.TabIndex = 13;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(596, 234);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(342, 31);
            txtAnio.TabIndex = 12;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(596, 187);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(342, 31);
            txtCategoria.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(596, 142);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(342, 33);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(596, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 33);
            comboBox1.TabIndex = 9;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(596, 50);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(342, 31);
            txtTitulo.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(596, 6);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(342, 31);
            txtISBN.TabIndex = 7;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Location = new Point(387, 282);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(95, 25);
            lblExistencias.TabIndex = 6;
            lblExistencias.Text = "Existencias";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(387, 240);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(45, 25);
            lblAnio.TabIndex = 5;
            lblAnio.Text = "Año";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(387, 193);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 25);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(387, 143);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(76, 25);
            lblEditorial.TabIndex = 3;
            lblEditorial.Text = "Editorial";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(387, 98);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(57, 25);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // txtTitulo2
            // 
            txtTitulo2.AutoSize = true;
            txtTitulo2.Location = new Point(387, 53);
            txtTitulo2.Name = "txtTitulo2";
            txtTitulo2.Size = new Size(56, 25);
            txtTitulo2.TabIndex = 1;
            txtTitulo2.Text = "Título";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(386, 12);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(50, 25);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(369, 499);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(690, 60);
            pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(554, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(426, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(298, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(162, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(23, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(120, 578);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.Size = new Size(1100, 192);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 782);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label lblTitulo2;
        private Panel pnlDatos;
        private Label txtTitulo2;
        private Label lblISBN;
        private Label lblExistencias;
        private Label lblAnio;
        private Label lblCategoria;
        private Label lblEditorial;
        private Label lblAutor;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private DataGridView dgvLibros;
        private TextBox txtISBN;
        private TextBox txtTitulo;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox txtExistencias;
        private TextBox txtAnio;
        private TextBox txtCategoria;
    }
}