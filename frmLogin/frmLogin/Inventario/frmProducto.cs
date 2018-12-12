using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//using GenisysERP.Inventario;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Inventario
{
    public partial class frmProducto : MaterialForm
    {
        public string idUsuario;
        public string idimpuesto;
        public string idCategoria;
        public string idProveedor;
        public string idProducto;
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
            llenarComboBox();
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
        }

            // metodo para autocompletar el combo box
            private AutoCompleteStringCollection CargarDatos()
            {
                AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
                Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
                                // Query SQL
                string sql = @"SELECT * FROM [Inventario].[Producto] WHERE Estado = 1";

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


        private void llenarComboBox()
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM Inventario.Impuesto";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbIdImpuesto.Items.Add(rdr["valor"].ToString());
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

            //

            Conexion conn1 = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql1;
            // Query SQL
            sql1 = @"SELECT * FROM Inventario.Categoria";

            SqlCommand cmd1 = conn1.EjecutarComando(sql1);
            SqlDataReader rdr1;

            try
            {
                rdr1 = cmd1.ExecuteReader();

                while (rdr1.Read())
                {
                    cmbIdCategoria.Items.Add(rdr1["nombre"].ToString());
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

            //

            Conexion conn2 = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql2;
            // Query SQL
            sql2 = @"SELECT * FROM Clientes.Proveedor";

            SqlCommand cmd2 = conn2.EjecutarComando(sql2);
            SqlDataReader rdr2;

            try
            {
                rdr2 = cmd2.ExecuteReader();

                while (rdr2.Read())
                {
                    cmbIdProveedor.Items.Add(rdr2["nombreEmpresa"].ToString());
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
                Nuevo.idImpuesto = Convert.ToInt32(idimpuesto);
                Nuevo.IdCategoria = Convert.ToInt32(idCategoria);
                Nuevo.idProveedor = Convert.ToInt32(idProveedor);
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
            dgvInventario.DataSource = listar.LeerTodos();
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
                    cmd.Parameters.Add("@idProducto", SqlDbType.VarChar, 80).Value = cmbCodigoProducto.Text;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idProducto = rdr["IdProducto"].ToString();

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
            if (inhabilitar.InhabilitarProducto(idProducto))
            {
                MessageBox.Show("Exito!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void cmbIdImpuesto_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM Inventario.Impuesto WHERE valor = @value";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = cmbIdImpuesto.Text;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idimpuesto = rdr["idImpuesto"].ToString();

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

        private void cmbIdCategoria_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM Inventario.Categoria WHERE nombre = @value";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = cmbIdCategoria.Text;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idCategoria = rdr["idImpuesto"].ToString();

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

        private void cmbIdProveedor_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM Clientes.Proveedor WHERE nombreEmpresa = @value";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = cmbIdProveedor.Text;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idCategoria = rdr["idImpuesto"].ToString();

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

        private void dgvInventario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNombre.Text = dgvInventario.CurrentRow.Cells["nombre"].Value.ToString();
        }
    }
}
