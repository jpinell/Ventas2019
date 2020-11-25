﻿using CapaEntidades;
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
    public partial class FormPresentacion : Form
    {
        ENTPresentacion presentacion = new ENTPresentacion();
        public FormPresentacion()
        {
            InitializeComponent();
        }

        int vidPresentacion;

        private void FormPresentacion_Load(object sender, EventArgs e)
        {
            ListarPresentacion();
            HabilitarBotones(true);
        }

        private void ListarPresentacion()
        {
            PresentacionDataGridView.DataSource = BLPresentacion.GetData();
            PresentacionDataGridView.Columns[0].Visible = false;
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
            DescripcionTextBox.Text = string.Empty;
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            presentacion.Descripcion = DescripcionTextBox.Text;

            //GUARDAR EL REGISTRO
            BLPresentacion.InsertPresentacion(presentacion);

            ListarPresentacion();
            LimpiarCajas();
        }

        private bool ValidarCampos()
        {
            if (DescripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripcionTextBox, "Ingrese el Nombre de la Presentación");
                DescripcionTextBox.Focus();
                return false;
            }

            return true;
        }

        private void PresentacionDataGridView_Click(object sender, EventArgs e)
        {
            if (PresentacionDataGridView.Rows.Count == 0) return;
            vidPresentacion = (int)PresentacionDataGridView.CurrentRow.Cells[0].Value;
            DescripcionTextBox.Text = PresentacionDataGridView.CurrentRow.Cells[1].Value.ToString();

            HabilitarBotones(false);
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            presentacion.IDPresentacion = vidPresentacion;
            presentacion.Descripcion = DescripcionTextBox.Text;

            //ACTUALIZAR EL REGISTRO
            BLPresentacion.UpdatePresentacion(presentacion);

            LimpiarCajas();
            HabilitarBotones(true);
            ListarPresentacion();
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

            BLPresentacion.DeletePresentacion(vidPresentacion);

            LimpiarCajas();
            HabilitarBotones(true);
            ListarPresentacion();
        }
    }
}
