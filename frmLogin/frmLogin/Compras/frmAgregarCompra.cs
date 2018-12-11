﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

namespace frmLogin.Compras
{
    public partial class frmAgregarCompra : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public frmAgregarCompra()
        {
            InitializeComponent();
            // Implementado temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Brown500, Accent.Red100, TextShade.WHITE);
        }

        /// <summary>
        /// Metodo
        /// </summary>
        private void CargarCMBProveedores()
        {
            DataTable dt = new DataTable();
            Conexion conexion = new Conexion(@"192.168.0.190","GenisysERP");
            string sql = "select * FROM Clientes.Proveedor";
            SqlCommand cmd = new SqlCommand(sql,conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbProveedore.DisplayMember = "nombreEmpresa";
            cmbProveedore.ValueMember = "nombreEmpresa";
            cmbProveedore.DataSource = dt;
        }

        private void CargarCMBCategoriaProducto()
        {
            DataTable dt3 = new DataTable();
            Conexion conexion = new Conexion(@"192.168.0.190", "GenisysERP");
            string sql = "select * FROM Inventario.Categoria";
            SqlCommand cmd = new SqlCommand(sql, conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt3);
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "nombre";
            cmbCategoria.DataSource = dt3;
        }
        private void frmAgregarCompra_Load(object sender, EventArgs e)
        {
            CargarCMBCategoriaProducto();
            CargarCMBCategoriaProducto();
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnReducirProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
