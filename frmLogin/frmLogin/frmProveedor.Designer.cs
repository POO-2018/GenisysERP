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
            this.lblInstrucciones = new MaterialSkin.Controls.MaterialLabel();
            this.lstInhabilitado = new System.Windows.Forms.ListBox();
            this.lstHabilitado = new System.Windows.Forms.ListBox();
            this.btnInhabilitado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHabilitado = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHabilitarInhabilitar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.lblNombreEmpresa.Location = new System.Drawing.Point(49, 124);
            this.lblNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(215, 24);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Depth = 0;
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(49, 201);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 24);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(49, 286);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 24);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(49, 366);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(176, 24);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo Electrónico: ";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Depth = 0;
            this.txtNombreEmpresa.Hint = "";
            this.txtNombreEmpresa.Location = new System.Drawing.Point(340, 124);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreEmpresa.MaxLength = 32767;
            this.txtNombreEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PasswordChar = '\0';
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.SelectionLength = 0;
            this.txtNombreEmpresa.SelectionStart = 0;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(339, 28);
            this.txtNombreEmpresa.TabIndex = 4;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(340, 196);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(339, 28);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTelefono.Location = new System.Drawing.Point(340, 283);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(339, 28);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(340, 363);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(339, 28);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::frmLogin.Properties.Resources.proveedores;
            this.pictureBox1.Location = new System.Drawing.Point(47, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
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
            this.plOpciones.Location = new System.Drawing.Point(703, 96);
            this.plOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plOpciones.Name = "plOpciones";
            this.plOpciones.Size = new System.Drawing.Size(348, 443);
            this.plOpciones.TabIndex = 9;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Depth = 0;
            this.lblInstrucciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(60, 11);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(209, 24);
            this.lblInstrucciones.TabIndex = 16;
            this.lblInstrucciones.Text = "Listado de proveedores";
            // 
            // lstInhabilitado
            // 
            this.lstInhabilitado.FormattingEnabled = true;
            this.lstInhabilitado.ItemHeight = 16;
            this.lstInhabilitado.Location = new System.Drawing.Point(16, 105);
            this.lstInhabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstInhabilitado.Name = "lstInhabilitado";
            this.lstInhabilitado.Size = new System.Drawing.Size(315, 340);
            this.lstInhabilitado.TabIndex = 13;
            // 
            // lstHabilitado
            // 
            this.lstHabilitado.FormattingEnabled = true;
            this.lstHabilitado.ItemHeight = 16;
            this.lstHabilitado.Location = new System.Drawing.Point(16, 92);
            this.lstHabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHabilitado.Name = "lstHabilitado";
            this.lstHabilitado.Size = new System.Drawing.Size(315, 340);
            this.lstHabilitado.TabIndex = 12;
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInhabilitado.Depth = 0;
            this.btnInhabilitado.Icon = null;
            this.btnInhabilitado.Location = new System.Drawing.Point(164, 37);
            this.btnInhabilitado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnInhabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Primary = false;
            this.btnInhabilitado.Size = new System.Drawing.Size(148, 36);
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
            this.btnHabilitado.Location = new System.Drawing.Point(11, 37);
            this.btnHabilitado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Primary = false;
            this.btnHabilitado.Size = new System.Drawing.Size(131, 36);
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
            this.btnAgregar.Location = new System.Drawing.Point(43, 491);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(99, 36);
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
            this.btnActualizar.Location = new System.Drawing.Point(164, 491);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
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
            this.btnHabilitarInhabilitar.Location = new System.Drawing.Point(312, 491);
            this.btnHabilitarInhabilitar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHabilitarInhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitarInhabilitar.Name = "btnHabilitarInhabilitar";
            this.btnHabilitarInhabilitar.Primary = false;
            this.btnHabilitarInhabilitar.Size = new System.Drawing.Size(218, 36);
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
            this.btnRegresar.Location = new System.Drawing.Point(560, 491);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(107, 36);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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