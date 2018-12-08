using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Inventario
{
    public partial class frmImpuestoProducto : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public frmImpuestoProducto()
        {
            InitializeComponent();
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }

        private void frmImpuestoProducto_Load(object sender, EventArgs e)
        {
            // inicializamos los textos vacíos
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// instancia de la clase impuestoProducto y llama al 
        /// método de agregar Producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validamos que los datos estén ingresados.
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("¡Hay datos sin ser llenado, por favor revise", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                // instanciamos de la clase impuestoProducto
                Impuesto nuevo = new Impuesto();
                nuevo.idCodigoImpuesto = txtCodigo.Text;
                nuevo.descripcion = txtDescripcion.Text;
                nuevo.valor = Convert.ToDecimal(txtValor.Text);
                nuevo.observacion = txtObservacion.Text;
                nuevo.idUsuario = Convert.ToInt16(txtRegistradoPor.Text);
                nuevo.fechaCreacion = System.DateTime.Now;
                nuevo.estado = 1;

                if (Impuesto.InsertarImpuesto(nuevo))
                {
                    MessageBox.Show("Impuesto registrado satifactoriamente", "Control de impuestos");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("¡Ha ocurrido un error durante la inserción!", "Contról de ipuestos");
                    Limpiar();
                }


            }


        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtValor.Text = "";
            txtObservacion.Text = "";
            txtRegistradoPor.Text = "";
            txtCodigo.Focus();
        }
    }
}
