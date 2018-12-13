using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmLogin.Compras;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Compras
{
    public partial class frmBuscarCompras : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        // Propiedade para obtener el codigo de la compra
        private int idCompra;
        private int condicion;

        public int idCompraBusqueda { get; set; }
        public decimal subTotal { get; set; }
        public decimal total { get; set; }
        public decimal impuesto{ get; set; }
        public string observaciones { get; set; }
        public string Proveedor { get; set; }
        public frmBuscarCompras(int valor)
        {
            InitializeComponent();
            condicion = valor;
            if (condicion==0)
            {
                btnVolver.Visible = false;
            }
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }

        /// <summary>
        /// Evento que carga todos los componentes iniciales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuscarCompras_Load(object sender, EventArgs e)
        {
            ListarComboProveedores();
        }

        /// <summary>
        /// Evento para saber si se seleccionó 
        /// la búsqueda por estado de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstado.Checked == true)
            {
                cmbEstado.Enabled = true;
                mtxtFactura.Enabled = false;
                cmbProveedor.Enabled = false;
            }
            else
            {
                cmbEstado.SelectedIndex = -1;
            }
        }

        /// <summary>
        ///  /// Evento para saber si se seleccionó 
        /// la búsqueda por numero de factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFactura.Checked == true)
            {
                mtxtFactura.Enabled = true;
                cmbEstado.Enabled = false;
                cmbProveedor.Enabled = false;
            }
            else
            {
                mtxtFactura.Clear();
            }
        }

        /// <summary>
        ///  /// Evento para saber si se seleccionó 
        /// la búsqueda por proveedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProveedor.Checked == true)
            {
                cmbProveedor.Enabled = true;
                cmbEstado.Enabled = false;
                mtxtFactura.Enabled = false;
            }
            else
            {
                cmbProveedor.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Evento para salir del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (condicion==0)
            {
                idCompraBusqueda = 0;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            this.Close();

        }

        /// <summary>
        /// Evento buscar compra que llama a los diferentes métodos
        /// para realizar una búsqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Si no se selecciono ninguno
            if (rbEstado.Checked == false && rbFactura.Checked == false && rbProveedor.Checked == false)
            {
                MessageBox.Show("Seleccione un filtro");
            }
            else
            {
                // Si se selecciono el estado
                if (rbEstado.Checked == true )
                {
                    if (cmbEstado.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un Estado");
                    }
                    else
                    {
                        try
                        {
                            // El origen de los datos del DataGridView
                            // está en un método en la clase Compras
                            // hacemos referencia a él.
                            dgvCompra.DataSource = Compra.GetDataViewPorEstado(cmbEstado.SelectedItem.ToString());
                            dgvCompra.Columns[0].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                // Si se selecciono factura
                else if (rbFactura.Checked == true)
                {
                    if (mtxtFactura.MaskFull == false)
                    {
                        MessageBox.Show("Ingrese un número de factura");
                    }
                    else
                    {
                        // El origen de los datos del DataGridView
                        // está en un método en la clase Compras
                        // hacemos referencia a él.
                        dgvCompra.DataSource = Compra.GetDataViewPorFactura(mtxtFactura.Text);
                        dgvCompra.Columns[0].Visible = false;
                    }
                }
                // si se selcciono proveedor
                else if (rbProveedor.Checked == true)
                {
                    if (cmbProveedor.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un Proveedor");
                    }
                    else
                    {
                        // El origen de los datos del DataGridView
                        // está en un método en la clase Compras
                        // hacemos referencia a él.
                        dgvCompra.DataSource = Compra.GetDataViewPorProveedor(cmbProveedor.SelectedItem.ToString());
                        dgvCompra.Columns[0].Visible = false;
                    }
                }

            }           

        }

        /// <summary>
        /// Método para Cargar el ComboBox
        /// </summary>
        private void ListarComboProveedores()
        {
            // Limpiamos los item existentes
            cmbProveedor.Items.Clear();

            // Instanciamos la Clase
            Compra elproveedor = new Compra();

            // Almacenamos todos los proveedores Existentes
            // y habilitados en una lista
            List<Compra> listaProveedor = Compra.LeerTodosProveedores();

            // Si hay algún elemento en la lista
            // Lo agregamos al ComboBox
            if (listaProveedor.Any())
            {
                listaProveedor.ForEach(proveedor => cmbProveedor.Items.Add(proveedor.nombreProveedor.ToString()));
            }
            else
            {
                cmbProveedor.Items.Add("No hay proveedores diponibles");
               
            }
        }

        /// <summary>
        /// Método para restablecer los valores del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCompra.DataSource = null;
            dgvDetalleCompra.DataSource = null;

            cmbProveedor.SelectedIndex = -1;
            mtxtFactura.Text = "";
            cmbProveedor.SelectedIndex = -1;

            rbEstado.Checked = false;
            rbFactura.Checked = false;
            rbProveedor.Checked = false;

            cmbEstado.Enabled = false;
            mtxtFactura.Enabled = false;
            cmbProveedor.Enabled = false;
        }

        /// <summary>
        /// Evento para cargar los detalles 
        /// de una compra en específico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (condicion == 0)
            {
                if (e.RowIndex != -1)
                {
                    this.idCompra = Convert.ToInt16(dgvCompra.Rows[e.RowIndex].Cells["Código"].Value);
                    try
                    {
                        // El origen de los datos del DataGridView
                        // está en un método en la clase DetalleCompra
                        // hacemos referencia a él.
                        dgvDetalleCompra.DataSource = DetalleCompra.GetDataViewPorCompra(this.idCompra);
                        dgvDetalleCompra.Columns[0].Visible = false;
                        dgvDetalleCompra.Columns[1].Visible = false;
                        dgvDetalleCompra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                idCompraBusqueda = Convert.ToInt16(dgvCompra.Rows[e.RowIndex].Cells["Código"].Value);
                subTotal= Convert.ToDecimal(dgvCompra.Rows[e.RowIndex].Cells["SubTotal"].Value);
                total = Convert.ToDecimal(dgvCompra.Rows[e.RowIndex].Cells["Total"].Value);
                impuesto = Convert.ToDecimal(dgvCompra.Rows[e.RowIndex].Cells["Impuesto"].Value);
                observaciones = dgvCompra.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();
                Proveedor= dgvCompra.Rows[e.RowIndex].Cells["Proveedor"].Value.ToString();
            }
            

            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                if (idCompraBusqueda == 0)
                {
                    MessageBox.Show("no ha seleccionado una compra");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
