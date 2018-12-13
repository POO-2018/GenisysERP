namespace frmLogin
{
    partial class frmProveedor
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
            this.lblNombreEmpresa = new MaterialSkin.Controls.MaterialLabel();
            this.lblDireccion = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plOpciones = new System.Windows.Forms.Panel();
            this.btnInhabilitado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHabilitado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblInstrucciones = new MaterialSkin.Controls.MaterialLabel();
            this.lstInhabilitado = new System.Windows.Forms.ListBox();
            this.lstHabilitado = new System.Windows.Forms.ListBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHa_In = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Depth = 0;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(26, 105);
            this.lblNombreEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(170, 19);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Depth = 0;
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(26, 167);
            this.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(81, 19);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(26, 236);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(77, 19);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(26, 301);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(144, 19);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo Electrónico: ";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Depth = 0;
            this.txtNombreEmpresa.Hint = "";
            this.txtNombreEmpresa.Location = new System.Drawing.Point(244, 105);
            this.txtNombreEmpresa.MaxLength = 32767;
            this.txtNombreEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PasswordChar = '\0';
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.SelectionLength = 0;
            this.txtNombreEmpresa.SelectionStart = 0;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(254, 23);
            this.txtNombreEmpresa.TabIndex = 0;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            this.txtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpresa_KeyPress);
            this.txtNombreEmpresa.Leave += new System.EventHandler(this.txtNombreEmpresa_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(244, 163);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(254, 23);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(244, 299);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(254, 23);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::frmLogin.Properties.Resources.proveedores;
            this.pictureBox1.Location = new System.Drawing.Point(35, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // plOpciones
            // 
            this.plOpciones.Controls.Add(this.btnInhabilitado);
            this.plOpciones.Controls.Add(this.btnHabilitado);
            this.plOpciones.Controls.Add(this.lblInstrucciones);
            this.plOpciones.Controls.Add(this.lstInhabilitado);
            this.plOpciones.Controls.Add(this.lstHabilitado);
            this.plOpciones.Location = new System.Drawing.Point(514, 104);
            this.plOpciones.Name = "plOpciones";
            this.plOpciones.Size = new System.Drawing.Size(261, 473);
            this.plOpciones.TabIndex = 8;
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInhabilitado.Depth = 0;
            this.btnInhabilitado.Icon = null;
            this.btnInhabilitado.Location = new System.Drawing.Point(136, 31);
            this.btnInhabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Primary = true;
            this.btnInhabilitado.Size = new System.Drawing.Size(113, 36);
            this.btnInhabilitado.TabIndex = 1;
            this.btnInhabilitado.Text = "INHABILITADO";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            this.btnInhabilitado.Click += new System.EventHandler(this.btnInhabilitado_Click);
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHabilitado.Depth = 0;
            this.btnHabilitado.Icon = null;
            this.btnHabilitado.Location = new System.Drawing.Point(12, 31);
            this.btnHabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Primary = true;
            this.btnHabilitado.Size = new System.Drawing.Size(100, 36);
            this.btnHabilitado.TabIndex = 0;
            this.btnHabilitado.Text = "HABILITADO";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            this.btnHabilitado.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Depth = 0;
            this.lblInstrucciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(45, 9);
            this.lblInstrucciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(166, 19);
            this.lblInstrucciones.TabIndex = 16;
            this.lblInstrucciones.Text = "Listado de proveedores";
            // 
            // lstInhabilitado
            // 
            this.lstInhabilitado.FormattingEnabled = true;
            this.lstInhabilitado.Location = new System.Drawing.Point(12, 113);
            this.lstInhabilitado.Name = "lstInhabilitado";
            this.lstInhabilitado.Size = new System.Drawing.Size(237, 394);
            this.lstInhabilitado.TabIndex = 13;
            this.lstInhabilitado.Click += new System.EventHandler(this.lstInhabilitado_Click);
            this.lstInhabilitado.SelectedIndexChanged += new System.EventHandler(this.lstInhabilitado_SelectedIndexChanged);
            // 
            // lstHabilitado
            // 
            this.lstHabilitado.FormattingEnabled = true;
            this.lstHabilitado.Location = new System.Drawing.Point(12, 75);
            this.lstHabilitado.Name = "lstHabilitado";
            this.lstHabilitado.Size = new System.Drawing.Size(237, 381);
            this.lstHabilitado.TabIndex = 12;
            this.lstHabilitado.Click += new System.EventHandler(this.lstHabilitado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(23, 541);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(83, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(112, 541);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnHa_In
            // 
            this.btnHa_In.AutoSize = true;
            this.btnHa_In.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHa_In.Depth = 0;
            this.btnHa_In.Icon = null;
            this.btnHa_In.Location = new System.Drawing.Point(219, 541);
            this.btnHa_In.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHa_In.Name = "btnHa_In";
            this.btnHa_In.Primary = true;
            this.btnHa_In.Size = new System.Drawing.Size(184, 36);
            this.btnHa_In.TabIndex = 6;
            this.btnHa_In.Text = "HABILITAR / INHABILITAR";
            this.btnHa_In.UseVisualStyleBackColor = true;
            this.btnHa_In.Click += new System.EventHandler(this.btnHa_In_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(409, 541);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = true;
            this.btnRegresar.Size = new System.Drawing.Size(89, 36);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // mskTelefono
            // 
            this.mskTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mskTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.ForeColor = System.Drawing.SystemColors.Info;
            this.mskTelefono.Location = new System.Drawing.Point(244, 235);
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(254, 17);
            this.mskTelefono.TabIndex = 2;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnHa_In);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.plOpciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Name = "frmProveedor";
            this.Text = "                    Información de proveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plOpciones.ResumeLayout(false);
            this.plOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNombreEmpresa;
        private MaterialSkin.Controls.MaterialLabel lblDireccion;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpresa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plOpciones;
        private System.Windows.Forms.ListBox lstInhabilitado;
        private System.Windows.Forms.ListBox lstHabilitado;
        private MaterialSkin.Controls.MaterialLabel lblInstrucciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnHa_In;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegresar;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitado;
        private MaterialSkin.Controls.MaterialRaisedButton btnHabilitado;
    }
}