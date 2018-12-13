namespace frmLogin.Compras
{
    partial class frmActualizarCompra
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.txtSubTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblObservaciones = new MaterialSkin.Controls.MaterialLabel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblImpuesto = new MaterialSkin.Controls.MaterialLabel();
            this.lblSubtotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(571, 437);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(98, 40);
            this.materialRaisedButton1.TabIndex = 39;
            this.materialRaisedButton1.Text = "Quitar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton2.Location = new System.Drawing.Point(571, 292);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(98, 52);
            this.materialRaisedButton2.TabIndex = 37;
            this.materialRaisedButton2.Text = "+";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton3.Location = new System.Drawing.Point(571, 368);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(98, 47);
            this.materialRaisedButton3.TabIndex = 38;
            this.materialRaisedButton3.Text = "-";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(51, 302);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(492, 175);
            this.dgvProductos.TabIndex = 40;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(571, 121);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(98, 59);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Id";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 40;
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "IdCompra";
            this.IdCompra.Name = "IdCompra";
            // 
            // idInventario
            // 
            this.idInventario.HeaderText = "Inventario";
            this.idInventario.Name = "idInventario";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 170;
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle,
            this.compra,
            this.Inventario,
            this.nombreI,
            this.PrecioU,
            this.cantidadI,
            this.Total});
            this.dgvDetalleCompra.Location = new System.Drawing.Point(51, 121);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(492, 150);
            this.dgvDetalleCompra.TabIndex = 43;
            this.dgvDetalleCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellClick);
            this.dgvDetalleCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellEndEdit);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Depth = 0;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Hint = "0.00";
            this.txtSubTotal.Location = new System.Drawing.Point(491, 503);
            this.txtSubTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.Size = new System.Drawing.Size(146, 23);
            this.txtSubTotal.TabIndex = 51;
            this.txtSubTotal.UseSystemPasswordChar = false;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Depth = 0;
            this.lblObservaciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObservaciones.Location = new System.Drawing.Point(47, 503);
            this.lblObservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(108, 19);
            this.lblObservaciones.TabIndex = 50;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtObservaciones.Location = new System.Drawing.Point(51, 538);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(304, 78);
            this.txtObservaciones.TabIndex = 49;
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Hint = "0.00";
            this.txtTotal.Location = new System.Drawing.Point(491, 617);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(146, 23);
            this.txtTotal.TabIndex = 48;
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(384, 620);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 19);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "Total";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Depth = 0;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Hint = "0.00";
            this.txtImpuesto.Location = new System.Drawing.Point(491, 559);
            this.txtImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.PasswordChar = '\0';
            this.txtImpuesto.SelectedText = "";
            this.txtImpuesto.SelectionLength = 0;
            this.txtImpuesto.SelectionStart = 0;
            this.txtImpuesto.Size = new System.Drawing.Size(146, 23);
            this.txtImpuesto.TabIndex = 46;
            this.txtImpuesto.UseSystemPasswordChar = false;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Depth = 0;
            this.lblImpuesto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblImpuesto.Location = new System.Drawing.Point(374, 563);
            this.lblImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(72, 19);
            this.lblImpuesto.TabIndex = 45;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Depth = 0;
            this.lblSubtotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Location = new System.Drawing.Point(375, 503);
            this.lblSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 19);
            this.lblSubtotal.TabIndex = 44;
            this.lblSubtotal.Text = "SubTotal";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(571, 199);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(98, 59);
            this.btnActualizar.TabIndex = 52;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 40;
            // 
            // compra
            // 
            this.compra.HeaderText = "Compra";
            this.compra.Name = "compra";
            this.compra.ReadOnly = true;
            this.compra.Width = 40;
            // 
            // Inventario
            // 
            this.Inventario.HeaderText = "Producto";
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            this.Inventario.Width = 40;
            // 
            // nombreI
            // 
            this.nombreI.HeaderText = "Nombre";
            this.nombreI.Name = "nombreI";
            this.nombreI.ReadOnly = true;
            this.nombreI.Width = 200;
            // 
            // PrecioU
            // 
            this.PrecioU.HeaderText = "Precio";
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.ReadOnly = true;
            this.PrecioU.Width = 60;
            // 
            // cantidadI
            // 
            this.cantidadI.HeaderText = "Cantidad";
            this.cantidadI.Name = "cantidadI";
            this.cantidadI.ReadOnly = true;
            this.cantidadI.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "SubTotal";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // frmActualizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 658);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton3);
            this.Name = "frmActualizarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.frmActualizarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubTotal;
        private MaterialSkin.Controls.MaterialLabel lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImpuesto;
        private MaterialSkin.Controls.MaterialLabel lblImpuesto;
        private MaterialSkin.Controls.MaterialLabel lblSubtotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}