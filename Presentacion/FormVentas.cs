using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormVentas : Form
    {
        private readonly List<ENTVentaDetalle> misDetalles = new List<ENTVentaDetalle>();

        private int vidProducto, IDVenta;

        private decimal TotalFactura;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
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

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            {
                ENTVentaDetalle miDetalle = new ENTVentaDetalle
                {
                    Cantidad = float.Parse(CantidadTextBox.Text),
                    Precio = Convert.ToDecimal(PrecioTextBox.Text),
                    Descripcion = DescripcionTextBox.Text,
                    IDProducto = vidProducto
                };
                misDetalles.Add(miDetalle);

                CargarDatos();

                CantidadTextBox.Text = string.Empty;
                ProductoComboBox.SelectedIndex = -1;
                DescripcionTextBox.Text = string.Empty;
                PrecioTextBox.Text = string.Empty;
                CantidadTextBox.Focus();
            }
        }

        private void CargarDatos()
        {
            DetallesDataGridView.DataSource = null;
            DetallesDataGridView.DataSource = misDetalles;

            TotalFactura = 0;
            //Actualiza los totales
            foreach (ENTVentaDetalle cd in misDetalles)
            {
                TotalFactura += cd.SubTotal;
            }

            TotalFacturaTextBox.Text = string.Format("{0:N2}", TotalFactura);

            FormatoDatos();
        }

        private void FormatoDatos()
        {
            DetallesDataGridView.Columns["IDVentaDetalle"].Visible = false;
            DetallesDataGridView.Columns["IDVenta"].Visible = false;

            DetallesDataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            DetallesDataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DetallesDataGridView.Columns["Precio"].DefaultCellStyle.Format = "N2";
            DetallesDataGridView.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DetallesDataGridView.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            DetallesDataGridView.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            BLFormatoGrid.FormatoGrid(DetallesDataGridView);
        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                vidProducto = (int)ProductoComboBox.SelectedValue;

                CalcularPrecioVenta();
            }
            catch (Exception)
            {
            }
        }

        private void CalcularPrecioVenta()
        {
            ENTProducto producto = BLProducto.SelectProductoByIDProducto(vidProducto);
            int Porcentaje = (int)PorcentajeVentaNUD.Value;
            decimal Costo, Precio;
            ExistenciasTextBox.Text = string.Format("{0:N2}", producto.Cantidad);
            DescripcionTextBox.Text = producto.Descripcion;
            CostoTextBox.Text = string.Format("{0:N2}", producto.Precio);
            Costo = Convert.ToDecimal(CostoTextBox.Text);
            Precio = Costo + decimal.Multiply(Porcentaje, Costo) / 100;
            PrecioTextBox.Text = string.Format("{0:N2}", Precio);
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
            // OBTENEMOS LOS DATOS PARA GUARDARLOS EN LA TABLA COMPRAS
            ENTVenta venta = new ENTVenta
            {
                Fecha = FechaDateTimePicker.Value,
                NoFactura = FacturaTextBox.Text
            };

            using (TransactionScope scope = new TransactionScope())
            {
                //INSERTA LA COMPRA Y RETORNA EL ID
                try
                {
                    IDVenta = BLVenta.InsertVentasGetIDVenta(venta);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("IX_Ventas"))
                    {
                        errorProvider1.SetError(FacturaTextBox, "Número de Factura ya Existe...!");
                        FacturaTextBox.Focus();
                        return;
                    }
                    errorProvider1.Clear();
                }

                //RECORRE EL DATAGRID Y LO INSERTA EN LA TABLA COMPRADETALLE
                ENTVentaDetalle Registros = new ENTVentaDetalle();

                foreach (DataGridViewRow filas in DetallesDataGridView.Rows)
                {
                    Registros.Cantidad = float.Parse(filas.Cells["Cantidad"].Value.ToString());
                    Registros.Precio = decimal.Parse(filas.Cells["Precio"].Value.ToString());
                    Registros.Descripcion = filas.Cells["Descripcion"].Value.ToString();
                    Registros.IDProducto = int.Parse(filas.Cells["IDProducto"].Value.ToString());
                    Registros.IDVenta = IDVenta;

                    misDetalles.Add(Registros);

                    BLVentaDetalle.InsertVentaDetalle(Registros);

                    //GUARDAR EN KARDEX
                    ENTKardex miKardex = BLKardex.SelectKardexByIDProducto(Registros.IDProducto);
                    float Existencia = miKardex.Existencia;
                    decimal Saldo = miKardex.Saldo;
                    decimal CostoPromedio = miKardex.CostoPromedio;

                    //GRABAR EN KARDEX
                    ENTKardex kardex = new ENTKardex
                    {
                        Fecha = FechaDateTimePicker.Value,
                        Concepto = "VE-" + IDVenta,
                        Salida = Registros.Cantidad,
                        Existencia = Existencia - Registros.Cantidad
                    };
                    //kardex.CostoUnitario = Registros.CostoUnitario; //POR AQUI
                    kardex.Haber = Convert.ToDecimal(kardex.Salida) * CostoPromedio;
                    kardex.Saldo = Saldo - kardex.Haber;
                    try
                    {
                        kardex.CostoPromedio = kardex.Saldo / (decimal)kardex.Existencia;
                    }
                    catch (DivideByZeroException ex)
                    {
                        kardex.CostoPromedio = 0;
                    }

                    kardex.IDProducto = Registros.IDProducto;

                    BLKardex.InsertKardex(kardex);

                    ////Obtiene un último costo para agregarlo al precio del producto
                    //decimal UltimoCosto = BLKardex.GetUltimoCosto(Registros.IDProducto);

                    // ACTUALIZAR LA TABLA PRODUCTOS
                    BLProducto.UpdateCantidadVenta(kardex.Existencia, kardex.IDProducto);
                }

                scope.Complete();

                MessageBox.Show(string.Format("La venta: {0}, fue grabada de forma exitosa", IDVenta),
                "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {

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
            float Existencias = float.Parse(ExistenciasTextBox.Text);
            if(Existencias < cantidad)
            {
                errorProvider1.SetError(ExistenciasTextBox, "No hay productos suficientes para esta venta");
                ExistenciasTextBox.Focus();
                return false;
            }

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

            if (DescripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripcionTextBox, "Ingrese la descripción del producto");
                DescripcionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (PrecioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioTextBox, "Ingrese el Costo del Producto");
                PrecioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (!decimal.TryParse(PrecioTextBox.Text, out decimal precio))
            {
                errorProvider1.SetError(PrecioTextBox, "Debe ingresar un valor numérico entero");
                PrecioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precio <= 0)
            {
                errorProvider1.SetError(PrecioTextBox, "Debe ingresar un valor mayor a cero");
                PrecioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void PorcentajeVentaNUD_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

        private void FormVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (misDetalles.Count != 0)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro de cerrar el formulario de ventas" +
                " y perder los registros ingresados?", "V E N T A S", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}