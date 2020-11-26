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
    public partial class FormKardex : Form
    {
        public FormKardex()
        {
            InitializeComponent();
        }

        int vidProducto;
        private void FormKardex_Load(object sender, EventArgs e)
        {
            ListarProductos();
            KardexDataGridView.DataSource = BLKardex.GetData();
        }

        private void ListarProductos()
        {
            ProductoComboBox.DataSource = BLProducto.GetData();
            ProductoComboBox.DisplayMember = "Articulo";
            ProductoComboBox.ValueMember = "IDProducto";
            ProductoComboBox.SelectedIndex = -1;
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vidProducto = (int)ProductoComboBox.SelectedValue;

                ENTKardex miKardex = BLKardex.SelectKardexByIDProducto(vidProducto);

                var k = new List<ENTKardex>();

                k.Add(miKardex);

                KardexDataGridView.DataSource = null;
                KardexDataGridView.DataSource = k;
            }
            catch (Exception)
            {
            }
        }
    }
}
