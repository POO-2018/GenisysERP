namespace frmLogin.Compras
{
    partial class frmBuscarCompras
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
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.mtxtFactura = new System.Windows.Forms.MaskedTextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCompras = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetalleCompra = new MaterialSkin.Controls.MaterialLabel();
            this.rbEstado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFactura = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
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
            this.cmbEstado.Location = new System.Drawing.Point(116, 85);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(218, 26);
            this.cmbEstado.TabIndex = 16;
            // 
            // mtxtFactura
            // 
            this.mtxtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mtxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFactura.Enabled = false;
            this.mtxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mtxtFactura.Location = new System.Drawing.Point(488, 87);
            this.mtxtFactura.Mask = "000-000-00-00000000";
            this.mtxtFactura.Name = "mtxtFactura";
            this.mtxtFactura.Size = new System.Drawing.Size(218, 24);
            this.mtxtFactura.TabIndex = 17;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Enabled = false;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(278, 143);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(218, 26);
            this.cmbProveedor.TabIndex = 20;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(25, 255);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(683, 175);
            this.dgvCompra.TabIndex = 22;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(175, 187);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(81, 33);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(67, 471);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(591, 175);
            this.dgvDetalleCompra.TabIndex = 42;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(479, 187);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Depth = 0;
            this.lblCompras.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCompras.Location = new System.Drawing.Point(346, 233);
            this.lblCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(70, 19);
            this.lblCompras.TabIndex = 44;
            this.lblCompras.Text = "Compras";
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Depth = 0;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleCompra.Location = new System.Drawing.Point(314, 449);
            this.lblDetalleCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(113, 19);
            this.lblDetalleCompra.TabIndex = 45;
            this.lblDetalleCompra.Text = "Detalle Compra";
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Depth = 0;
            this.rbEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbEstado.Location = new System.Drawing.Point(32, 85);
            this.rbEstado.Margin = new System.Windows.Forms.Padding(0);
            this.rbEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Ripple = true;
            this.rbEstado.Size = new System.Drawing.Size(71, 30);
            this.rbEstado.TabIndex = 51;
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
            this.rbFactura.Location = new System.Drawing.Point(392, 85);
            this.rbFactura.Margin = new System.Windows.Forms.Padding(0);
            this.rbFactura.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Ripple = true;
            this.rbFactura.Size = new System.Drawing.Size(89, 30);
            this.rbFactura.TabIndex = 52;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "N.Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Depth = 0;
            this.rbProveedor.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbProveedor.Location = new System.Drawing.Point(175, 142);
            this.rbProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.rbProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Ripple = true;
            this.rbProveedor.Size = new System.Drawing.Size(92, 30);
            this.rbProveedor.TabIndex = 53;
            this.rbProveedor.TabStop = true;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            this.rbProveedor.CheckedChanged += new System.EventHandler(this.rbProveedor_CheckedChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(327, 187);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(81, 33);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Depth = 0;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(577, 139);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Primary = true;
            this.btnVolver.Size = new System.Drawing.Size(81, 33);
            this.btnVolver.TabIndex = 55;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // frmBuscarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 658);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.rbProveedor);
            this.Controls.Add(this.rbFactura);
            this.Controls.Add(this.rbEstado);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.mtxtFactura);
            this.Controls.Add(this.cmbEstado);
            this.MaximizeBox = false;
            this.Name = "frmBuscarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmBuscarCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.MaskedTextBox mtxtFactura;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.DataGridView dgvCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialLabel lblCompras;
        private MaterialSkin.Controls.MaterialLabel lblDetalleCompra;
        private MaterialSkin.Controls.MaterialRadioButton rbEstado;
        private MaterialSkin.Controls.MaterialRadioButton rbFactura;
        private MaterialSkin.Controls.MaterialRadioButton rbProveedor;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
    }
}