using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmLogin.Inventario;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin
{
    public partial class frmCategoriaInventario : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public frmCategoriaInventario()
        {
            InitializeComponent();

            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE

            );
        }

        /// <summary>
        /// Metodo de limpiar para limpiar los TextBox
        /// </summary>
        private void LimpiarText()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtUsuario.Text = "";
        }

        /// <summary>
        /// Metodo de agregar una nueva categoria a la 
        /// base de datps
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {
                CategoriaInventario agregar = new CategoriaInventario();
                agregar.idCodigoTipo = txtCodigo.Text;
                agregar.nombre = txtNombre.Text;
                agregar.descripcion = txtDescripcion.Text;
                agregar.idUsuario = Convert.ToInt32(txtUsuario.Text);

                if (CategoriaInventario.InsertarCategoria(agregar))
                {
                    MessageBox.Show("Los datos fueron guardados");
                    LimpiarText();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error, los datos no se guardaron");
                }
            }
        }

        /// <summary>
        /// Metodo para el boton de salir del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo para inhabilitar cualquier categoria que este en el inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Agregue el codigo");
            }
            else
            {
                CategoriaInventario inhabilitar = new CategoriaInventario();
                inhabilitar.idCodigoTipo = txtCodigo.Text;
         

                if (CategoriaInventario.EliminarCategoria(inhabilitar))
                {
                    MessageBox.Show("Los datos han sido Inhabilitado");
                    LimpiarText();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error, los datos no se Inhabilitaron");
                }
            }
        }

        /// <summary>
        /// Metodo para actualizar los datos de cada categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" )
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                CategoriaInventario actualizar = new CategoriaInventario();
                actualizar.idCodigoTipo = txtCodigo.Text;
                actualizar.nombre = txtNombre.Text;
                actualizar.descripcion = txtDescripcion.Text;
                actualizar.idUsuario = Convert.ToInt32(txtUsuario.Text);

                if (CategoriaInventario.ActualizarCategoria(actualizar))
                {
                    MessageBox.Show("Todos los datos han sido Actualizados");

                    LimpiarText();
                    CargarGrid();

                }
                else
                {
                    MessageBox.Show("Los datos no fueron Actualizados");
                }
            }
        }

        /// <summary>
        /// Metodo load para listar todos los datos de las categorias en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCategoriaInventario_Load(object sender, EventArgs e)
        {

            CargarGrid();
        }

        /// <summary>
        /// Metodo para listar los datos cada vez que se hace una consulta de modifcación
        /// </summary>
        private void CargarGrid()
        {
            List<CategoriaInventario> listar = CategoriaInventario.ListarCategorias();

            DataSet ds = new DataSet();

            dgwCategorias.DataSource = listar;

      
        }

      
    }
}
