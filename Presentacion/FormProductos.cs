﻿using CapaEntidades;
using CapaNegocios;
using System;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }


        public FormProductos(int Cantidad, int Precio)
        {
            InitializeComponent();

            /* Cuando se llama desde el boton de agregar nuevo producto desde el formulario
             * de compras, se llama a este constructor y pone en valor 0 la caja de texto
             * Cantidad y Precio.
             */
            CantidadTextBox.Text = Cantidad.ToString();
            CantidadTextBox.ReadOnly = true;
            PrecioTextBox.Text = Precio.ToString();
            PrecioTextBox.ReadOnly = true;
        }

        private int vidCategoria, vidPresentacion; // vidProducto;

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region PLACEHOLDER
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        #endregion

        private void FormProductos_Load(object sender, EventArgs e)
        {
            //CantidadTextBox.Text = FormCompras.can

            ListarProductos();
            //Establecer formato personalizado al DataGridView
            BLFormatoGrid.FormatoGrid(ProductoDataGridView);
            ListarCategorias();
            ListarPresentacion();
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);

            SendMessage(ArticuloTextBox.Handle, EM_SETCUEBANNER, 0, "Nombre del Artículo"); //PLACEHOLDER

            //Inhabilitar click derecho y boton teclado de opction menu
            ContextMenu _blankContextMenu = new ContextMenu();
            ArticuloTextBox.ContextMenu = _blankContextMenu;
            PrecioTextBox.ContextMenu = _blankContextMenu;
            DescripcionTextBox.ContextMenu = _blankContextMenu;

        }

        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        private const Keys CutKeys = Keys.Control | Keys.X;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys) || (keyData == CutKeys))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
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
            ListarCategorias();
        }

        private void AbrirPresentacionButton_Click(object sender, EventArgs e)
        {
            FormPresentacion form = new FormPresentacion();
            form.ShowDialog();
            ListarPresentacion();
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

            ENTProducto producto = new ENTProducto
            {
                Articulo = ArticuloTextBox.Text,
                Cantidad = float.Parse(CantidadTextBox.Text),
                Precio = Convert.ToDecimal(PrecioTextBox.Text),
                Descripcion = DescripcionTextBox.Text,
                IDCategoria = vidCategoria,
                IDPresentacion = vidPresentacion
            };

            using (var scope = new TransactionScope())
            {
                //INSERTA EL PRODUCTO Y CAPTURA EL IDProducto
                int IDProducto = BLProducto.InsertProductoGetIDProducto(producto);

                //GRABAR EN KARDEX
                ENTKardex kardex = new ENTKardex();
                kardex.Fecha = DateTime.Now;
                kardex.Concepto = "INVENTARIO INICIAL";
                kardex.Entrada = float.Parse(CantidadTextBox.Text);
                kardex.Existencia = float.Parse(CantidadTextBox.Text);
                kardex.CostoUnitario = Convert.ToDecimal(PrecioTextBox.Text);
                kardex.Debe = Convert.ToDecimal(kardex.Entrada) * kardex.CostoUnitario;
                kardex.Saldo = kardex.Debe;
                kardex.CostoPromedio = kardex.CostoUnitario;
                kardex.IDProducto = IDProducto;

                BLKardex.InsertKardex(kardex);

                scope.Complete();
            }

            ListarProductos();
            LimpiarCajas();
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
        }

        private void LimpiarCajas()
        {
            CategoriaComboBox.SelectedIndex = -1;
            CantidadTextBox.Text = string.Empty;
            ArticuloTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            PresentacionComboBox.SelectedIndex = -1;
            CategoriaComboBox.Focus();
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

            if (ArticuloTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ArticuloTextBox, "Ingrese el Nombre del Artículo");
                ArticuloTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (PrecioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioTextBox, "Ingrese el Costo del Artículo");
                PrecioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if(!decimal.TryParse(PrecioTextBox.Text, out decimal costo))
            {
                errorProvider1.SetError(PrecioTextBox, "Debe ingresar un valor numérico entero");
                PrecioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (costo <= 0)
            {
                errorProvider1.SetError(PrecioTextBox, "Debe ingresar un valor mayor a cero");
                PrecioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (PresentacionComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(AbrirPresentacionButton, "Seleccione la Presentación del Artículo");
                PresentacionComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            errorProvider1.Dispose(); //QUITAR EL ICONO DEL ERROR!!!
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