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
            this.txtIdentidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHa_In = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstInhabilitados = new System.Windows.Forms.ListBox();
            this.btnInhabilitados = new MaterialSkin.Controls.MaterialFlatButton();
            this.lstHabilitados = new System.Windows.Forms.ListBox();
            this.btnHabilitados = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Depth = 0;
            this.lblIdentidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdentidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdentidad.Location = new System.Drawing.Point(35, 116);
            this.lblIdentidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(193, 24);
            this.lblIdentidad.TabIndex = 0;
            this.lblIdentidad.Text = "Número de Identidad:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Depth = 0;
            this.lblNombres.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombres.Location = new System.Drawing.Point(35, 186);
            this.lblNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(94, 24);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Depth = 0;
            this.lblApellidos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidos.Location = new System.Drawing.Point(35, 255);
            this.lblApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(95, 24);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Depth = 0;
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccion.Location = new System.Drawing.Point(35, 322);
            this.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(94, 24);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(35, 382);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(90, 24);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(35, 431);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(171, 24);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Depth = 0;
            this.txtIdentidad.Hint = "";
            this.txtIdentidad.Location = new System.Drawing.Point(282, 116);
            this.txtIdentidad.MaxLength = 32767;
            this.txtIdentidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.PasswordChar = '\0';
            this.txtIdentidad.SelectedText = "";
            this.txtIdentidad.SelectionLength = 0;
            this.txtIdentidad.SelectionStart = 0;
            this.txtIdentidad.Size = new System.Drawing.Size(269, 28);
            this.txtIdentidad.TabIndex = 1;
            this.txtIdentidad.TabStop = false;
            this.txtIdentidad.UseSystemPasswordChar = false;
            this.txtIdentidad.Leave += new System.EventHandler(this.txtIdentidad_Leave);
            // 
            // txtNombres
            // 
            this.txtNombres.Depth = 0;
            this.txtNombres.Hint = "";
            this.txtNombres.Location = new System.Drawing.Point(282, 182);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.Size = new System.Drawing.Size(269, 28);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.TabStop = false;
            this.txtNombres.UseSystemPasswordChar = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(282, 255);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(269, 28);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(282, 318);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(269, 28);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(282, 378);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(269, 28);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "";
            this.txtCorreo.Location = new System.Drawing.Point(282, 431);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(269, 28);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(63, 503);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(99, 36);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(205, 503);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnHa_In
            // 
            this.btnHa_In.AutoSize = true;
            this.btnHa_In.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHa_In.BackColor = System.Drawing.Color.Transparent;
            this.btnHa_In.Depth = 0;
            this.btnHa_In.Icon = null;
            this.btnHa_In.Location = new System.Drawing.Point(380, 503);
            this.btnHa_In.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHa_In.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHa_In.Name = "btnHa_In";
            this.btnHa_In.Primary = false;
            this.btnHa_In.Size = new System.Drawing.Size(218, 36);
            this.btnHa_In.TabIndex = 9;
            this.btnHa_In.Text = "Habilitar/Inhabilitar";
            this.btnHa_In.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(652, 503);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(107, 36);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstInhabilitados);
            this.panel1.Controls.Add(this.btnInhabilitados);
            this.panel1.Controls.Add(this.lstHabilitados);
            this.panel1.Controls.Add(this.btnHabilitados);
            this.panel1.Location = new System.Drawing.Point(591, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 378);
            this.panel1.TabIndex = 11;
            // 
            // lstInhabilitados
            // 
            this.lstInhabilitados.FormattingEnabled = true;
            this.lstInhabilitados.ItemHeight = 16;
            this.lstInhabilitados.Location = new System.Drawing.Point(22, 71);
            this.lstInhabilitados.Name = "lstInhabilitados";
            this.lstInhabilitados.Size = new System.Drawing.Size(302, 276);
            this.lstInhabilitados.TabIndex = 18;
            this.lstInhabilitados.Click += new System.EventHandler(this.lstInhabilitados_Click);
            // 
            // btnInhabilitados
            // 
            this.btnInhabilitados.AutoSize = true;
            this.btnInhabilitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInhabilitados.BackColor = System.Drawing.Color.Transparent;
            this.btnInhabilitados.Depth = 0;
            this.btnInhabilitados.Icon = null;
            this.btnInhabilitados.Location = new System.Drawing.Point(177, 5);
            this.btnInhabilitados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInhabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitados.Name = "btnInhabilitados";
            this.btnInhabilitados.Primary = false;
            this.btnInhabilitados.Size = new System.Drawing.Size(147, 36);
            this.btnInhabilitados.TabIndex = 16;
            this.btnInhabilitados.Text = "Inhabilitados\r\n";
            this.btnInhabilitados.UseVisualStyleBackColor = false;
            this.btnInhabilitados.Click += new System.EventHandler(this.btnInhabilitados_Click);
            // 
            // lstHabilitados
            // 
            this.lstHabilitados.FormattingEnabled = true;
            this.lstHabilitados.ItemHeight = 16;
            this.lstHabilitados.Location = new System.Drawing.Point(22, 71);
            this.lstHabilitados.Name = "lstHabilitados";
            this.lstHabilitados.Size = new System.Drawing.Size(302, 276);
            this.lstHabilitados.TabIndex = 17;
            this.lstHabilitados.Click += new System.EventHandler(this.lstHabilitados_Click);
            // 
            // btnHabilitados
            // 
            this.btnHabilitados.AutoSize = true;
            this.btnHabilitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHabilitados.BackColor = System.Drawing.Color.Transparent;
            this.btnHabilitados.Depth = 0;
            this.btnHabilitados.Icon = null;
            this.btnHabilitados.Location = new System.Drawing.Point(22, 5);
            this.btnHabilitados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHabilitados.Name = "btnHabilitados";
            this.btnHabilitados.Primary = false;
            this.btnHabilitados.Size = new System.Drawing.Size(130, 36);
            this.btnHabilitados.TabIndex = 15;
            this.btnHabilitados.Text = "Habilitados\r\n";
            this.btnHabilitados.UseVisualStyleBackColor = false;
            this.btnHabilitados.Click += new System.EventHandler(this.btnHabilitados_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(936, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(16, 17);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "1";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnHa_In);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblIdentidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdentidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnHa_In;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstInhabilitados;
        private MaterialSkin.Controls.MaterialFlatButton btnInhabilitados;
        private System.Windows.Forms.ListBox lstHabilitados;
        private MaterialSkin.Controls.MaterialFlatButton btnHabilitados;
        private System.Windows.Forms.Label lblUsuario;
    }
}