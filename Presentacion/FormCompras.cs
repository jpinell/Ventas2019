using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCompras : Form
    {
        private List<ENTCompraDetalle> misDetalles = new List<ENTCompraDetalle>();

        private int vidProveedor, vidProducto;
        private decimal TotalFactura;

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
            if (!ValidarCampos()) return;
            {
                ENTCompraDetalle miDetalle = new ENTCompraDetalle();

                miDetalle.Cantidad = float.Parse(CantidadTextBox.Text);
                miDetalle.CostoUnitario = Convert.ToDecimal(CostoUnitarioTextBox.Text);
                miDetalle.Descripcion = DescripcionTextBox.Text;
                miDetalle.IDProducto = vidProducto;
                misDetalles.Add(miDetalle);

                CargarDatos();

                CantidadTextBox.Text = string.Empty;
                ProductoComboBox.SelectedIndex = -1;
                DescripcionTextBox.Text = string.Empty;
                CostoUnitarioTextBox.Text = string.Empty;
                CantidadTextBox.Focus();
            }
        }

        private void CargarDatos()
        {
            DetallesDataGridView.DataSource = null;
            DetallesDataGridView.DataSource = misDetalles;

            TotalFactura = 0;
            //Actualiza los totales
            foreach (ENTCompraDetalle cd in misDetalles)
            {
                TotalFactura += cd.SubTotal;
            }

            TotalFacturaTextBox.Text = string.Format("{0:N2}", TotalFactura);

            FormatoDatos();
        }

        private void FormatoDatos()
        {
            DetallesDataGridView.Columns["IDCompraDetalle"].Visible = false;
            DetallesDataGridView.Columns["IDCompra"].Visible = false;

            DetallesDataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            DetallesDataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DetallesDataGridView.Columns["CostoUnitario"].DefaultCellStyle.Format = "N2";
            DetallesDataGridView.Columns["CostoUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DetallesDataGridView.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            DetallesDataGridView.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            BLFormatoGrid.FormatoGrid(DetallesDataGridView);
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

        private void AbrirProductosButton_Click(object sender, EventArgs e)
        {
            int Cantidad = 0;
            int Precio = 0;
            FormProductos form = new FormProductos(Cantidad, Precio);

            form.ShowDialog();

            CargarProductos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            // GUARDAR EN COMPRAS Y COMPRAS DETALLES
            ENTCompra compra = new ENTCompra();
            compra.Fecha = FechaDateTimePicker.Value;
            compra.IDProveedor = vidProveedor;
            compra.NoFactura = FacturaTextBox.Text;

            using (var scope = new TransactionScope())
            {
                //INSERTA LA COMPRA Y RETORNA EL ID
                int IDCompra = BLCompra.InsertComprasGetIDCompra(compra);

                //RECORRE EL DATAGRID Y LO INSERTA EN LA TABLA COMPRADETALLE
                ENTCompraDetalle Registros = new ENTCompraDetalle();

                foreach (DataGridViewRow filas in DetallesDataGridView.Rows)
                {
                    Registros.Cantidad = float.Parse(filas.Cells["Cantidad"].Value.ToString());
                    Registros.CostoUnitario = decimal.Parse(filas.Cells["CostoUnitario"].Value.ToString());
                    Registros.Descripcion = filas.Cells["Descripcion"].Value.ToString();
                    Registros.IDProducto = int.Parse(filas.Cells["IDProducto"].Value.ToString());
                    Registros.IDCompra = IDCompra;

                    misDetalles.Add(Registros);

                    BLCompraDetalle.InsertCompraDetalle(Registros);

                    //GUARDAR EN KARDEX
                    ENTKardex miKardex = BLKardex.SelectKardexByIDProducto(Registros.IDProducto);
                    float Existencia = miKardex.Existencia;
                    decimal Saldo = miKardex.Saldo;
                    decimal CostoPromedio = miKardex.CostoPromedio;

                    //GRABAR EN KARDEX
                    ENTKardex kardex = new ENTKardex();
                    kardex.Fecha = FechaDateTimePicker.Value;
                    kardex.Concepto = "CO-" + IDCompra;
                    kardex.Entrada = Registros.Cantidad;
                    kardex.Existencia = Existencia + Registros.Cantidad;
                    kardex.CostoUnitario = Registros.CostoUnitario;
                    kardex.Debe = Convert.ToDecimal(kardex.Entrada) * kardex.CostoUnitario;
                    kardex.Saldo = Saldo + kardex.Debe;
                    kardex.CostoPromedio = kardex.Saldo / (decimal)kardex.Existencia;
                    kardex.IDProducto = Registros.IDProducto;

                    BLKardex.InsertKardex(kardex);

                    //Obtiene un último costo para agregarlo al precio del producto
                    decimal UltimoCosto = BLKardex.GetUltimoCosto(Registros.IDProducto);

                    // ACTUALIZAR LA TABLA PRODUCTOS
                    BLProducto.UpdatePrecioProductoByIDProducto(kardex.Existencia, UltimoCosto, kardex.IDProducto);
                }

                scope.Complete();

                MessageBox.Show(string.Format("La compra: {0}, fue grabada de forma exitosa", IDCompra),
                "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            if (ProveedorComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ProveedorComboBox, "Seleccione un Proveedor");
                ProveedorComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (FacturaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(FacturaTextBox, "Ingrese el Número de la Factura");
                FacturaTextBox.Focus();
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

            if (!float.TryParse(CantidadTextBox.Text, out float cantidad))
            {
                errorProvider1.SetError(CantidadTextBox, "Debe ingresar un valor numérico entero");
                CantidadTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(CantidadTextBox, "Debe ingresar un valor mayor a cero");
                CantidadTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (ProductoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(AbrirProductosButton, "Seleccione un producto");
                ProductoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //if (DescripcionTextBox.Text == string.Empty)
            //{
            //    errorProvider1.SetError(DescripcionTextBox, "Ingrese la descripción del producto");
            //    DescripcionTextBox.Focus();
            //    return false;
            //}
            //errorProvider1.Clear();

            if (CostoUnitarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CostoUnitarioTextBox, "Ingrese el Costo del Producto");
                CostoUnitarioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (!decimal.TryParse(CostoUnitarioTextBox.Text, out decimal costo))
            {
                errorProvider1.SetError(CostoUnitarioTextBox, "Debe ingresar un valor numérico entero");
                CostoUnitarioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (costo <= 0)
            {
                errorProvider1.SetError(CostoUnitarioTextBox, "Debe ingresar un valor mayor a cero");
                CostoUnitarioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void FormCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (misDetalles.Count != 0)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro de cerrar el formulario de compras" +
                " y perder los registros ingresados?", "C O M P R A S", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ProveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vidProveedor = (int)ProveedorComboBox.SelectedValue;
            }
            catch (Exception)
            {
            }
        }

        //ELIMINAR FILA
        //RECORREMOS LOS ELEMENTOS GUARDADOS EN LA LISTA
        //        for (int i = 0; i<misDetallesFactura.Count; i++)
        //        {
        //            //COMPROBAMOS QUE LA FILA SELECCIONADA ES IGUAL AL DE LA LISTA
        //            if (i == fila)
        //            {
        //                misDetallesFactura.RemoveAt(fila);
        //            }

        ////ACTUALIZAMOS LA LISTA Y EL DATAGRIDVIEW
        //dgv.DataSource = null;
        //            dgv.DataSource = misDetallesFactura;
        //        }

        //FILA ACTUAL
        //NUMERO DE FILA EN EL DATAGRIDVIEW
        //fila = dgv.CurrentRow.Index;

        //    lblFila.Text = "Fila: " + fila.ToString();
    }
}