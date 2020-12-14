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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        ENTProveedor proveedor = new ENTProveedor();
        int vidProveedor;

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ListarProveedores();
            BLFormatoGrid.FormatoGrid(ProveedorDataGridView);
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
        }

        private void ListarProveedores()
        {
            ProveedorDataGridView.DataSource = BLProveedor.GetData();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            proveedor.Direccion = DireccionTextBox.Text;
            proveedor.Email = EmailTextBox.Text;
            proveedor.Empresa = EmpresaTextBox.Text;
            proveedor.NoRuc = RucTextBox.Text;
            proveedor.Telefono = TelefonoTextBox.Text;
            

            BLProveedor.InsertProveedor(proveedor);

            ListarProveedores();
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            DireccionTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            EmpresaTextBox.Text = string.Empty;
            RucTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            RucTextBox.Focus();
        }

        //private void ObservacionestextBox_KeyUp(object sender, KeyEventArgs e)
        //{
        //    ObservacionestextBox.Text = ReducirEspaciado(ObservacionestextBox.Text);
        //    ObservacionestextBox.SelectionStart = ObservacionestextBox.Text.Length;
        //}

        //Evitar espacios en blanco
        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }

        private bool ValidarCampos()
        {
            if(RucTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(RucTextBox, "Ingrese el Número RUC");
                RucTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (EmpresaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(EmpresaTextBox, "Ingrese el Nombre de la Empresa");
                EmpresaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (DireccionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DireccionTextBox, "Ingrese la Dirección de la Empresa");
                DireccionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (TelefonoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(TelefonoTextBox, "Ingrese el Teléfono de la Empresa");
                TelefonoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (EmailTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(EmailTextBox, "Ingrese el Correo de la Empresa");
                EmailTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            proveedor.Direccion = DireccionTextBox.Text;
            proveedor.Email = EmailTextBox.Text;
            proveedor.Empresa = EmpresaTextBox.Text;
            proveedor.NoRuc = RucTextBox.Text;
            proveedor.Telefono = TelefonoTextBox.Text;
            proveedor.IDProveedor = vidProveedor;

            //ACTUALIZAR EL REGISTRO
            BLProveedor.UpdateProveedor(proveedor);

            LimpiarCajas();
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            ListarProveedores();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Está seguro de borrar el registro actual?",
          "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                LimpiarCajas();
                BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
                return;
            }

            BLProveedor.DeleteProveedor(vidProveedor);

            LimpiarCajas();
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            ListarProveedores();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            BLBotones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            errorProvider1.Dispose(); //QUITAR EL ICONO DEL ERROR!!!
        }

        private void ProveedorDataGridView_Click(object sender, EventArgs e)
        {
            if (ProveedorDataGridView.Rows.Count == 0) return;
            vidProveedor = (int)ProveedorDataGridView.CurrentRow.Cells[0].Value;
            RucTextBox.Text = ProveedorDataGridView.CurrentRow.Cells[1].Value.ToString();
            EmpresaTextBox.Text = ProveedorDataGridView.CurrentRow.Cells[2].Value.ToString();
            DireccionTextBox.Text = ProveedorDataGridView.CurrentRow.Cells[3].Value.ToString();
            TelefonoTextBox.Text = ProveedorDataGridView.CurrentRow.Cells[4].Value.ToString();
            EmailTextBox.Text = ProveedorDataGridView.CurrentRow.Cells[5].Value.ToString();

            BLBotones.HabilitarBotones(false, GuardarButton, ActualizarButton, EliminarButton);
        }
    }
}
