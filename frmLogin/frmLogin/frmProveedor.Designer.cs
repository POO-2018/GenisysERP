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
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plOpciones = new System.Windows.Forms.Panel();
            this.btnInhabilitado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHabilitado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHabilitarInhabilitar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lstHabilitado = new System.Windows.Forms.ListBox();
            this.lstInhabilitado = new System.Windows.Forms.ListBox();
            this.lblInstrucciones = new MaterialSkin.Controls.MaterialLabel();
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
            this.lblNombreEmpresa.Location = new System.Drawing.Point(37, 101);
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
            this.lblDireccion.Location = new System.Drawing.Point(37, 163);
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
            this.lblTelefono.Location = new System.Drawing.Point(37, 232);
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
            this.lblCorreo.Location = new System.Drawing.Point(37, 297);
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
            this.txtNombreEmpresa.Location = new System.Drawing.Point(255, 101);
            this.txtNombreEmpresa.MaxLength = 32767;
            this.txtNombreEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PasswordChar = '\0';
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.SelectionLength = 0;
            this.txtNombreEmpresa.SelectionStart = 0;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(254, 23);
            this.txtNombreEmpresa.TabIndex = 4;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(255, 159);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(254, 23);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTelefono.Location = new System.Drawing.Point(255, 230);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(254, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(255, 295);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(254, 23);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.UseSystemPasswordChar = false;
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
            this.plOpciones.Controls.Add(this.lblInstrucciones);
            this.plOpciones.Controls.Add(this.lstInhabilitado);
            this.plOpciones.Controls.Add(this.lstHabilitado);
            this.plOpciones.Controls.Add(this.btnInhabilitado);
            this.plOpciones.Controls.Add(this.btnHabilitado);
            this.plOpciones.Location = new System.Drawing.Point(527, 78);
            this.plOpciones.Name = "plOpciones";
            this.plOpciones.Size = new System.Drawing.Size(261, 360);
            this.plOpciones.TabIndex = 9;
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInhabilitado.Depth = 0;
            this.btnInhabilitado.Icon = null;
            this.btnInhabilitado.Location = new System.Drawing.Point(123, 30);
            this.btnInhabilitado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInhabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Primary = false;
            this.btnInhabilitado.Size = new System.Drawing.Size(122, 36);
            this.btnInhabilitado.TabIndex = 11;
            this.btnInhabilitado.Text = "INHABILITADOS";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHabilitado.Depth = 0;
            this.btnHabilitado.Icon = null;
            this.btnHabilitado.Location = new System.Drawing.Point(8, 30);
            this.btnHabilitado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Primary = false;
            this.btnHabilitado.Size = new System.Drawing.Size(108, 36);
            this.btnHabilitado.TabIndex = 0;
            this.btnHabilitado.Text = "HABILITADOS";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(32, 399);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(83, 36);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(123, 399);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnHabilitarInhabilitar
            // 
            this.btnHabilitarInhabilitar.AutoSize = true;
            this.btnHabilitarInhabilitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHabilitarInhabilitar.Depth = 0;
            this.btnHabilitarInhabilitar.Icon = null;
            this.btnHabilitarInhabilitar.Location = new System.Drawing.Point(234, 399);
            this.btnHabilitarInhabilitar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHabilitarInhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitarInhabilitar.Name = "btnHabilitarInhabilitar";
            this.btnHabilitarInhabilitar.Primary = false;
            this.btnHabilitarInhabilitar.Size = new System.Drawing.Size(178, 36);
            this.btnHabilitarInhabilitar.TabIndex = 14;
            this.btnHabilitarInhabilitar.Text = "HABILITAR/INHABILITAR";
            this.btnHabilitarInhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(420, 399);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(89, 36);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lstHabilitado
            // 
            this.lstHabilitado.FormattingEnabled = true;
            this.lstHabilitado.Location = new System.Drawing.Point(12, 75);
            this.lstHabilitado.Name = "lstHabilitado";
            this.lstHabilitado.Size = new System.Drawing.Size(237, 277);
            this.lstHabilitado.TabIndex = 12;
            // 
            // lstInhabilitado
            // 
            this.lstInhabilitado.FormattingEnabled = true;
            this.lstInhabilitado.Location = new System.Drawing.Point(12, 75);
            this.lstInhabilitado.Name = "lstInhabilitado";
            this.lstInhabilitado.Size = new System.Drawing.Size(237, 277);
            this.lstInhabilitado.TabIndex = 13;
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
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnHabilitarInhabilitar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.plOpciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Name = "frmProveedor";
            this.Text = "                    Información de Proveedor";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plOpciones;
        private MaterialSkin.Controls.MaterialFlatButton btnInhabilitado;
        private MaterialSkin.Controls.MaterialFlatButton btnHabilitado;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnHabilitarInhabilitar;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private System.Windows.Forms.ListBox lstInhabilitado;
        private System.Windows.Forms.ListBox lstHabilitado;
        private MaterialSkin.Controls.MaterialLabel lblInstrucciones;
    }
}