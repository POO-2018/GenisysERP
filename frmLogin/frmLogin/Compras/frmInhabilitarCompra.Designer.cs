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
            this.cmbProveedore = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.lblFactura = new MaterialSkin.Controls.MaterialLabel();
            this.mtxtFactura = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInhabilitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCompras = new MaterialSkin.Controls.MaterialLabel();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
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
            this.cmbProveedore.Location = new System.Drawing.Point(297, 158);
            this.cmbProveedore.Name = "cmbProveedore";
            this.cmbProveedore.Size = new System.Drawing.Size(218, 26);
            this.cmbProveedore.TabIndex = 26;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Depth = 0;
            this.lblProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedor.Location = new System.Drawing.Point(188, 161);
            this.lblProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(77, 19);
            this.lblProveedor.TabIndex = 25;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Depth = 0;
            this.lblFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFactura.Location = new System.Drawing.Point(437, 96);
            this.lblFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(78, 19);
            this.lblFactura.TabIndex = 24;
            this.lblFactura.Text = "N. Factura";
            // 
            // mtxtFactura
            // 
            this.mtxtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mtxtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mtxtFactura.Location = new System.Drawing.Point(550, 94);
            this.mtxtFactura.Mask = "000-000-00-00000000";
            this.mtxtFactura.Name = "mtxtFactura";
            this.mtxtFactura.Size = new System.Drawing.Size(160, 24);
            this.mtxtFactura.TabIndex = 23;
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
            this.cmbEstado.Location = new System.Drawing.Point(96, 92);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(218, 26);
            this.cmbEstado.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(23, 95);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 19);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(522, 212);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(152, 212);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(81, 33);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Depth = 0;
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(326, 212);
            this.btnInhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Primary = true;
            this.btnInhabilitar.Size = new System.Drawing.Size(103, 33);
            this.btnInhabilitar.TabIndex = 46;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Depth = 0;
            this.lblCompras.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCompras.Location = new System.Drawing.Point(338, 271);
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
            this.dgvCompra.Location = new System.Drawing.Point(27, 302);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(683, 175);
            this.dgvCompra.TabIndex = 47;
            // 
            // frmInhabilitarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 498);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbProveedore);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.mtxtFactura);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.MaximizeBox = false;
            this.Name = "frmInhabilitarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inhabilitar compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedore;
        private MaterialSkin.Controls.MaterialLabel lblProveedor;
        private MaterialSkin.Controls.MaterialLabel lblFactura;
        private System.Windows.Forms.MaskedTextBox mtxtFactura;
        private System.Windows.Forms.ComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitar;
        private MaterialSkin.Controls.MaterialLabel lblCompras;
        private System.Windows.Forms.DataGridView dgvCompra;
    }
}