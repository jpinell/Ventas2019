using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        /* Declaramos campos de forma privada para almacenar el botón actual
         * y un panel para aplicar un borde izquierdo al botón.
        */
        private IconButton CurrentBtn;
        private Panel LeftBorderBtn;
        private Form CurrentChildForm;

        public Menu()
        {
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(LeftBorderBtn);

            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            //Maximizar ajustar tamaño de pantalla
            //MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            MaximizarPictureBox.BringToFront();

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;
        }

        //Estructura
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                CurrentBtn.ForeColor = color;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = color;
                CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, CurrentBtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();

                //Icon Current Child Form
                HijoPictureBox.IconChar = CurrentBtn.IconChar;
                HijoPictureBox.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.FromArgb(31, 30, 68);
                CurrentBtn.ForeColor = Color.Gainsboro;
                CurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn.IconColor = Color.Gainsboro;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                //Abrir solamente un fommulario
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDeskTop.Controls.Add(childForm);
            PanelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTituloForm.Text = childForm.Text;
        }

        private void ProductosButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormProductos());
        }

        private void ProveedoresButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormProveedores());
        }

        private void ComprasButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void KardexButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormKardex());
        }

        private void UsuariosButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            //Icon Current Child Form
            HijoPictureBox.IconChar = IconChar.Home;
            HijoPictureBox.IconColor = Color.MediumPurple;
            LblTituloForm.Text = "Home";
        }

        //Mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizarPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            RestaurarPictureBox.BringToFront();
        }

        private void RestaurarPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            MaximizarPictureBox.BringToFront();
        }

        private void MinimizarPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}