namespace frmLogin
{
    partial class frmContacto
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
            this.lblProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.lblIdContacto = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.lblDireccion = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellidos = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombres = new MaterialSkin.Controls.MaterialLabel();
            this.lblCargo = new MaterialSkin.Controls.MaterialLabel();
            this.lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCargo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lstHabilitado = new System.Windows.Forms.ListBox();
            this.pldatos = new System.Windows.Forms.Panel();
            this.btnInhabilitados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHabilitados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lstInhabilitado = new System.Windows.Forms.ListBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInhabilitarHabilitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mskIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.pldatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Depth = 0;
            this.lblProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedor.Location = new System.Drawing.Point(41, 475);
            this.lblProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(96, 24);
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblIdContacto
            // 
            this.lblIdContacto.AutoSize = true;
            this.lblIdContacto.Depth = 0;
            this.lblIdContacto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdContacto.Location = new System.Drawing.Point(41, 136);
            this.lblIdContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdContacto.Name = "lblIdContacto";
            this.lblIdContacto.Size = new System.Drawing.Size(103, 24);
            this.lblIdContacto.TabIndex = 0;
            this.lblIdContacto.Text = "IDContacto";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(41, 327);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Depth = 0;
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(41, 279);
            this.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 24);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Depth = 0;
            this.lblApellidos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidos.Location = new System.Drawing.Point(41, 232);
            this.lblApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(90, 24);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Depth = 0;
            this.lblNombres.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombres.Location = new System.Drawing.Point(41, 184);
            this.lblNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(89, 24);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Depth = 0;
            this.lblCargo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCargo.Location = new System.Drawing.Point(41, 426);
            this.lblCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 24);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(41, 372);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 24);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // txtNombres
            // 
            this.txtNombres.Depth = 0;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Hint = "";
            this.txtNombres.Location = new System.Drawing.Point(195, 180);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.Size = new System.Drawing.Size(268, 28);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.UseSystemPasswordChar = false;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(195, 228);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(268, 28);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.UseSystemPasswordChar = false;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(195, 275);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(268, 28);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(195, 368);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(268, 28);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtCargo
            // 
            this.txtCargo.Depth = 0;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Hint = "";
            this.txtCargo.Location = new System.Drawing.Point(195, 422);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.SelectedText = "";
            this.txtCargo.SelectionLength = 0;
            this.txtCargo.SelectionStart = 0;
            this.txtCargo.Size = new System.Drawing.Size(268, 28);
            this.txtCargo.TabIndex = 6;
            this.txtCargo.UseSystemPasswordChar = false;
            // 
            // mskTelefono
            // 
            this.mskTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mskTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.ForeColor = System.Drawing.Color.White;
            this.mskTelefono.Location = new System.Drawing.Point(195, 329);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(268, 21);
            this.mskTelefono.TabIndex = 4;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbProveedor.ForeColor = System.Drawing.Color.White;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(195, 475);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(269, 24);
            this.cmbProveedor.TabIndex = 7;
            // 
            // lstHabilitado
            // 
            this.lstHabilitado.FormattingEnabled = true;
            this.lstHabilitado.ItemHeight = 16;
            this.lstHabilitado.Location = new System.Drawing.Point(45, 19);
            this.lstHabilitado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHabilitado.Name = "lstHabilitado";
            this.lstHabilitado.Size = new System.Drawing.Size(254, 260);
            this.lstHabilitado.TabIndex = 17;
            this.lstHabilitado.Click += new System.EventHandler(this.lstHabilitado_Click);
            // 
            // pldatos
            // 
            this.pldatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pldatos.Controls.Add(this.btnInhabilitados);
            this.pldatos.Controls.Add(this.btnHabilitados);
            this.pldatos.Controls.Add(this.lstInhabilitado);
            this.pldatos.Controls.Add(this.lstHabilitado);
            this.pldatos.Location = new System.Drawing.Point(535, 126);
            this.pldatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pldatos.Name = "pldatos";
            this.pldatos.Size = new System.Drawing.Size(344, 364);
            this.pldatos.TabIndex = 12;
            // 
            // btnInhabilitados
            // 
            this.btnInhabilitados.Depth = 0;
            this.btnInhabilitados.Location = new System.Drawing.Point(173, 303);
            this.btnInhabilitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInhabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitados.Name = "btnInhabilitados";
            this.btnInhabilitados.Primary = true;
            this.btnInhabilitados.Size = new System.Drawing.Size(141, 39);
            this.btnInhabilitados.TabIndex = 24;
            this.btnInhabilitados.Text = "INHABILITADOS";
            this.btnInhabilitados.UseVisualStyleBackColor = true;
            this.btnInhabilitados.Click += new System.EventHandler(this.btnInhabilitados_Click);
            // 
            // btnHabilitados
            // 
            this.btnHabilitados.Depth = 0;
            this.btnHabilitados.Location = new System.Drawing.Point(33, 303);
            this.btnHabilitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitados.Name = "btnHabilitados";
            this.btnHabilitados.Primary = true;
            this.btnHabilitados.Size = new System.Drawing.Size(134, 39);
            this.btnHabilitados.TabIndex = 23;
            this.btnHabilitados.Text = "HABILITADOS";
            this.btnHabilitados.UseVisualStyleBackColor = true;
            this.btnHabilitados.Click += new System.EventHandler(this.btnHabilitados_Click);
            // 
            // lstInhabilitado
            // 
            this.lstInhabilitado.FormattingEnabled = true;
            this.lstInhabilitado.ItemHeight = 16;
            this.lstInhabilitado.Location = new System.Drawing.Point(45, 19);
            this.lstInhabilitado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstInhabilitado.Name = "lstInhabilitado";
            this.lstInhabilitado.Size = new System.Drawing.Size(254, 260);
            this.lstInhabilitado.TabIndex = 18;
            this.lstInhabilitado.Click += new System.EventHandler(this.lstInhabilitado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(64, 556);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(98, 39);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnInhabilitarHabilitar
            // 
            this.btnInhabilitarHabilitar.Depth = 0;
            this.btnInhabilitarHabilitar.Location = new System.Drawing.Point(380, 556);
            this.btnInhabilitarHabilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInhabilitarHabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitarHabilitar.Name = "btnInhabilitarHabilitar";
            this.btnInhabilitarHabilitar.Primary = true;
            this.btnInhabilitarHabilitar.Size = new System.Drawing.Size(219, 39);
            this.btnInhabilitarHabilitar.TabIndex = 10;
            this.btnInhabilitarHabilitar.Text = "INHABILITAR/HABILITAR";
            this.btnInhabilitarHabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitarHabilitar.Click += new System.EventHandler(this.btnInhabilitarHabilitar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(216, 556);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(119, 39);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(741, 556);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = true;
            this.btnRegresar.Size = new System.Drawing.Size(98, 39);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // mskIdentidad
            // 
            this.mskIdentidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mskIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIdentidad.ForeColor = System.Drawing.Color.White;
            this.mskIdentidad.Location = new System.Drawing.Point(195, 136);
            this.mskIdentidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskIdentidad.Mask = "0000-0000-00000";
            this.mskIdentidad.Name = "mskIdentidad";
            this.mskIdentidad.Size = new System.Drawing.Size(268, 21);
            this.mskIdentidad.TabIndex = 0;
            this.mskIdentidad.Leave += new System.EventHandler(this.mskIdentidad_Leave);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.mskIdentidad);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInhabilitarHabilitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pldatos);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblIdContacto);
            this.Controls.Add(this.lblProveedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de contacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
            this.pldatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblProveedor;
        private MaterialSkin.Controls.MaterialLabel lblIdContacto;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblDireccion;
        private MaterialSkin.Controls.MaterialLabel lblApellidos;
        private MaterialSkin.Controls.MaterialLabel lblNombres;
        private MaterialSkin.Controls.MaterialLabel lblCargo;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCargo;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ListBox lstHabilitado;
        private System.Windows.Forms.Panel pldatos;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitados;
        private MaterialSkin.Controls.MaterialRaisedButton btnHabilitados;
        private System.Windows.Forms.ListBox lstInhabilitado;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitarHabilitar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegresar;
        private System.Windows.Forms.MaskedTextBox mskIdentidad;
    }
}