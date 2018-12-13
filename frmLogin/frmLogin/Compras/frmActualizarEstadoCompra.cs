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
    public partial class frmActualizarEstadoCompra : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        // Propiedade para obtener el codigo de la compra
        private int idCompra;

        public frmActualizarEstadoCompra()
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

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que carga todo s los componentes iniciales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmActualizarEstadoCompra_Load(object sender, EventArgs e)
        {
            rbEstado.Checked = false;
            ListarComboProveedores();
        }

        private void ListarComboProveedores()
        {
            // Limpiamos los items existentes
            cmbProveedor.Items.Clear();

            // Instanciamos la clase
            Compra elproveedor = new Compra();

            // Almacenamos todos los proveedores existentes
            // y habilitados en una lista
            List<Compra> lisaProveedor = Compra.LeerTodosProveedores();

            // Si hay algún elemento en la lista
            // Lo agregamos al ComboBox
            if (lisaProveedor.Any())
            {
                lisaProveedor.ForEach(proveedor => cmbProveedor.Items.Add(proveedor.nombreProveedor.ToString()));
            }
            else
            {
                cmbProveedor.Items.Add("No hay proveedores disponibles");
            }
        }

        /// <summary>
        /// Eveento para saber si se seleccionó
        /// la búsqueda por estado de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEstado.Checked == true)
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
        /// Evento para saber si se seleccionó
        /// la búsqueda por número de factura
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
        /// Evento para saber si se seleccionó
        /// la búsqueda por numero de factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProveedor.Checked == true)
            {
                cmbProveedor.Enabled = true;
                mtxtFactura.Enabled = false;
                cmbEstado.Enabled = false;
                
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
            this.Close();
        }

        /// <summary>
        /// Evento para buscar compra que llama a los diferentes métodos
        /// para realizar una búsqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // si no se selcciono ninguno
            if (rbEstado.Checked == false && rbFactura.Checked == false && rbProveedor.Checked == false)
            {
                MessageBox.Show("Seleccione un filtro");
            }
            else
            {
                btnBuscar.Enabled = false;
                // si se selecciono el estado
                if (rbEstado.Checked == true)
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
                // Si se seleccino factura
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
                // si se selecciono proveedor
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
        /// Método para restablecer los valores del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Método para limpiar la pantalla
        /// </summary>
        private void Limpiar()
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

            btnActualizar.Enabled = false;
            txtEstadoA.Text = "";
            txtEstadoP.Text = "";
            mtxtNuevaFactura.Text = "";
            mtxtNuevaFactura.Visible = false;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        /// <summary>
        /// Evento para cargar los detalles
        /// de un compra en específico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si se selccionó una fila
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
                    dgvDetalleCompra.Columns[2].Visible = false;
                    dgvDetalleCompra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Cargar el estado
                    Compra laCompra = new Compra();
                    laCompra = Compra.ObtenerEstadoCompra(Convert.ToInt16(dgvCompra.Rows[e.RowIndex].Cells["Código"].Value));
                    txtEstadoA.Text = laCompra.estadoCompra;
                    ValidarEstado(txtEstadoA.Text);

                   // btnActualizar.Enabled = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Método para validar el próximo estado de la compra
        /// </summary>
        /// <param name="estadoActual"></param>
        private void ValidarEstado(string estadoActual)
        {
            if (estadoActual == "Cotización")
            {
                txtEstadoP.Text = "Orden de Compra";
                btnActualizar.Enabled = true;
            }
            else if (estadoActual == "Orden de Compra")
            {
                txtEstadoP.Text = "Compra";
                mtxtNuevaFactura.Enabled = true;
                btnActualizar.Enabled = true;
                mtxtNuevaFactura.Visible = true;
            }
            else if (estadoActual == "Compra")
            {
                txtEstadoP.Text = "Compra Realizada";
                
            }
        }

        /// <summary>
        /// Evento para Actualizar el estado de una Compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActualizar_Click(object sender, EventArgs e)
        {
            if (txtEstadoA.Text == "Cotización")
            {
                // Instanciamos la clase Compras
                Compra laCompra = new Compra();

                // Nuestro objeto adquiere los valores del formulario
                laCompra.idCompra = this.idCompra;
                laCompra.autorizadaPor = 1;

                // Verificamos si se realizó el método
                if (Compra.ActualizarEstadoaOrden(laCompra))
                {
                    MessageBox.Show("Estado de Compra Actualizado","Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
            else if (txtEstadoA.Text == "Orden de Compra")
            {
                if (mtxtNuevaFactura.MaskFull == false)
                {
                    MessageBox.Show("Ingrese un número de factura para la Compra");
                }
                else
                {
                    // Instancimos la clase Compras
                    Compra laCompra = new Compra();

                    // Nuestro objeto adquiere los valores del formulario
                    laCompra.idCompra = this.idCompra;
                    laCompra.autorizadaPor = 1;
                    laCompra.numeroFactura = mtxtNuevaFactura.Text;

                    if (Compra.ActualizarEstadoaCompra(laCompra))
                    {
                        MessageBox.Show("Estado de Compra Actualizado", "Información");
                        Producto();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error, verifique los datos", "Información");
                    }
                }               


            }

        }

        /// <summary>
        /// Método para agregar la cantidad de productos comprados
        /// </summary>
        private void Producto()
        {
            for (int i = 0; i < dgvDetalleCompra.Rows.Count; i++)
            {
                try
                {
                    // Instanciamos la clase Detalle Compra
                    // Que contiene las propiedades necesarias
                    DetalleCompra elDetalle = new DetalleCompra();

                    // Nuestro objeto adquiere los valores del formulario
                    elDetalle.idProducto = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["idProducto"].Value.ToString());
                    elDetalle.cantidad = Convert.ToInt16(dgvDetalleCompra.Rows[i].Cells["Cantidad"].Value.ToString());

                    if (DetalleCompra.InsertarProductosCompra(elDetalle))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error, verifique los datos", "Información");
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            Limpiar();
        }

    }
}
