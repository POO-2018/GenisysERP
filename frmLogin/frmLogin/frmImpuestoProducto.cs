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
            // Eliminamos la ultima fila en blanco del data grid
           dgvImpuesto.AllowUserToAddRows = false;
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

            // IdentidadPaciente = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            // inicializamos los textos vacíos
            Limpiar();

            // cargamos los datos de los impuestos existentes en la base de datos.
            // instanciamos de la clase impuesto
            List<Impuesto> listaT = Impuesto.LeerTodos();

            // limpiamos los datos que se encuentren en la lista.
            dgvImpuesto.Rows.Clear();
            dgvImpuesto.DataSource = listaT;
            

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
            btnAgregar.Visible = true;
            btnActualizar.Visible = false;
            btnInhabilitar.Visible = false;
            txtCodigo.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void dgvImpuesto_DoubleClick(object sender, EventArgs e)
        {
            string codigo=  Convert.ToString(dgvImpuesto.CurrentRow.Cells[0].Value);

            //Cargamos los datos del impuesto seleccionado.
            Impuesto cargar = Impuesto.BuscarImpuesto(codigo);

            txtCodigo.Text = cargar.idCodigoImpuesto;
            txtDescripcion.Text = cargar.descripcion;
            txtValor.Text = Convert.ToString(cargar.valor);
            txtRegistradoPor.Text = Convert.ToString(cargar.idUsuario);
            txtObservacion.Text = cargar.observacion;

            // Validamos si hay datos existentes.
            if(txtCodigo.Text!="" && txtDescripcion.Text != "")
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                btnInhabilitar.Visible = true;
            }

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            //Cargamos los datos del impuesto seleccionado.
            Impuesto cargar = Impuesto.BuscarImpuesto(txtCodigo.Text);
            if(cargar.idCodigoImpuesto !=null && cargar.descripcion != null)
            {
                txtCodigo.Text = cargar.idCodigoImpuesto;
                txtDescripcion.Text = cargar.descripcion;
                txtValor.Text = Convert.ToString(cargar.valor);
                txtRegistradoPor.Text = Convert.ToString(cargar.idUsuario);
                txtObservacion.Text = cargar.observacion;

                // Validamos si hay datos existentes.
                if (txtCodigo.Text != "" && txtDescripcion.Text != "")
                {
                    btnAgregar.Visible = false;
                    btnActualizar.Visible = true;
                    btnInhabilitar.Visible = true;
                }
            }
            
            
        }
    }
}
