using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using GenisysERP.Inventario;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Inventario
{
    public partial class frmProducto : MaterialForm
    {
        public string idUsuario;
        private MaterialSkinManager materialSkinManager;

        public frmProducto(string x)
        {
            InitializeComponent();
            idUsuario = x;
            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);

            // Conectar con la base de datos
            // Nos servirá para poder realizar la búsqueda de producto 
            // Filtrando por nombre
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysARP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [Inventario].[Producto] WHERE Estado = 1";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCodigoProducto.Items.Add(rdr["idInventario"].ToString());
                    cmbCodigoProducto.AutoCompleteCustomSource = CargarDatos();
                    cmbCodigoProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cmbCodigoProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                };

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
            }
            finally
            {
                conn.CerrarConexion();
            }

            // metodo para autocompletar el combo box
            private AutoCompleteStringCollection CargarDatos()
            {
                AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
                Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
                string sql;
                // Query SQL
                sql = @"SELECT * FROM [Inventario].[Producto] WHERE Estado = 1";

                SqlCommand cmd = conn.EjecutarComando(sql);
                SqlDataReader rdr;

                try
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        datos.Add(rdr["idProducto"].ToString());

                    };

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                }
                finally
                {
                    conn.CerrarConexion();
                }
                return datos;
            }
        }
        // agregar los nuevos datos
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (cmbCodigoProducto.Text.Trim() == "" || txtNombre.Text.Trim() == "" || numericExistencia.Value == 0 || numericCantidadMinima.Value == 0 || numericPrecioCompra.Value == 0 || numericPrecioVenta.Value == 0 || cmbIdImpuesto.Text.Trim() == "" || cmbIdCategoria.Text.Trim() == "" || cmbIdProveedor.Text.Trim() == "" || txtObservaciones.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar todos los datos!");
            }
            else
            {
                Inventario.Producto Nuevo = new Inventario.Producto();
                Nuevo.idProducto = Convert.ToInt32(cmbCodigoProducto.Text);
                Nuevo.nombre = txtNombre.Text;
                Nuevo.cantidadExistencia = Convert.ToInt32(numericExistencia.Value);
                Nuevo.cantidadMinima = Convert.ToInt32(numericCantidadMinima.Value);
                Nuevo.precioCompra = Convert.ToInt32(numericPrecioCompra.Value);
                Nuevo.precioVenta = Convert.ToInt32(numericPrecioVenta.Value);
                Nuevo.idImpuesto =
                Nuevo.IdCategoria =
                Nuevo.idProveedor =
                Nuevo.observaciones = txtObservaciones.Text;

                if (Nuevo.InsertarProducto(Nuevo))
                {
                    MessageBox.Show("Exito");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }



        private void frmProducto_Load(object sender, EventArgs e)
        {
            Inventario.Producto listar = new Inventario.Producto();
            dvgInventario.DataSource = listar.LeerTodos();
        }

        private void cmbCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [Inventario].[Producto] WHERE idProducto = @idProducto";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("idProducto", SqlDbType.VarChar, 80).Value = cmbCodigoProducto.Text;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    buscar = rdr["IdProducto"].ToString();

                };

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Inventario.Producto inhabilitar = new Inventario.Producto();
            if (inhabilitar.InhabilitarProducto(x))
            {
                MessageBox.Show("Exito!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
