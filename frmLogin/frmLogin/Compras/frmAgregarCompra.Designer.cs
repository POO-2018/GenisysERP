namespace frmLogin.Compras
{
    partial class frmAgregarCompra
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
            this.mtxtFactura = new System.Windows.Forms.MaskedTextBox();
            this.lblFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.cmbProveedore = new System.Windows.Forms.ComboBox();
            this.lblSubtotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtSubtotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblImpuesto = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnNuevoProveedor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dvdFormulario = new MaterialSkin.Controls.MaterialDivider();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductos = new MaterialSkin.Controls.MaterialLabel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReducirProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnQuitarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtFactura
            // 
            this.mtxtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mtxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mtxtFactura.Location = new System.Drawing.Point(130, 188);
            this.mtxtFactura.Mask = "000-000-00-00000000";
            this.mtxtFactura.Name = "mtxtFactura";
            this.mtxtFactura.Size = new System.Drawing.Size(218, 24);
            this.mtxtFactura.TabIndex = 0;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Depth = 0;
            this.lblFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFactura.Location = new System.Drawing.Point(18, 191);
            this.lblFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(78, 19);
            this.lblFactura.TabIndex = 1;
            this.lblFactura.Text = "N. Factura";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Depth = 0;
            this.lblProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedor.Location = new System.Drawing.Point(18, 263);
            this.lblProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(77, 19);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedore
            // 
            this.cmbProveedore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbProveedore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbProveedore.FormattingEnabled = true;
            this.cmbProveedore.Items.AddRange(new object[] {
            "Holaaaa"});
            this.cmbProveedore.Location = new System.Drawing.Point(130, 264);
            this.cmbProveedore.Name = "cmbProveedore";
            this.cmbProveedore.Size = new System.Drawing.Size(218, 26);
            this.cmbProveedore.TabIndex = 3;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Depth = 0;
            this.lblSubtotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Location = new System.Drawing.Point(24, 324);
            this.lblSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 19);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "SubTotal";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Depth = 0;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Hint = "0.00";
            this.txtSubtotal.Location = new System.Drawing.Point(140, 324);
            this.txtSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.Size = new System.Drawing.Size(146, 23);
            this.txtSubtotal.TabIndex = 6;
            this.txtSubtotal.UseSystemPasswordChar = false;
            this.txtSubtotal.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Depth = 0;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Hint = "0.00";
            this.txtImpuesto.Location = new System.Drawing.Point(140, 380);
            this.txtImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.PasswordChar = '\0';
            this.txtImpuesto.SelectedText = "";
            this.txtImpuesto.SelectionLength = 0;
            this.txtImpuesto.SelectionStart = 0;
            this.txtImpuesto.Size = new System.Drawing.Size(146, 23);
            this.txtImpuesto.TabIndex = 8;
            this.txtImpuesto.UseSystemPasswordChar = false;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Depth = 0;
            this.lblImpuesto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblImpuesto.Location = new System.Drawing.Point(23, 384);
            this.lblImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(72, 19);
            this.lblImpuesto.TabIndex = 7;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Hint = "0.00";
            this.txtTotal.Location = new System.Drawing.Point(140, 438);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(146, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(33, 441);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Depth = 0;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(369, 266);
            this.btnNuevoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Primary = true;
            this.btnNuevoProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoProveedor.TabIndex = 11;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            // 
            // dvdFormulario
            // 
            this.dvdFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dvdFormulario.Depth = 0;
            this.dvdFormulario.Location = new System.Drawing.Point(461, 64);
            this.dvdFormulario.MouseState = MaterialSkin.MouseState.HOVER;
            this.dvdFormulario.Name = "dvdFormulario";
            this.dvdFormulario.Size = new System.Drawing.Size(8, 571);
            this.dvdFormulario.TabIndex = 12;
            this.dvdFormulario.Text = "materialDivider1";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Holaaaa"});
            this.cmbEstado.Location = new System.Drawing.Point(130, 118);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(218, 26);
            this.cmbEstado.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(18, 117);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 19);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(114, 594);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(96, 34);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtObservaciones.Location = new System.Drawing.Point(140, 490);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(304, 78);
            this.txtObservaciones.TabIndex = 16;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Depth = 0;
            this.lblObservaciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObservaciones.Location = new System.Drawing.Point(18, 523);
            this.lblObservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(108, 19);
            this.lblObservaciones.TabIndex = 17;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Holaaaa"});
            this.cmbCategoria.Location = new System.Drawing.Point(648, 107);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(218, 26);
            this.cmbCategoria.TabIndex = 19;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(537, 110);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Depth = 0;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductos.Location = new System.Drawing.Point(679, 68);
            this.lblProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(122, 29);
            this.lblProductos.TabIndex = 20;
            this.lblProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(485, 219);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(463, 175);
            this.dgvProductos.TabIndex = 21;
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dgvDetalleCompra.Location = new System.Drawing.Point(485, 453);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(463, 175);
            this.dgvDetalleCompra.TabIndex = 22;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Depth = 0;
            this.btnNuevoProducto.Location = new System.Drawing.Point(628, 191);
            this.btnNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Primary = true;
            this.btnNuevoProducto.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoProducto.TabIndex = 32;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(645, 154);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(216, 23);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(567, 154);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Depth = 0;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(599, 411);
            this.btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Primary = true;
            this.btnAgregarProducto.Size = new System.Drawing.Size(43, 30);
            this.btnAgregarProducto.TabIndex = 37;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnReducirProducto
            // 
            this.btnReducirProducto.Depth = 0;
            this.btnReducirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReducirProducto.Location = new System.Drawing.Point(685, 411);
            this.btnReducirProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReducirProducto.Name = "btnReducirProducto";
            this.btnReducirProducto.Primary = true;
            this.btnReducirProducto.Size = new System.Drawing.Size(43, 30);
            this.btnReducirProducto.TabIndex = 38;
            this.btnReducirProducto.Text = "-";
            this.btnReducirProducto.UseVisualStyleBackColor = true;
            this.btnReducirProducto.Click += new System.EventHandler(this.btnReducirProducto_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Depth = 0;
            this.btnQuitarProducto.Location = new System.Drawing.Point(771, 412);
            this.btnQuitarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Primary = true;
            this.btnQuitarProducto.Size = new System.Drawing.Size(65, 30);
            this.btnQuitarProducto.TabIndex = 39;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(749, 191);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Id";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(234, 594);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(96, 34);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnReducirProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dvdFormulario);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.cmbProveedore);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.mtxtFactura);
            this.MaximizeBox = false;
            this.Name = "frmAgregarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar compra";
            this.Load += new System.EventHandler(this.frmAgregarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtFactura;
        private MaterialSkin.Controls.MaterialLabel lblFactura;
        private MaterialSkin.Controls.MaterialLabel lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedore;
        private MaterialSkin.Controls.MaterialLabel lblSubtotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubtotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImpuesto;
        private MaterialSkin.Controls.MaterialLabel lblImpuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoProveedor;
        private MaterialSkin.Controls.MaterialDivider dvdFormulario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private MaterialSkin.Controls.MaterialLabel lblObservaciones;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnReducirProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuitarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}