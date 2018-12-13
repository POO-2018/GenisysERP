namespace frmLogin
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblGenesysERP = new MaterialSkin.Controls.MaterialLabel();
            this.lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            this.txtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblErrorUsuarioContrasena = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(47, 168);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 23);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(183, 168);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(251, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblGenesysERP
            // 
            this.lblGenesysERP.BackColor = System.Drawing.Color.Transparent;
            this.lblGenesysERP.Depth = 0;
            this.lblGenesysERP.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGenesysERP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGenesysERP.Location = new System.Drawing.Point(143, 80);
            this.lblGenesysERP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGenesysERP.Name = "lblGenesysERP";
            this.lblGenesysERP.Size = new System.Drawing.Size(184, 50);
            this.lblGenesysERP.TabIndex = 2;
            this.lblGenesysERP.Text = "Genisys ERP";
            this.lblGenesysERP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContraseña
            // 
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Depth = 0;
            this.lblContraseña.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContraseña.Location = new System.Drawing.Point(45, 237);
            this.lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(88, 23);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Hint = "";
            this.txtContraseña.Location = new System.Drawing.Point(183, 237);
            this.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.Size = new System.Drawing.Size(251, 23);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(83, 315);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(139, 36);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(275, 315);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(139, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblErrorUsuarioContrasena
            // 
            this.lblErrorUsuarioContrasena.AutoSize = true;
            this.lblErrorUsuarioContrasena.Depth = 0;
            this.lblErrorUsuarioContrasena.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorUsuarioContrasena.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorUsuarioContrasena.Location = new System.Drawing.Point(179, 146);
            this.lblErrorUsuarioContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorUsuarioContrasena.Name = "lblErrorUsuarioContrasena";
            this.lblErrorUsuarioContrasena.Size = new System.Drawing.Size(0, 19);
            this.lblErrorUsuarioContrasena.TabIndex = 9;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 380);
            this.Controls.Add(this.lblErrorUsuarioContrasena);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblGenesysERP);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblGenesysERP;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lblErrorUsuarioContrasena;
    }
}

