namespace frmLogin
{
    partial class frmMenuPrincipal
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
            this.tbMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnContactos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProveedores = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInhabilitarCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBusquedaCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregarCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnInventario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnImpuestos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCategorias = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEmpleados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tsMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tabPage1);
            this.tbMenu.Controls.Add(this.tabPage2);
            this.tbMenu.Controls.Add(this.tabPage3);
            this.tbMenu.Controls.Add(this.tabPage4);
            this.tbMenu.Depth = 0;
            this.tbMenu.Location = new System.Drawing.Point(12, 119);
            this.tbMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(617, 274);
            this.tbMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnContactos);
            this.tabPage1.Controls.Add(this.btnProveedores);
            this.tabPage1.Controls.Add(this.btnClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnContactos
            // 
            this.btnContactos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContactos.Depth = 0;
            this.btnContactos.Location = new System.Drawing.Point(422, 93);
            this.btnContactos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Primary = true;
            this.btnContactos.Size = new System.Drawing.Size(120, 50);
            this.btnContactos.TabIndex = 2;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProveedores.Depth = 0;
            this.btnProveedores.Location = new System.Drawing.Point(238, 93);
            this.btnProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Primary = true;
            this.btnProveedores.Size = new System.Drawing.Size(120, 50);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Depth = 0;
            this.btnClientes.Location = new System.Drawing.Point(54, 93);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Primary = true;
            this.btnClientes.Size = new System.Drawing.Size(120, 50);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes\r\n";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInhabilitarCompra);
            this.tabPage2.Controls.Add(this.btnBusquedaCompra);
            this.tabPage2.Controls.Add(this.btnActualizarCompra);
            this.tabPage2.Controls.Add(this.btnAgregarCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarCompra
            // 
            this.btnInhabilitarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInhabilitarCompra.Depth = 0;
            this.btnInhabilitarCompra.Location = new System.Drawing.Point(354, 140);
            this.btnInhabilitarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitarCompra.Name = "btnInhabilitarCompra";
            this.btnInhabilitarCompra.Primary = true;
            this.btnInhabilitarCompra.Size = new System.Drawing.Size(120, 50);
            this.btnInhabilitarCompra.TabIndex = 4;
            this.btnInhabilitarCompra.Text = "Inhabilitar";
            this.btnInhabilitarCompra.UseVisualStyleBackColor = true;
            this.btnInhabilitarCompra.Click += new System.EventHandler(this.btnInhabilitarCompra_Click);
            // 
            // btnBusquedaCompra
            // 
            this.btnBusquedaCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBusquedaCompra.Depth = 0;
            this.btnBusquedaCompra.Location = new System.Drawing.Point(122, 140);
            this.btnBusquedaCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBusquedaCompra.Name = "btnBusquedaCompra";
            this.btnBusquedaCompra.Primary = true;
            this.btnBusquedaCompra.Size = new System.Drawing.Size(120, 50);
            this.btnBusquedaCompra.TabIndex = 3;
            this.btnBusquedaCompra.Text = "Busquedas";
            this.btnBusquedaCompra.UseVisualStyleBackColor = true;
            this.btnBusquedaCompra.Click += new System.EventHandler(this.btnBusquedaCompra_Click);
            // 
            // btnActualizarCompra
            // 
            this.btnActualizarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCompra.Depth = 0;
            this.btnActualizarCompra.Location = new System.Drawing.Point(354, 42);
            this.btnActualizarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCompra.Name = "btnActualizarCompra";
            this.btnActualizarCompra.Primary = true;
            this.btnActualizarCompra.Size = new System.Drawing.Size(120, 50);
            this.btnActualizarCompra.TabIndex = 2;
            this.btnActualizarCompra.Text = "Actualizar compra";
            this.btnActualizarCompra.UseVisualStyleBackColor = true;
            this.btnActualizarCompra.Click += new System.EventHandler(this.btnActualizarCompra_Click);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCompra.Depth = 0;
            this.btnAgregarCompra.Location = new System.Drawing.Point(122, 42);
            this.btnAgregarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Primary = true;
            this.btnAgregarCompra.Size = new System.Drawing.Size(120, 50);
            this.btnAgregarCompra.TabIndex = 1;
            this.btnAgregarCompra.Text = "Agregar compras";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInventario);
            this.tabPage3.Controls.Add(this.btnImpuestos);
            this.tabPage3.Controls.Add(this.btnCategorias);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(609, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventario.Depth = 0;
            this.btnInventario.Location = new System.Drawing.Point(236, 93);
            this.btnInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Primary = true;
            this.btnInventario.Size = new System.Drawing.Size(120, 50);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnImpuestos
            // 
            this.btnImpuestos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImpuestos.Depth = 0;
            this.btnImpuestos.Location = new System.Drawing.Point(419, 93);
            this.btnImpuestos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImpuestos.Name = "btnImpuestos";
            this.btnImpuestos.Primary = true;
            this.btnImpuestos.Size = new System.Drawing.Size(120, 50);
            this.btnImpuestos.TabIndex = 6;
            this.btnImpuestos.Text = "Impuestos";
            this.btnImpuestos.UseVisualStyleBackColor = true;
            this.btnImpuestos.Click += new System.EventHandler(this.btnImpuestos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategorias.Depth = 0;
            this.btnCategorias.Location = new System.Drawing.Point(53, 93);
            this.btnCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Primary = true;
            this.btnCategorias.Size = new System.Drawing.Size(120, 50);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnUsuario);
            this.tabPage4.Controls.Add(this.btnEmpleados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(609, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Empleados y seguridad";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsuario.Depth = 0;
            this.btnUsuario.Location = new System.Drawing.Point(113, 83);
            this.btnUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Primary = true;
            this.btnUsuario.Size = new System.Drawing.Size(120, 50);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.materialRaisedButton12_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleados.Depth = 0;
            this.btnEmpleados.Location = new System.Drawing.Point(373, 83);
            this.btnEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Primary = true;
            this.btnEmpleados.Size = new System.Drawing.Size(120, 50);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.BaseTabControl = this.tbMenu;
            this.tsMenu.Depth = 0;
            this.tsMenu.Location = new System.Drawing.Point(12, 76);
            this.tsMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(609, 26);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "materialTabSelector1";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(522, 399);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(99, 38);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Salir\r\n";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 449);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.tbMenu);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Sistema Genisys ERP";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.tbMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbMenu;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitarCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnBusquedaCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarCompra;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton btnInventario;
        private MaterialSkin.Controls.MaterialRaisedButton btnImpuestos;
        private MaterialSkin.Controls.MaterialRaisedButton btnCategorias;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmpleados;
        private MaterialSkin.Controls.MaterialTabSelector tsMenu;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton btnContactos;
        private MaterialSkin.Controls.MaterialRaisedButton btnProveedores;
        private MaterialSkin.Controls.MaterialRaisedButton btnClientes;
    }
}