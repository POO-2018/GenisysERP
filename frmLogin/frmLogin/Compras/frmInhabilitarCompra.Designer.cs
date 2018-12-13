namespace frmLogin.Compras
{
    partial class frmInhabilitarCompra
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
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.mtxtFactura = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInhabilitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCompras = new MaterialSkin.Controls.MaterialLabel();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.rbEstado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFactura = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblDetalleCompra = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.txtEstadoA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Enabled = false;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "Holaaaa"});
            this.cmbProveedor.Location = new System.Drawing.Point(286, 142);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(218, 26);
            this.cmbProveedor.TabIndex = 26;
            // 
            // mtxtFactura
            // 
            this.mtxtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mtxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFactura.Enabled = false;
            this.mtxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mtxtFactura.Location = new System.Drawing.Point(491, 93);
            this.mtxtFactura.Mask = "000-000-00-00000000";
            this.mtxtFactura.Name = "mtxtFactura";
            this.mtxtFactura.Size = new System.Drawing.Size(160, 24);
            this.mtxtFactura.TabIndex = 23;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(463, 190);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(159, 190);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(81, 33);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Depth = 0;
            this.btnInhabilitar.Enabled = false;
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(304, 583);
            this.btnInhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Primary = true;
            this.btnInhabilitar.Size = new System.Drawing.Size(103, 33);
            this.btnInhabilitar.TabIndex = 46;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Depth = 0;
            this.lblCompras.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCompras.Location = new System.Drawing.Point(337, 237);
            this.lblCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(70, 19);
            this.lblCompras.TabIndex = 48;
            this.lblCompras.Text = "Compras";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(16, 259);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(683, 131);
            this.dgvCompra.TabIndex = 47;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick);
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Depth = 0;
            this.rbEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbEstado.Location = new System.Drawing.Point(27, 89);
            this.rbEstado.Margin = new System.Windows.Forms.Padding(0);
            this.rbEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Ripple = true;
            this.rbEstado.Size = new System.Drawing.Size(71, 30);
            this.rbEstado.TabIndex = 49;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            this.rbEstado.CheckedChanged += new System.EventHandler(this.rbEstado_CheckedChanged);
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Depth = 0;
            this.rbFactura.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFactura.Location = new System.Drawing.Point(390, 89);
            this.rbFactura.Margin = new System.Windows.Forms.Padding(0);
            this.rbFactura.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Ripple = true;
            this.rbFactura.Size = new System.Drawing.Size(95, 30);
            this.rbFactura.TabIndex = 50;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Nº Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Depth = 0;
            this.rbProveedor.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbProveedor.Location = new System.Drawing.Point(171, 140);
            this.rbProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.rbProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Ripple = true;
            this.rbProveedor.Size = new System.Drawing.Size(92, 30);
            this.rbProveedor.TabIndex = 51;
            this.rbProveedor.TabStop = true;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            this.rbProveedor.CheckedChanged += new System.EventHandler(this.rbProveedor_CheckedChanged);
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Depth = 0;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleCompra.Location = new System.Drawing.Point(307, 406);
            this.lblDetalleCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(113, 19);
            this.lblDetalleCompra.TabIndex = 62;
            this.lblDetalleCompra.Text = "Detalle Compra";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(63, 428);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(591, 131);
            this.dgvDetalleCompra.TabIndex = 63;
            // 
            // txtEstadoA
            // 
            this.txtEstadoA.Depth = 0;
            this.txtEstadoA.Enabled = false;
            this.txtEstadoA.Hint = "";
            this.txtEstadoA.Location = new System.Drawing.Point(41, 583);
            this.txtEstadoA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoA.Name = "txtEstadoA";
            this.txtEstadoA.PasswordChar = '\0';
            this.txtEstadoA.SelectedText = "";
            this.txtEstadoA.SelectionLength = 0;
            this.txtEstadoA.SelectionStart = 0;
            this.txtEstadoA.Size = new System.Drawing.Size(222, 23);
            this.txtEstadoA.TabIndex = 67;
            this.txtEstadoA.UseSystemPasswordChar = false;
            this.txtEstadoA.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(311, 190);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(81, 33);
            this.btnNuevo.TabIndex = 68;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.cmbEstado.Location = new System.Drawing.Point(110, 91);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(218, 26);
            this.cmbEstado.TabIndex = 69;
            // 
            // frmInhabilitarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 658);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtEstadoA);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.rbProveedor);
            this.Controls.Add(this.rbFactura);
            this.Controls.Add(this.rbEstado);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.mtxtFactura);
            this.MaximizeBox = false;
            this.Name = "frmInhabilitarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inhabilitar compra";
            this.Load += new System.EventHandler(this.frmInhabilitarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.MaskedTextBox mtxtFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitar;
        private MaterialSkin.Controls.MaterialLabel lblCompras;
        private System.Windows.Forms.DataGridView dgvCompra;
        private MaterialSkin.Controls.MaterialRadioButton rbEstado;
        private MaterialSkin.Controls.MaterialRadioButton rbFactura;
        private MaterialSkin.Controls.MaterialRadioButton rbProveedor;
        private MaterialSkin.Controls.MaterialLabel lblDetalleCompra;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoA;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}