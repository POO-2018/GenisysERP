namespace frmLogin.Compras
{
    partial class frmActualizarEstadoCompra
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
            this.rbEstado = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.rbProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.rbFactura = new MaterialSkin.Controls.MaterialRadioButton();
            this.mtxtFactura = new System.Windows.Forms.MaskedTextBox();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDetalleCompra = new MaterialSkin.Controls.MaterialLabel();
            this.lblCompras = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mtxtNuevaFactura = new System.Windows.Forms.MaskedTextBox();
            this.txtEstadoA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEstadoP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Depth = 0;
            this.rbEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbEstado.Location = new System.Drawing.Point(16, 78);
            this.rbEstado.Margin = new System.Windows.Forms.Padding(0);
            this.rbEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Ripple = true;
            this.rbEstado.Size = new System.Drawing.Size(71, 30);
            this.rbEstado.TabIndex = 0;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            this.rbEstado.CheckedChanged += new System.EventHandler(this.rbEstado_CheckedChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Cotización",
            "Orden de Compra",
            "Compra"});
            this.cmbEstado.Location = new System.Drawing.Point(105, 79);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(218, 26);
            this.cmbEstado.TabIndex = 17;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Depth = 0;
            this.rbProveedor.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbProveedor.Location = new System.Drawing.Point(173, 127);
            this.rbProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.rbProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Ripple = true;
            this.rbProveedor.Size = new System.Drawing.Size(92, 30);
            this.rbProveedor.TabIndex = 18;
            this.rbProveedor.TabStop = true;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            this.rbProveedor.CheckedChanged += new System.EventHandler(this.rbProveedor_CheckedChanged);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Enabled = false;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(286, 129);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(218, 26);
            this.cmbProveedor.TabIndex = 21;
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Depth = 0;
            this.rbFactura.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFactura.Location = new System.Drawing.Point(378, 77);
            this.rbFactura.Margin = new System.Windows.Forms.Padding(0);
            this.rbFactura.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Ripple = true;
            this.rbFactura.Size = new System.Drawing.Size(95, 30);
            this.rbFactura.TabIndex = 22;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Nº Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // mtxtFactura
            // 
            this.mtxtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mtxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFactura.Enabled = false;
            this.mtxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mtxtFactura.Location = new System.Drawing.Point(491, 81);
            this.mtxtFactura.Mask = "000-000-00-00000000";
            this.mtxtFactura.Name = "mtxtFactura";
            this.mtxtFactura.Size = new System.Drawing.Size(218, 24);
            this.mtxtFactura.TabIndex = 23;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(311, 171);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(81, 33);
            this.btnNuevo.TabIndex = 57;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(463, 171);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(159, 171);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(81, 33);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Depth = 0;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleCompra.Location = new System.Drawing.Point(307, 372);
            this.lblDetalleCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(113, 19);
            this.lblDetalleCompra.TabIndex = 61;
            this.lblDetalleCompra.Text = "Detalle Compra";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Depth = 0;
            this.lblCompras.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCompras.Location = new System.Drawing.Point(337, 214);
            this.lblCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(70, 19);
            this.lblCompras.TabIndex = 60;
            this.lblCompras.Text = "Compras";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(63, 394);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(591, 131);
            this.dgvDetalleCompra.TabIndex = 59;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(16, 236);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(683, 131);
            this.dgvCompra.TabIndex = 58;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(312, 619);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(96, 33);
            this.btnActualizar.TabIndex = 62;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.rbActualizar_Click);
            // 
            // mtxtNuevaFactura
            // 
            this.mtxtNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mtxtNuevaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNuevaFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mtxtNuevaFactura.Location = new System.Drawing.Point(255, 587);
            this.mtxtNuevaFactura.Mask = "000-000-00-00000000";
            this.mtxtNuevaFactura.Name = "mtxtNuevaFactura";
            this.mtxtNuevaFactura.Size = new System.Drawing.Size(218, 24);
            this.mtxtNuevaFactura.TabIndex = 65;
            this.mtxtNuevaFactura.Visible = false;
            // 
            // txtEstadoA
            // 
            this.txtEstadoA.Depth = 0;
            this.txtEstadoA.Enabled = false;
            this.txtEstadoA.Hint = "";
            this.txtEstadoA.Location = new System.Drawing.Point(88, 547);
            this.txtEstadoA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoA.Name = "txtEstadoA";
            this.txtEstadoA.PasswordChar = '\0';
            this.txtEstadoA.SelectedText = "";
            this.txtEstadoA.SelectionLength = 0;
            this.txtEstadoA.SelectionStart = 0;
            this.txtEstadoA.Size = new System.Drawing.Size(222, 23);
            this.txtEstadoA.TabIndex = 66;
            this.txtEstadoA.UseSystemPasswordChar = false;
            // 
            // txtEstadoP
            // 
            this.txtEstadoP.Depth = 0;
            this.txtEstadoP.Enabled = false;
            this.txtEstadoP.Hint = "";
            this.txtEstadoP.Location = new System.Drawing.Point(418, 547);
            this.txtEstadoP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoP.Name = "txtEstadoP";
            this.txtEstadoP.PasswordChar = '\0';
            this.txtEstadoP.SelectedText = "";
            this.txtEstadoP.SelectionLength = 0;
            this.txtEstadoP.SelectionStart = 0;
            this.txtEstadoP.Size = new System.Drawing.Size(222, 23);
            this.txtEstadoP.TabIndex = 67;
            this.txtEstadoP.UseSystemPasswordChar = false;
            // 
            // frmActualizarEstadoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 658);
            this.Controls.Add(this.txtEstadoP);
            this.Controls.Add(this.txtEstadoA);
            this.Controls.Add(this.mtxtNuevaFactura);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mtxtFactura);
            this.Controls.Add(this.rbFactura);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.rbProveedor);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.rbEstado);
            this.Name = "frmActualizarEstadoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Estado";
            this.Load += new System.EventHandler(this.frmActualizarEstadoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton rbEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialRadioButton rbProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private MaterialSkin.Controls.MaterialRadioButton rbFactura;
        private System.Windows.Forms.MaskedTextBox mtxtFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialLabel lblDetalleCompra;
        private MaterialSkin.Controls.MaterialLabel lblCompras;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.DataGridView dgvCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.MaskedTextBox mtxtNuevaFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoA;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoP;
    }
}