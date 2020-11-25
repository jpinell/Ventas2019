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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private int vidCategoria, vidPresentacion;

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
            ListarCategorias();
            ListarPresentacion();
        }

        private void ListarPresentacion()
        {
            PresentacionComboBox.DataSource = BLPresentacion.GetData();
            PresentacionComboBox.DisplayMember = "Descripcion";
            PresentacionComboBox.ValueMember = "IDPresentacion";
            PresentacionComboBox.SelectedIndex = -1;
        }

        private void ListarCategorias()
        {
            CategoriaComboBox.DataSource = BLCategoria.GetData();
            CategoriaComboBox.DisplayMember = "Categoria";
            CategoriaComboBox.ValueMember = "IDCategoria";
            CategoriaComboBox.SelectedIndex = -1;
        }

        private void ListarProductos()
        {
            ProductoDataGridView.DataSource = BLProducto.GetData();
        }

        private void AbrirCategoriasButton_Click(object sender, EventArgs e)
        {
            FormCategorias form = new FormCategorias();
            form.ShowDialog();
        }

        private void AbrirPresentacionButton_Click(object sender, EventArgs e)
        {
            FormPresentacion form = new FormPresentacion();
        }

        private void PresentacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vidPresentacion = (int)PresentacionComboBox.SelectedValue;
            }
            catch (Exception)
            {
            }
        }

        private void CategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                vidCategoria = (int)CategoriaComboBox.SelectedValue;
            }
            catch (Exception)
            {
            }
        }
    }
}
