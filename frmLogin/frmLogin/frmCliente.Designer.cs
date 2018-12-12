namespace frmLogin
{
    partial class frmCliente
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
            this.lblIdentidad = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombres = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellidos = new MaterialSkin.Controls.MaterialLabel();
            this.lblDireccion = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.plDatos = new System.Windows.Forms.Panel();
            this.btnInhabilitados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHabilitados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lstInhabilitados = new System.Windows.Forms.ListBox();
            this.lstHabilitados = new System.Windows.Forms.ListBox();
            this.mskIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHa_In = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblListado = new System.Windows.Forms.Label();
            this.plDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Depth = 0;
            this.lblIdentidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdentidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdentidad.Location = new System.Drawing.Point(24, 120);
            this.lblIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(152, 19);
            this.lblIdentidad.TabIndex = 0;
            this.lblIdentidad.Text = "Número de Identidad:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Depth = 0;
            this.lblNombres.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombres.Location = new System.Drawing.Point(24, 177);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 19);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Depth = 0;
            this.lblApellidos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidos.Location = new System.Drawing.Point(24, 233);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(76, 19);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Depth = 0;
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(24, 288);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(77, 19);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(24, 336);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 19);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(24, 376);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(140, 19);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtNombres
            // 
            this.txtNombres.Depth = 0;
            this.txtNombres.Hint = "";
            this.txtNombres.Location = new System.Drawing.Point(209, 174);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.Size = new System.Drawing.Size(202, 23);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.TabStop = false;
            this.txtNombres.UseSystemPasswordChar = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(209, 233);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(202, 23);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(209, 284);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(202, 23);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(209, 376);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(202, 23);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // plDatos
            // 
            this.plDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plDatos.Controls.Add(this.btnInhabilitados);
            this.plDatos.Controls.Add(this.btnHabilitados);
            this.plDatos.Controls.Add(this.lstInhabilitados);
            this.plDatos.Controls.Add(this.lstHabilitados);
            this.plDatos.Location = new System.Drawing.Point(441, 119);
            this.plDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plDatos.Name = "plDatos";
            this.plDatos.Size = new System.Drawing.Size(258, 308);
            this.plDatos.TabIndex = 11;
            // 
            // btnInhabilitados
            // 
            this.btnInhabilitados.AutoSize = true;
            this.btnInhabilitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInhabilitados.Depth = 0;
            this.btnInhabilitados.Icon = null;
            this.btnInhabilitados.Location = new System.Drawing.Point(122, 5);
            this.btnInhabilitados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInhabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitados.Name = "btnInhabilitados";
            this.btnInhabilitados.Primary = true;
            this.btnInhabilitados.Size = new System.Drawing.Size(122, 36);
            this.btnInhabilitados.TabIndex = 19;
            this.btnInhabilitados.Text = "Inhabilitados";
            this.btnInhabilitados.UseVisualStyleBackColor = true;
            this.btnInhabilitados.Click += new System.EventHandler(this.btnInhabilitados_Click);
            // 
            // btnHabilitados
            // 
            this.btnHabilitados.AutoSize = true;
            this.btnHabilitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHabilitados.Depth = 0;
            this.btnHabilitados.Icon = null;
            this.btnHabilitados.Location = new System.Drawing.Point(11, 6);
            this.btnHabilitados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitados.Name = "btnHabilitados";
            this.btnHabilitados.Primary = true;
            this.btnHabilitados.Size = new System.Drawing.Size(108, 36);
            this.btnHabilitados.TabIndex = 18;
            this.btnHabilitados.Text = "Habilitados";
            this.btnHabilitados.UseVisualStyleBackColor = true;
            this.btnHabilitados.Click += new System.EventHandler(this.btnHabilitados_Click);
            // 
            // lstInhabilitados
            // 
            this.lstInhabilitados.FormattingEnabled = true;
            this.lstInhabilitados.Location = new System.Drawing.Point(16, 58);
            this.lstInhabilitados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstInhabilitados.Name = "lstInhabilitados";
            this.lstInhabilitados.Size = new System.Drawing.Size(228, 225);
            this.lstInhabilitados.TabIndex = 18;
            this.lstInhabilitados.Click += new System.EventHandler(this.lstInhabilitados_Click);
            // 
            // lstHabilitados
            // 
            this.lstHabilitados.FormattingEnabled = true;
            this.lstHabilitados.Location = new System.Drawing.Point(16, 58);
            this.lstHabilitados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHabilitados.Name = "lstHabilitados";
            this.lstHabilitados.Size = new System.Drawing.Size(228, 225);
            this.lstHabilitados.TabIndex = 17;
            this.lstHabilitados.Click += new System.EventHandler(this.lstHabilitados_Click);
            // 
            // mskIdentidad
            // 
            this.mskIdentidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mskIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIdentidad.ForeColor = System.Drawing.Color.White;
            this.mskIdentidad.Location = new System.Drawing.Point(209, 124);
            this.mskIdentidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskIdentidad.Mask = "0000-0000-00000";
            this.mskIdentidad.Name = "mskIdentidad";
            this.mskIdentidad.Size = new System.Drawing.Size(202, 17);
            this.mskIdentidad.TabIndex = 1;
            this.mskIdentidad.Leave += new System.EventHandler(this.mskIdentidad_Leave);
            // 
            // mskTelefono
            // 
            this.mskTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mskTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.ForeColor = System.Drawing.Color.White;
            this.mskTelefono.Location = new System.Drawing.Point(209, 339);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(202, 17);
            this.mskTelefono.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(71, 462);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(83, 36);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(180, 462);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnHa_In
            // 
            this.btnHa_In.AutoSize = true;
            this.btnHa_In.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHa_In.Depth = 0;
            this.btnHa_In.Icon = null;
            this.btnHa_In.Location = new System.Drawing.Point(304, 462);
            this.btnHa_In.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHa_In.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHa_In.Name = "btnHa_In";
            this.btnHa_In.Primary = true;
            this.btnHa_In.Size = new System.Drawing.Size(178, 36);
            this.btnHa_In.TabIndex = 15;
            this.btnHa_In.Text = "Habilitar/Inhabilitar";
            this.btnHa_In.UseVisualStyleBackColor = true;
            this.btnHa_In.Click += new System.EventHandler(this.btnHa_In_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(501, 462);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = true;
            this.btnRegresar.Size = new System.Drawing.Size(89, 36);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.White;
            this.lblListado.Location = new System.Drawing.Point(499, 93);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(144, 20);
            this.lblListado.TabIndex = 17;
            this.lblListado.Text = "Listado de Clientes";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnHa_In);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.mskIdentidad);
            this.Controls.Add(this.plDatos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblIdentidad);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.plDatos.ResumeLayout(false);
            this.plDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdentidad;
        private MaterialSkin.Controls.MaterialLabel lblNombres;
        private MaterialSkin.Controls.MaterialLabel lblApellidos;
        private MaterialSkin.Controls.MaterialLabel lblDireccion;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private System.Windows.Forms.Panel plDatos;
        private System.Windows.Forms.ListBox lstInhabilitados;
        private System.Windows.Forms.ListBox lstHabilitados;
        private System.Windows.Forms.MaskedTextBox mskIdentidad;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnHa_In;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegresar;
        private System.Windows.Forms.Label lblListado;
        private MaterialSkin.Controls.MaterialRaisedButton btnHabilitados;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitados;
    }
}