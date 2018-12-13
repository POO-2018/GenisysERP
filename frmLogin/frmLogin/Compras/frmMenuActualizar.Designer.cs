namespace frmLogin.Compras
{
    partial class frmMenuActualizar
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
            this.btnActualizarEstado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.Depth = 0;
            this.btnActualizarEstado.Location = new System.Drawing.Point(33, 116);
            this.btnActualizarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Primary = true;
            this.btnActualizarEstado.Size = new System.Drawing.Size(179, 88);
            this.btnActualizarEstado.TabIndex = 3;
            this.btnActualizarEstado.Text = "Actualizar estado";
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // btnActualizarCompra
            // 
            this.btnActualizarCompra.Depth = 0;
            this.btnActualizarCompra.Location = new System.Drawing.Point(273, 116);
            this.btnActualizarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCompra.Name = "btnActualizarCompra";
            this.btnActualizarCompra.Primary = true;
            this.btnActualizarCompra.Size = new System.Drawing.Size(179, 88);
            this.btnActualizarCompra.TabIndex = 4;
            this.btnActualizarCompra.Text = "Actualizar compra";
            this.btnActualizarCompra.UseVisualStyleBackColor = true;
            this.btnActualizarCompra.Click += new System.EventHandler(this.btnActualizarCompra_Click);
            // 
            // frmMenuActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 268);
            this.Controls.Add(this.btnActualizarCompra);
            this.Controls.Add(this.btnActualizarEstado);
            this.MaximizeBox = false;
            this.Name = "frmMenuActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEstado;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCompra;
    }
}