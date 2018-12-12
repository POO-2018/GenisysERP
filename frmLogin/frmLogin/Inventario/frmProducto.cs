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

        // metodo para llenar el combobox
        private void llenarComboBox()
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL para impuesto
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

            // LLenar combo box parte de Categoria

            Conexion conn1 = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql1;
            // Query SQL para categoria
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

            // llenar combo box pare de Proveedor 

            Conexion conn2 = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql2;
            // Query SQL para tabla proveerdor
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
//------------------------------------------------------------------------------------------------//
        // agregar los nuevos datos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text.Trim() == "" || txtNombre.Text.Trim() == "" || numericExistencia.Value == 0 || numericCantidadMinima.Value == 0 || numericPrecioCompra.Value == 0 || numericPrecioVenta.Value == 0 || cmbIdImpuesto.Text.Trim() == "" || cmbIdCategoria.Text.Trim() == "" || cmbIdProveedor.Text.Trim() == "" || txtObservaciones.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar todos los datos!");
            }
            else
            {
                Inventario.Producto Nuevo = new Inventario.Producto();
                Nuevo.idProducto = txtCodigoProducto.Text;
                Nuevo.nombre = txtNombre.Text;
                Nuevo.cantidadExistencia = Convert.ToInt32(numericExistencia.Value);
                Nuevo.cantidadMinima = Convert.ToInt32(numericCantidadMinima.Value);
                Nuevo.precioCompra = Convert.ToInt32(numericPrecioCompra.Value);
                Nuevo.precioVenta = Convert.ToInt32(numericPrecioVenta.Value);
                Nuevo.idImpuesto = Convert.ToInt32(idimpuesto);
                Nuevo.IdCategoria = Convert.ToInt32(idCategoria);
                Nuevo.idProveedor = Convert.ToInt32(idProveedor);
                Nuevo.idUsuario = 1;
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

        // Inhabilitar un producto
        private void btnInhabilitar_Click_1(object sender, EventArgs e)
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

        // habilitar un producto
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            Inventario.Producto habilitar = new Inventario.Producto();
            if (habilitar.HabilitarProducto(idProducto))
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
                    idCategoria = rdr["idCategoria"].ToString();

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
                    idProveedor = rdr["idProveedor"].ToString();

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

        // Llenar el data grid view
        private void dgvInventario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCodigoProducto.Text = dgvInventario.CurrentRow.Cells["idProducto"].Value.ToString();
            txtNombre.Text = dgvInventario.CurrentRow.Cells["nombre"].Value.ToString();
            numericExistencia.Text = dgvInventario.CurrentRow.Cells["cantidadExistencia"].Value.ToString();
            numericCantidadMinima.Text = dgvInventario.CurrentRow.Cells["cantidadMinima"].Value.ToString();
            numericPrecioCompra.Text = dgvInventario.CurrentRow.Cells["precioCompra"].Value.ToString();
            numericPrecioVenta.Text = dgvInventario.CurrentRow.Cells["precioVenta"].Value.ToString();
            cmbIdImpuesto.Text = recuperarNombreImpuesto(dgvInventario.CurrentRow.Cells["idImpuesto"].Value.ToString());
            cmbIdCategoria.Text = recuperarNombreCategoria(dgvInventario.CurrentRow.Cells["idCategoria"].Value.ToString());
            cmbIdProveedor.Text = recuperarNombreProveedor(dgvInventario.CurrentRow.Cells["idProveedor"].Value.ToString());
            txtObservaciones.Text = dgvInventario.CurrentRow.Cells["observaciones"].Value.ToString();

        }

        // Metodo para mandar a traer el nombre del impuesto 
        // que se encuentra en la tabla impuesto
        public string recuperarNombreImpuesto(string id)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            string dato = null;
            // Query SQL
            sql = @"SELECT * FROM Inventario.Impuesto where idImpuesto = @value";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {

                using (cmd)
                {
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = id;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dato = rdr["valor"].ToString();
                    return dato;
                };


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return dato;
                
            }
            finally
            {
                conn.CerrarConexion();
            }

            return null;
        }

        // Metodo para mandar a traer el nombre de la categoria
        // que se encuentra en la tabla impuesto
        public string recuperarNombreCategoria(string id)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            string dato = null;
            // Query SQL
            sql = @"SELECT * FROM Inventario.Categoria where idCategoria = @value";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {

                using (cmd)
                {
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = id;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dato = rdr["nombre"].ToString();
                    return dato;
                };


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return dato;
                
            }
            finally
            {
                conn.CerrarConexion();
            }

            return null;
        }

        // Metodo para mandar a traer el nombre del proveedor 
        // que se encuentra en la tabla Proveedor
        public string recuperarNombreProveedor(string id)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            string dato = null;
            // Query SQL
            sql = @"SELECT * FROM Clientes.Proveedor where idProveedor = @value";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {

                using (cmd)
                {
                    cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = id;

                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dato = rdr["nombreEmpresa"].ToString();
                    return dato;
                };


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return dato;
            }
            finally
            {
                conn.CerrarConexion();
            }
            return null;
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
