
namespace Presentacion
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.UsuariosButton = new FontAwesome.Sharp.IconButton();
            this.KardexButton = new FontAwesome.Sharp.IconButton();
            this.VentasButton = new FontAwesome.Sharp.IconButton();
            this.ComprasButton = new FontAwesome.Sharp.IconButton();
            this.ProveedoresButton = new FontAwesome.Sharp.IconButton();
            this.ProductosButton = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.HijoPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.LblTituloForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelDeskTop = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HijoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.UsuariosButton);
            this.PanelMenu.Controls.Add(this.KardexButton);
            this.PanelMenu.Controls.Add(this.VentasButton);
            this.PanelMenu.Controls.Add(this.ComprasButton);
            this.PanelMenu.Controls.Add(this.ProveedoresButton);
            this.PanelMenu.Controls.Add(this.ProductosButton);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 725);
            this.PanelMenu.TabIndex = 0;
            // 
            // UsuariosButton
            // 
            this.UsuariosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsuariosButton.FlatAppearance.BorderSize = 0;
            this.UsuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuariosButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.UsuariosButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UsuariosButton.IconColor = System.Drawing.Color.Gainsboro;
            this.UsuariosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuariosButton.IconSize = 32;
            this.UsuariosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsuariosButton.Location = new System.Drawing.Point(0, 440);
            this.UsuariosButton.Name = "UsuariosButton";
            this.UsuariosButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UsuariosButton.Size = new System.Drawing.Size(220, 60);
            this.UsuariosButton.TabIndex = 6;
            this.UsuariosButton.Text = "Usuarios";
            this.UsuariosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsuariosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsuariosButton.UseVisualStyleBackColor = true;
            this.UsuariosButton.Click += new System.EventHandler(this.UsuariosButton_Click);
            // 
            // KardexButton
            // 
            this.KardexButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.KardexButton.FlatAppearance.BorderSize = 0;
            this.KardexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KardexButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.KardexButton.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.KardexButton.IconColor = System.Drawing.Color.Gainsboro;
            this.KardexButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KardexButton.IconSize = 32;
            this.KardexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KardexButton.Location = new System.Drawing.Point(0, 380);
            this.KardexButton.Name = "KardexButton";
            this.KardexButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.KardexButton.Size = new System.Drawing.Size(220, 60);
            this.KardexButton.TabIndex = 5;
            this.KardexButton.Text = "Kardex";
            this.KardexButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KardexButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KardexButton.UseVisualStyleBackColor = true;
            this.KardexButton.Click += new System.EventHandler(this.KardexButton_Click);
            // 
            // VentasButton
            // 
            this.VentasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentasButton.FlatAppearance.BorderSize = 0;
            this.VentasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.VentasButton.IconChar = FontAwesome.Sharp.IconChar.StripeS;
            this.VentasButton.IconColor = System.Drawing.Color.Gainsboro;
            this.VentasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasButton.IconSize = 32;
            this.VentasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasButton.Location = new System.Drawing.Point(0, 320);
            this.VentasButton.Name = "VentasButton";
            this.VentasButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.VentasButton.Size = new System.Drawing.Size(220, 60);
            this.VentasButton.TabIndex = 4;
            this.VentasButton.Text = "Ventas";
            this.VentasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VentasButton.UseVisualStyleBackColor = true;
            this.VentasButton.Click += new System.EventHandler(this.VentasButton_Click);
            // 
            // ComprasButton
            // 
            this.ComprasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasButton.FlatAppearance.BorderSize = 0;
            this.ComprasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComprasButton.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.ComprasButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ComprasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComprasButton.IconSize = 32;
            this.ComprasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasButton.Location = new System.Drawing.Point(0, 260);
            this.ComprasButton.Name = "ComprasButton";
            this.ComprasButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ComprasButton.Size = new System.Drawing.Size(220, 60);
            this.ComprasButton.TabIndex = 3;
            this.ComprasButton.Text = "Compras";
            this.ComprasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ComprasButton.UseVisualStyleBackColor = true;
            this.ComprasButton.Click += new System.EventHandler(this.ComprasButton_Click);
            // 
            // ProveedoresButton
            // 
            this.ProveedoresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProveedoresButton.FlatAppearance.BorderSize = 0;
            this.ProveedoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProveedoresButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProveedoresButton.IconChar = FontAwesome.Sharp.IconChar.LuggageCart;
            this.ProveedoresButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ProveedoresButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProveedoresButton.IconSize = 32;
            this.ProveedoresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProveedoresButton.Location = new System.Drawing.Point(0, 200);
            this.ProveedoresButton.Name = "ProveedoresButton";
            this.ProveedoresButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProveedoresButton.Size = new System.Drawing.Size(220, 60);
            this.ProveedoresButton.TabIndex = 2;
            this.ProveedoresButton.Text = "Proveedores";
            this.ProveedoresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProveedoresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProveedoresButton.UseVisualStyleBackColor = true;
            this.ProveedoresButton.Click += new System.EventHandler(this.ProveedoresButton_Click);
            // 
            // ProductosButton
            // 
            this.ProductosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductosButton.FlatAppearance.BorderSize = 0;
            this.ProductosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductosButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProductosButton.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.ProductosButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ProductosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductosButton.IconSize = 32;
            this.ProductosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductosButton.Location = new System.Drawing.Point(0, 140);
            this.ProductosButton.Name = "ProductosButton";
            this.ProductosButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProductosButton.Size = new System.Drawing.Size(220, 60);
            this.ProductosButton.TabIndex = 1;
            this.ProductosButton.Text = "Productos";
            this.ProductosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductosButton.UseVisualStyleBackColor = true;
            this.ProductosButton.Click += new System.EventHandler(this.ProductosButton_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.btnInicio);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 140);
            this.PanelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = global::Presentacion.Properties.Resources.LogoVentas;
            this.btnInicio.Location = new System.Drawing.Point(39, 25);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(132, 77);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelTitleBar.Controls.Add(this.LblTituloForm);
            this.PanelTitleBar.Controls.Add(this.HijoPictureBox);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(898, 75);
            this.PanelTitleBar.TabIndex = 1;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // HijoPictureBox
            // 
            this.HijoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.HijoPictureBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.HijoPictureBox.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HijoPictureBox.IconColor = System.Drawing.Color.MediumPurple;
            this.HijoPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HijoPictureBox.Location = new System.Drawing.Point(6, 25);
            this.HijoPictureBox.Name = "HijoPictureBox";
            this.HijoPictureBox.Size = new System.Drawing.Size(32, 32);
            this.HijoPictureBox.TabIndex = 0;
            this.HijoPictureBox.TabStop = false;
            // 
            // LblTituloForm
            // 
            this.LblTituloForm.AutoSize = true;
            this.LblTituloForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloForm.Location = new System.Drawing.Point(44, 35);
            this.LblTituloForm.Name = "LblTituloForm";
            this.LblTituloForm.Size = new System.Drawing.Size(35, 13);
            this.LblTituloForm.TabIndex = 1;
            this.LblTituloForm.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 6);
            this.panel1.TabIndex = 2;
            // 
            // PanelDeskTop
            // 
            this.PanelDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeskTop.Location = new System.Drawing.Point(220, 81);
            this.PanelDeskTop.Name = "PanelDeskTop";
            this.PanelDeskTop.Size = new System.Drawing.Size(898, 644);
            this.PanelDeskTop.TabIndex = 3;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 725);
            this.Controls.Add(this.PanelDeskTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HijoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton ProductosButton;
        private FontAwesome.Sharp.IconButton UsuariosButton;
        private FontAwesome.Sharp.IconButton KardexButton;
        private FontAwesome.Sharp.IconButton VentasButton;
        private FontAwesome.Sharp.IconButton ComprasButton;
        private FontAwesome.Sharp.IconButton ProveedoresButton;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel PanelTitleBar;
        private FontAwesome.Sharp.IconPictureBox HijoPictureBox;
        private System.Windows.Forms.Label LblTituloForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelDeskTop;
    }
}

