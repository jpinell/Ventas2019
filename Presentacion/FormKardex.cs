using CapaNegocios;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormKardex : Form
    {
        public FormKardex()
        {
            InitializeComponent();
        }

        private int vidProducto;

        private void FormKardex_Load(object sender, EventArgs e)
        {
            ListarProductos();
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

                //ENTKardex miKardex = BLKardex.SelectKardexByIDProducto(vidProducto);
                //List<ENTKardex> k = new List<ENTKardex>();
                //k.Add(miKardex);

                KardexDataGridView.DataSource = null;
                KardexDataGridView.DataSource = BLKardex.SelectKardex(vidProducto);

                BLFormatoGrid.FormatoGrid(KardexDataGridView);

                FormatoColumnas();
            }
            catch (Exception)
            {
            }
        }

        private void FormatoColumnas()
        {
            KardexDataGridView.Columns["IDKardex"].Visible = false;
            KardexDataGridView.Columns["IDProducto"].Visible = false;

            KardexDataGridView.Columns["Fecha"].DefaultCellStyle.Format = "d";

            KardexDataGridView.Columns["Entrada"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            KardexDataGridView.Columns["Salida"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["Salida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            KardexDataGridView.Columns["Existencia"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            KardexDataGridView.Columns["CostoUnitario"].HeaderText = "C. Unitario";
            KardexDataGridView.Columns["CostoUnitario"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["CostoUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            KardexDataGridView.Columns["Debe"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["Debe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            KardexDataGridView.Columns["Haber"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["Haber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            KardexDataGridView.Columns["Saldo"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            KardexDataGridView.Columns["CostoPromedio"].HeaderText = "C. Promedio";
            KardexDataGridView.Columns["CostoPromedio"].DefaultCellStyle.Format = "N2";
            KardexDataGridView.Columns["CostoPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
    }
}