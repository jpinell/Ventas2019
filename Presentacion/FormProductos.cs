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
            //Establecer formato personalizado al DataGridView
            BLFormatoGrid.FormatoGrid(ProductoDataGridView);
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
            form.ShowDialog();
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
        }

        private bool ValidarCampos()
        {
            if (CategoriaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(AbrirCategoriasButton, "Seleccione la Categoría");
                CategoriaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (CantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CantidadTextBox, "Ingrese la cantidad");
                CantidadTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //VALIDAR DATOS NUMERICOS, MAYOR QUE CERO, ETC.

            if (ArticuloTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ArticuloTextBox, "Ingrese el Nombre del Artículo");
                ArticuloTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (CostoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CostoTextBox, "Ingrese el Costo del Artículo");
                CostoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //VALIDAR DATOS NUMERICOS, MAYOR QUE CERO, ETC.

            if (PresentacionComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(AbrirPresentacionButton, "Seleccione la Presentación del Artículo");
                PresentacionComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
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
