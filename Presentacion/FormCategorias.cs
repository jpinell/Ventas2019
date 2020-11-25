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
    public partial class FormCategorias : Form
    {
        ENTCategoria categoria = new ENTCategoria();
        public FormCategorias()
        {
            InitializeComponent();
        }

        int vidCategoria;

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            HabilitarBotones(true);
        }

        private void ListarCategorias()
        {
            CategoriaDataGridView.DataSource = BLCategoria.GetData();
            CategoriaDataGridView.Columns[0].Visible = false;
            CategoriaDataGridView.Columns[2].HeaderText = "Descripción";
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HabilitarBotones(bool activo)
        {
            //ACTIVA O DESACTIVA LOS BOTONES
            GuardarButton.Enabled = activo;
            ActualizarButton.Enabled = !activo;
            EliminarButton.Enabled = !activo;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            HabilitarBotones(true);
            errorProvider1.Dispose(); //QUITAR EL ICONO DEL ERROR!!!
        }

        private void LimpiarCajas()
        {
            //LIMPIA LAS CAJAS DE TEXTO
            CategoriaTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            CategoriaTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            categoria.Categoria = CategoriaTextBox.Text;
            categoria.Descripcion = DescripcionTextBox.Text;

            //GUARDAR EL REGISTRO
            BLCategoria.InsertCategorias(categoria);

            ListarCategorias();
            LimpiarCajas();

        }

        private bool ValidarCampos()
        {
            if (CategoriaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CategoriaTextBox, "Ingrese el Nombre de la Categoría");
                CategoriaTextBox.Focus();
                return false;
            }

            return true;
        }

        private void CategoriaDataGridView_Click(object sender, EventArgs e)
        {
            if (CategoriaDataGridView.Rows.Count == 0) return;
            vidCategoria = (int)CategoriaDataGridView.CurrentRow.Cells[0].Value;
            CategoriaTextBox.Text = CategoriaDataGridView.CurrentRow.Cells[1].Value.ToString();
            DescripcionTextBox.Text = CategoriaDataGridView.CurrentRow.Cells[2].Value.ToString();

            HabilitarBotones(false);
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            categoria.IDCategoria = vidCategoria;
            categoria.Categoria = CategoriaTextBox.Text;
            categoria.Descripcion = DescripcionTextBox.Text;

            //ACTUALIZAR EL REGISTRO
            BLCategoria.UpdateCategorias(categoria);

            LimpiarCajas();
            HabilitarBotones(true);
            ListarCategorias();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Está seguro de borrar el registro actual?",
           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                LimpiarCajas();
                HabilitarBotones(true);
                return;
            }

            BLCategoria.DeleteCategorias(vidCategoria);

            LimpiarCajas();
            HabilitarBotones(true);
            ListarCategorias();
        }
    }
}
