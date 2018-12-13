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

using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Empleados
{
    public partial class frmEmpleados : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public string idCargo;
        public string idEmp;
        public string idEmp1;

        public frmEmpleados()
        {
            InitializeComponent();

            //Implementando temas y colores.
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
            llenarCmbEmpleado();


        }

        private void llenarCmbEmpleado()
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [Empleados].[Cargo]";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCargo.Items.Add(rdr["nombre"].ToString());

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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            empleados nuevo = new empleados();
            nuevo.identidad = txtidentidad.Text;
            nuevo.nombre = txtNombre.Text;
            nuevo.apellido = txtApellido.Text;
            nuevo.cargo = Convert.ToInt32(idCargo);
            nuevo.telefono = txtTelefono.Text;
            nuevo.direccion = txtDireccion.Text;
            nuevo.correo = txtCorreo.Text;
            nuevo.estado = 1;
            if (nuevo.InsertarEmpleado(nuevo))
            {
                MessageBox.Show("Exito!");
                llenardgv();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void cmbCargo_TextChanged(object sender, EventArgs e)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [Empleados].[Cargo] WHERE nombre = @nick";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nick", SqlDbType.VarChar).Value = cmbCargo.Text;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idCargo = rdr["id"].ToString();

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

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            llenardgv();
        }

        private void dgvListarEmpleados_DoubleClick(object sender, EventArgs e)
        {
            idEmp = dgvListarEmpleados.CurrentRow.Cells["id"].Value.ToString();
            txtidentidad.Text = dgvListarEmpleados.CurrentRow.Cells["identidad"].Value.ToString();
            txtNombre.Text = dgvListarEmpleados.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = dgvListarEmpleados.CurrentRow.Cells["apellido"].Value.ToString();
            cmbCargo.Text = recuperarNombreCargo(dgvListarEmpleados.CurrentRow.Cells["cargo"].Value.ToString());
            txtTelefono.Text = dgvListarEmpleados.CurrentRow.Cells["telefono"].Value.ToString();
            txtDireccion.Text = dgvListarEmpleados.CurrentRow.Cells["direccion"].Value.ToString();
            txtCorreo.Text = dgvListarEmpleados.CurrentRow.Cells["correo"].Value.ToString();
        }

        protected string recuperarNombreCargo(string id)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysERP");
            string sql;
            // Query SQL
            sql = @"SELECT * FROM [Empleados].[Cargo] WHERE id = @id";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                }
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   return rdr["nombre"].ToString();

                };

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return "error!";
            }
            finally
            {
                conn.CerrarConexion();
            }

            return null;
        }

        protected void llenardgv()
        {
            empleados listar = new empleados();
            dgvListarEmpleados.DataSource = listar.ListarEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            empleados mod = new empleados();
            mod.id = Convert.ToInt32(idEmp);
            mod.identidad = txtidentidad.Text;
            mod.nombre = txtNombre.Text;
            mod.apellido = txtApellido.Text;
            mod.cargo = Convert.ToInt32(idCargo);
            mod.telefono = txtTelefono.Text;
            mod.direccion = txtDireccion.Text;
            mod.correo = txtCorreo.Text;
            mod.estado = 1;
            if (mod.ActualizarEmpleado(mod))
            {
                MessageBox.Show("Exito!");
                llenardgv();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            empleados inhab = new empleados();    
            if (inhab.InhabilitarEmpleado(idEmp1))
            {
                MessageBox.Show("Exito!");
                llenardgv();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void dgvListarEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            int x;
            idEmp1 = dgvListarEmpleados.CurrentRow.Cells["id"].Value.ToString();
            x = Convert.ToInt32(dgvListarEmpleados.CurrentRow.Cells["estado"].Value.ToString());
            if (x == 1)
            {
                btnInhabilitar.BringToFront();
            }
            else
            {
                btnHabilitar.BringToFront();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            empleados hab = new empleados();
            if (hab.habilitarEmpleado(idEmp1))
            {
                MessageBox.Show("Exito!");
                llenardgv();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
            

        }

        private void txtNombreEmpleadoBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            empleados lis = new empleados();
            dgvListarEmpleados.DataSource = lis.ListarEmpleadosUnico(txtNombreEmpleadoBuscar.Text);
        }
    }
}
