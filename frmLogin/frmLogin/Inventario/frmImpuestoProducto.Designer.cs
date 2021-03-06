﻿namespace frmLogin.Inventario
{
    partial class frmImpuestoProducto
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.lblValor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRegistradoPor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObservacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInhabilitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvImpuesto = new System.Windows.Forms.DataGridView();
            this.btnInhabilitados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvimpuestoInhabilitado = new System.Windows.Forms.DataGridView();
            this.btnhabilitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvimpuestoInhabilitado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(305, 126);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 19);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Contról de impuestos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigo.Location = new System.Drawing.Point(21, 212);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 19);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcion.Location = new System.Drawing.Point(21, 250);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Depth = 0;
            this.lblValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(21, 298);
            this.lblValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 19);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 346);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Registrado por:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 389);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Observación:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(139, 207);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(244, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "materialSingleLineTextField1";
            this.txtCodigo.UseSystemPasswordChar = false;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "";
            this.txtDescripcion.Location = new System.Drawing.Point(139, 250);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(244, 23);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "materialSingleLineTextField2";
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "";
            this.txtValor.Location = new System.Drawing.Point(139, 298);
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(244, 23);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "materialSingleLineTextField3";
            this.txtValor.UseSystemPasswordChar = false;
            // 
            // txtRegistradoPor
            // 
            this.txtRegistradoPor.Depth = 0;
            this.txtRegistradoPor.Hint = "";
            this.txtRegistradoPor.Location = new System.Drawing.Point(139, 346);
            this.txtRegistradoPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegistradoPor.Name = "txtRegistradoPor";
            this.txtRegistradoPor.PasswordChar = '\0';
            this.txtRegistradoPor.SelectedText = "";
            this.txtRegistradoPor.SelectionLength = 0;
            this.txtRegistradoPor.SelectionStart = 0;
            this.txtRegistradoPor.Size = new System.Drawing.Size(244, 23);
            this.txtRegistradoPor.TabIndex = 3;
            this.txtRegistradoPor.Text = "materialSingleLineTextField4";
            this.txtRegistradoPor.UseSystemPasswordChar = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Depth = 0;
            this.txtObservacion.Hint = "";
            this.txtObservacion.Location = new System.Drawing.Point(139, 389);
            this.txtObservacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.Size = new System.Drawing.Size(244, 23);
            this.txtObservacion.TabIndex = 4;
            this.txtObservacion.Text = "materialSingleLineTextField5";
            this.txtObservacion.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(25, 526);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(156, 44);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(227, 526);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(156, 44);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Depth = 0;
            this.btnInhabilitar.Location = new System.Drawing.Point(430, 526);
            this.btnInhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Primary = true;
            this.btnInhabilitar.Size = new System.Drawing.Size(156, 44);
            this.btnInhabilitar.TabIndex = 7;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(621, 526);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(156, 44);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvImpuesto
            // 
            this.dgvImpuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuesto.Location = new System.Drawing.Point(389, 225);
            this.dgvImpuesto.Name = "dgvImpuesto";
            this.dgvImpuesto.Size = new System.Drawing.Size(388, 159);
            this.dgvImpuesto.TabIndex = 12;
            this.dgvImpuesto.DoubleClick += new System.EventHandler(this.dgvImpuesto_DoubleClick_1);
            // 
            // btnInhabilitados
            // 
            this.btnInhabilitados.Depth = 0;
            this.btnInhabilitados.Location = new System.Drawing.Point(522, 387);
            this.btnInhabilitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInhabilitados.Name = "btnInhabilitados";
            this.btnInhabilitados.Primary = true;
            this.btnInhabilitados.Size = new System.Drawing.Size(119, 29);
            this.btnInhabilitados.TabIndex = 10;
            this.btnInhabilitados.Text = "Inhabilitados";
            this.btnInhabilitados.UseVisualStyleBackColor = true;
            this.btnInhabilitados.Click += new System.EventHandler(this.btnInhabilitados_Click);
            // 
            // dgvimpuestoInhabilitado
            // 
            this.dgvimpuestoInhabilitado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvimpuestoInhabilitado.Location = new System.Drawing.Point(390, 225);
            this.dgvimpuestoInhabilitado.Name = "dgvimpuestoInhabilitado";
            this.dgvimpuestoInhabilitado.Size = new System.Drawing.Size(388, 159);
            this.dgvimpuestoInhabilitado.TabIndex = 18;
            this.dgvimpuestoInhabilitado.DoubleClick += new System.EventHandler(this.dgvimpuestoInhabilitado_DoubleClick);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Depth = 0;
            this.btnhabilitar.Location = new System.Drawing.Point(389, 387);
            this.btnhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Primary = true;
            this.btnhabilitar.Size = new System.Drawing.Size(119, 29);
            this.btnhabilitar.TabIndex = 9;
            this.btnhabilitar.Text = "habilitados";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(648, 387);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(129, 29);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // frmImpuestoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.dgvimpuestoInhabilitado);
            this.Controls.Add(this.btnInhabilitados);
            this.Controls.Add(this.dgvImpuesto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtRegistradoPor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "frmImpuestoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genisys ERP";
            this.Load += new System.EventHandler(this.frmImpuestoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvimpuestoInhabilitado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialLabel lblValor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegistradoPor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgvImpuesto;
        private MaterialSkin.Controls.MaterialRaisedButton btnInhabilitados;
        private System.Windows.Forms.DataGridView dgvimpuestoInhabilitado;
        private MaterialSkin.Controls.MaterialRaisedButton btnhabilitar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
    }
}