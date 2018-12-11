namespace frmLogin.Inventario
{
    partial class frmProducto
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObservaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbIdImpuesto = new System.Windows.Forms.ComboBox();
            this.cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this.cmbIdProveedor = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numericExistencia = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numericCantidadMinima = new System.Windows.Forms.NumericUpDown();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(121, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Código producto";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 141);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Nombre";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(17, 243);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Cantidad mínima";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(17, 192);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(78, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Existencia";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(17, 345);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(115, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Precio de Venta";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(17, 294);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(127, 19);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Precio de compra";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(17, 447);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(90, 19);
            this.materialLabel9.TabIndex = 9;
            this.materialLabel9.Text = "Id Categoría";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(17, 396);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(88, 19);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Id impuesto";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(17, 549);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(108, 19);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "Observaciones";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(17, 498);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(93, 19);
            this.materialLabel12.TabIndex = 13;
            this.materialLabel12.Text = "id Proveedor";
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(160, 138);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(271, 23);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Depth = 0;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Hint = "";
            this.txtObservaciones.Location = new System.Drawing.Point(160, 550);
            this.txtObservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.Size = new System.Drawing.Size(271, 23);
            this.txtObservaciones.TabIndex = 21;
            this.txtObservaciones.UseSystemPasswordChar = false;
            // 
            // cmbIdImpuesto
            // 
            this.cmbIdImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbIdImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdImpuesto.FormattingEnabled = true;
            this.cmbIdImpuesto.Location = new System.Drawing.Point(160, 397);
            this.cmbIdImpuesto.Name = "cmbIdImpuesto";
            this.cmbIdImpuesto.Size = new System.Drawing.Size(271, 21);
            this.cmbIdImpuesto.TabIndex = 24;
            // 
            // cmbIdCategoria
            // 
            this.cmbIdCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbIdCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdCategoria.FormattingEnabled = true;
            this.cmbIdCategoria.Location = new System.Drawing.Point(160, 448);
            this.cmbIdCategoria.Name = "cmbIdCategoria";
            this.cmbIdCategoria.Size = new System.Drawing.Size(271, 21);
            this.cmbIdCategoria.TabIndex = 28;
            // 
            // cmbIdProveedor
            // 
            this.cmbIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbIdProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdProveedor.FormattingEnabled = true;
            this.cmbIdProveedor.Location = new System.Drawing.Point(160, 499);
            this.cmbIdProveedor.Name = "cmbIdProveedor";
            this.cmbIdProveedor.Size = new System.Drawing.Size(271, 21);
            this.cmbIdProveedor.TabIndex = 29;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(586, 592);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(96, 34);
            this.materialRaisedButton3.TabIndex = 40;
            this.materialRaisedButton3.Text = "Agregar";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(718, 593);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(96, 34);
            this.materialRaisedButton2.TabIndex = 41;
            this.materialRaisedButton2.Text = "Buscar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(850, 593);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(96, 35);
            this.materialRaisedButton4.TabIndex = 42;
            this.materialRaisedButton4.Text = "Actualizar";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(454, 592);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(96, 35);
            this.materialRaisedButton5.TabIndex = 43;
            this.materialRaisedButton5.Text = "Eliminar";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            // 
            // numericExistencia
            // 
            this.numericExistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericExistencia.ForeColor = System.Drawing.Color.White;
            this.numericExistencia.Location = new System.Drawing.Point(160, 191);
            this.numericExistencia.Name = "numericExistencia";
            this.numericExistencia.Size = new System.Drawing.Size(271, 20);
            this.numericExistencia.TabIndex = 47;
            this.numericExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Hint = "";
            this.txtPrecioCompra.Location = new System.Drawing.Point(160, 291);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(271, 23);
            this.txtPrecioCompra.TabIndex = 18;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Hint = "";
            this.txtPrecioVenta.Location = new System.Drawing.Point(160, 344);
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(271, 23);
            this.txtPrecioVenta.TabIndex = 19;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(160, 85);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(271, 23);
            this.materialSingleLineTextField1.TabIndex = 48;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // numericCantidadMinima
            // 
            this.numericCantidadMinima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericCantidadMinima.ForeColor = System.Drawing.Color.White;
            this.numericCantidadMinima.Location = new System.Drawing.Point(160, 241);
            this.numericCantidadMinima.Name = "numericCantidadMinima";
            this.numericCantidadMinima.Size = new System.Drawing.Size(271, 20);
            this.numericCantidadMinima.TabIndex = 49;
            this.numericCantidadMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvInventario
            // 
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(454, 85);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(494, 482);
            this.dgvInventario.TabIndex = 50;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.numericCantidadMinima);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.numericExistencia);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.cmbIdProveedor);
            this.Controls.Add(this.cmbIdCategoria);
            this.Controls.Add(this.cmbIdImpuesto);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservaciones;
        private System.Windows.Forms.ComboBox cmbIdImpuesto;
        private System.Windows.Forms.ComboBox cmbIdCategoria;
        private System.Windows.Forms.ComboBox cmbIdProveedor;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private System.Windows.Forms.NumericUpDown numericExistencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.NumericUpDown numericCantidadMinima;
        private System.Windows.Forms.DataGridView dgvInventario;
    }
}