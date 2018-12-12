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
        // Creamos una variable publica para capturar el valor del id del impuesto
        // seleccionado.
        public string elCodigo;

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
            // inicializamos los textos vacíos
            dgvImpuesto.DataSource = null;
            dgvimpuestoInhabilitado.DataSource = null;
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
        /// <summary>
        /// Función que se encarga de limpiar los textbox y recargar los
        /// datos en el dataGridView.
        /// </summary>
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
            dgvimpuestoInhabilitado.Visible = false;
            dgvImpuesto.Visible = true;
            btnInhabilitar.Text = "Inhabilitar";
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtValor.Enabled = true;
            txtRegistradoPor.Enabled = true;
            txtObservacion.Enabled = true;
            txtCodigo.Focus();
            CargarDatos();
        }
        /// <summary>
        /// Instancia de la clase Impuesto y llama al método actualizarImpuesto
        /// y recarga de los datos en el dataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que el usuario no intente actualizar un registro
            // con los datos vacios.
            if(txtCodigo.Text==""|| txtDescripcion.Text == "")
            {
                MessageBox.Show("¡Debe ingresar un código y una descripción", "Error en ingreso");
            }else if(txtValor.Text=="" || txtRegistradoPor.Text == "")
            {
                MessageBox.Show("¡Debe ingresar un valor y el usuario quien lo registra", "Error en ingreso");

            }
            else
            {
                //Instanciamos de la clase Impuesto y llamamos es método
                // actualizar
                Impuesto actualizar = new Impuesto();

                // cargamos los datos
                actualizar.idImpuesto = Convert.ToInt32(elCodigo);
                actualizar.idCodigoImpuesto = txtCodigo.Text;
                actualizar.descripcion = txtDescripcion.Text;
                actualizar.valor = Convert.ToDecimal(txtValor.Text);
                MessageBox.Show(txtValor.Text);
                actualizar.idUsuario = Convert.ToInt32(txtRegistradoPor.Text);
                actualizar.fechaCreacion = System.DateTime.Now;
                actualizar.estado = 1;
                actualizar.observacion = txtObservacion.Text;

                // guardamos los datos capturados
                if (Impuesto.ActualizarImpuesto(actualizar))
                {
                    MessageBox.Show("Impuesto actualizado correctamente", "GenisysERP");
                    Limpiar();
                }
                else
                {
                   MessageBox.Show("Ha ocurrido un problema durante la actualización", "GenisysERP");
                   Limpiar();
                }              
            }
        }

        public void CargarDatos()
        {
            // cargamos los datos de los impuestos existentes en la base de datos.
            // instanciamos de la clase impuesto
            List<Impuesto> listah = Impuesto.LeerTodos();
            dgvImpuesto.DataSource = listah;


            // Cargamos los dotos de los impuestos inhabilitados en la base de datos
            //instanciamos de la clase impuesto
            List<Impuesto> listaI = Impuesto.LeerTodosInhabilitados();
            dgvimpuestoInhabilitado.DataSource = listaI;

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
                elCodigo = Convert.ToString(cargar.idImpuesto);

                // Validamos si hay datos existentes.
                if (cargar.estado == 0)
                {
                   
                    txtCodigo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtValor.Enabled = false;
                    txtRegistradoPor.Enabled = false;
                    txtObservacion.Enabled = false;
                    btnActualizar.Visible = false;
                    btnInhabilitar.Text = "Habilitar";
                    btnInhabilitar.Visible = true;
                    btnAgregar.Visible = false;
                    MessageBox.Show("Impuesto inhabilitado");

                }
                else if (txtCodigo.Text != "" && txtDescripcion.Text != "")
                {
                    btnAgregar.Visible = false;
                    btnActualizar.Visible = true;
                    btnInhabilitar.Visible = true;
                }
            }
            
            
        }

        /// <summary>
        /// Muestra los impuestos que han sido habilitados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInhabilitados_Click(object sender, EventArgs e)
        {
            dgvimpuestoInhabilitado.Visible = true;

        }
        /// <summary>
        /// Muestra los impuestos que se encuentran disponibles y 
        /// habilitados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            dgvimpuestoInhabilitado.Visible = false;
            dgvImpuesto.Visible = true;
        }

        private void dgvimpuestoInhabilitado_DoubleClick(object sender, EventArgs e)
        {
            elCodigo = Convert.ToString(dgvimpuestoInhabilitado.CurrentRow.Cells[3].Value);

            //Cargamos los datos del impuesto seleccionado.
            Impuesto cargar = Impuesto.BuscarImpuesto(elCodigo);

            txtCodigo.Text = cargar.idCodigoImpuesto;
            txtDescripcion.Text = cargar.descripcion;
            txtValor.Text = Convert.ToString(cargar.valor);
            txtRegistradoPor.Text = Convert.ToString(cargar.idUsuario);
            txtObservacion.Text = cargar.observacion;
            elCodigo = Convert.ToString(cargar.idImpuesto);

            if (cargar.estado == 0)
            {
                MessageBox.Show("Impuesto inhabilitado");
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                txtValor.Enabled = false;
                txtRegistradoPor.Enabled = false;
                txtObservacion.Enabled = false;
                btnActualizar.Visible = false;
                btnInhabilitar.Text = "Habilitar";
                btnInhabilitar.Visible = true;
                btnAgregar.Visible = false;
            }
            else if (txtCodigo.Text != "" && txtDescripcion.Text != "")
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                btnInhabilitar.Visible = true;
            }
        }

        private void dgvImpuesto_DoubleClick_1(object sender, EventArgs e)
        {
            elCodigo = Convert.ToString(dgvImpuesto.CurrentRow.Cells[3].Value);

            //Cargamos los datos del impuesto seleccionado.
            Impuesto cargar = Impuesto.BuscarImpuesto(elCodigo);

            txtCodigo.Text = cargar.idCodigoImpuesto;
            txtDescripcion.Text = cargar.descripcion;
            txtValor.Text = Convert.ToString(cargar.valor);
            txtRegistradoPor.Text = Convert.ToString(cargar.idUsuario);
            txtObservacion.Text = cargar.observacion;
            elCodigo = Convert.ToString(cargar.idImpuesto);
            // Validamos si hay datos existentes.
            if (txtCodigo.Text != "" && txtDescripcion.Text != "")
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                btnInhabilitar.Visible = true;
            }
        }

        /// <summary>
        /// Limpia los datos contenidos en los textbox y recarga
        /// los datos contenidos en los dataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            //Instanciamos de la clase impuesto
            Impuesto inhabilitar = new Impuesto();
            inhabilitar.idImpuesto = Convert.ToInt32(elCodigo);
            MessageBox.Show(elCodigo);

            //verificamos si la opción está en modo habilitar ó inhabilitar.
            if (btnInhabilitar.Text== "Inhabilitar")
            {

                DialogResult R= MessageBox.Show("¿Está seguro que desea inhabilitar el impuesto", "GenisysERP",MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    //intentamos guardar los cambios
                    if (Impuesto.EliminarImpuesto(inhabilitar))
                    {
                        MessageBox.Show("Impuesto inhabilitado correctamente", "GenisysERP");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error durante la inhabilitación", "GenisysERP");
                        Limpiar();
                    }

                }
                else
                {
                    Limpiar();
                }
            }
            else
            {
                DialogResult R = MessageBox.Show("¿Está seguro que desea habilitar el impuesto?", "GenisysERP", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    // intentamos habilitar el registro
                    if (Impuesto.HabilitarImpuesto(inhabilitar))
                    {
                        MessageBox.Show("Impuesto habilitado correctamente", "GenisysERP");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error durante la habilitación", "GenisysERP");
                        Limpiar();
                    }
                }
                else
                {
                    Limpiar();
                }
            }
        }
    }
}
