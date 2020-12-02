using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCompras : Form
    {
        List<ENTCompraDetalle> misDetalles = new List<ENTCompraDetalle>();
        int vidProducto;

        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarProductos();
        }

        private void CargarProductos()
        {
            ProductoComboBox.DataSource = BLProducto.GetData();
            ProductoComboBox.DisplayMember = "Articulo";
            ProductoComboBox.ValueMember = "IDProducto";
            ProductoComboBox.SelectedIndex = -1;
        }

        private void CargarProveedores()
        {
            ProveedorComboBox.DataSource = BLProveedor.GetData();
            ProveedorComboBox.DisplayMember = "Empresa";
            ProveedorComboBox.ValueMember = "IDProveedor";
            ProveedorComboBox.SelectedIndex = -1;
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            ENTCompraDetalle cd = new ENTCompraDetalle();

            cd.Cantidad = float.Parse(CantidadTextBox.Text);
            cd.CostoUnitario = Convert.ToDecimal(CostoUnitarioTextBox.Text);
            cd.Descripcion = DescripcionTextBox.Text;
            cd.IDCompra = 1; // OJO
            cd.IDKardex = 1; // OJO
            cd.IDProducto = vidProducto;

        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vidProducto = (int)ProductoComboBox.SelectedValue;
            }
            catch (Exception)
            {
            }
        }
    }
}
