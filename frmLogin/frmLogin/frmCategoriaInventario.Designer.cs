namespace frmLogin
{
    partial class frmCategoriaInventario
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
            this.btnActualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtConsultar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbDescripción = new MaterialSkin.Controls.MaterialLabel();
            this.lbNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lbCodigoTipo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lstCategoriaInventario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(158, 310);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = false;
            this.btnActualizar.Size = new System.Drawing.Size(94, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.AutoSize = true;
            this.txtEliminar.Depth = 0;
            this.txtEliminar.Location = new System.Drawing.Point(59, 358);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Primary = false;
            this.txtEliminar.Size = new System.Drawing.Size(91, 36);
            this.txtEliminar.TabIndex = 6;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.UseVisualStyleBackColor = true;
            // 
            // txtConsultar
            // 
            this.txtConsultar.AutoSize = true;
            this.txtConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtConsultar.BackColor = System.Drawing.Color.Transparent;
            this.txtConsultar.Depth = 0;
            this.txtConsultar.Location = new System.Drawing.Point(161, 358);
            this.txtConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Primary = false;
            this.txtConsultar.Size = new System.Drawing.Size(91, 36);
            this.txtConsultar.TabIndex = 5;
            this.txtConsultar.Text = "Consultar";
            this.txtConsultar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(56, 310);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(94, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "";
            this.txtDescripcion.Location = new System.Drawing.Point(130, 192);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(192, 23);
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(130, 156);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(192, 23);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(130, 120);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(192, 23);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.Text = "Codigo";
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // lbDescripción
            // 
            this.lbDescripción.AutoSize = true;
            this.lbDescripción.Depth = 0;
            this.lbDescripción.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbDescripción.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDescripción.Location = new System.Drawing.Point(22, 196);
            this.lbDescripción.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescripción.Name = "lbDescripción";
            this.lbDescripción.Size = new System.Drawing.Size(93, 19);
            this.lbDescripción.TabIndex = 13;
            this.lbDescripción.Text = "Descripción:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Depth = 0;
            this.lbNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNombre.Location = new System.Drawing.Point(22, 160);
            this.lbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(67, 19);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigoTipo
            // 
            this.lbCodigoTipo.AutoSize = true;
            this.lbCodigoTipo.Depth = 0;
            this.lbCodigoTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCodigoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCodigoTipo.Location = new System.Drawing.Point(22, 120);
            this.lbCodigoTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCodigoTipo.Name = "lbCodigoTipo";
            this.lbCodigoTipo.Size = new System.Drawing.Size(61, 19);
            this.lbCodigoTipo.TabIndex = 11;
            this.lbCodigoTipo.Text = "Codigo:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(430, 71);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "idUsurio";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Depth = 0;
            this.lbUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUsuario.Location = new System.Drawing.Point(339, 71);
            this.lbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(65, 19);
            this.lbUsuario.TabIndex = 17;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lstCategoriaInventario
            // 
            this.lstCategoriaInventario.FormattingEnabled = true;
            this.lstCategoriaInventario.Location = new System.Drawing.Point(359, 120);
            this.lstCategoriaInventario.Name = "lstCategoriaInventario";
            this.lstCategoriaInventario.Size = new System.Drawing.Size(278, 290);
            this.lstCategoriaInventario.TabIndex = 19;
            // 
            // frmCategoriaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 449);
            this.Controls.Add(this.lstCategoriaInventario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbDescripción);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigoTipo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmCategoriaInventario";
            this.Text = "Categoria Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnActualizar;
        private MaterialSkin.Controls.MaterialFlatButton txtEliminar;
        private MaterialSkin.Controls.MaterialFlatButton txtConsultar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialLabel lbDescripción;
        private MaterialSkin.Controls.MaterialLabel lbNombre;
        private MaterialSkin.Controls.MaterialLabel lbCodigoTipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbUsuario;
        private System.Windows.Forms.ListBox lstCategoriaInventario;
    }
}