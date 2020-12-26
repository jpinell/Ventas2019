
namespace Presentacion
{
    partial class FormVentas
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
            this.components = new System.ComponentModel.Container();
            this.TotalFacturaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DetallesDataGridView = new System.Windows.Forms.DataGridView();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FacturaTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AbrirProductosButton = new FontAwesome.Sharp.IconButton();
            this.AgregarButton = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            this.CerrarPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.PorcentajeVentaNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ExistenciasTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcentajeVentaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalFacturaTextBox
            // 
            this.TotalFacturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFacturaTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.TotalFacturaTextBox.Location = new System.Drawing.Point(889, 208);
            this.TotalFacturaTextBox.Name = "TotalFacturaTextBox";
            this.TotalFacturaTextBox.Size = new System.Drawing.Size(115, 26);
            this.TotalFacturaTextBox.TabIndex = 47;
            this.TotalFacturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(721, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "TOTAL FACTURA: ";
            // 
            // DetallesDataGridView
            // 
            this.DetallesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDataGridView.Location = new System.Drawing.Point(7, 240);
            this.DetallesDataGridView.Name = "DetallesDataGridView";
            this.DetallesDataGridView.Size = new System.Drawing.Size(997, 331);
            this.DetallesDataGridView.TabIndex = 43;
            this.DetallesDataGridView.TabStop = false;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PrecioTextBox.Location = new System.Drawing.Point(86, 205);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(61, 20);
            this.PrecioTextBox.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Precio:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.BackColor = System.Drawing.Color.White;
            this.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DescripcionTextBox.Location = new System.Drawing.Point(86, 168);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.ReadOnly = true;
            this.DescripcionTextBox.Size = new System.Drawing.Size(515, 20);
            this.DescripcionTextBox.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Descripción:";
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.BackColor = System.Drawing.Color.White;
            this.ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(86, 130);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(259, 21);
            this.ProductoComboBox.Sorted = true;
            this.ProductoComboBox.TabIndex = 34;
            this.ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Producto:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CantidadTextBox.Location = new System.Drawing.Point(86, 93);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(61, 20);
            this.CantidadTextBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1027, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "DETALLE DE VENTAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FacturaTextBox
            // 
            this.FacturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.FacturaTextBox.Location = new System.Drawing.Point(276, 27);
            this.FacturaTextBox.Name = "FacturaTextBox";
            this.FacturaTextBox.Size = new System.Drawing.Size(115, 26);
            this.FacturaTextBox.TabIndex = 30;
            this.FacturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(86, 29);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.FechaDateTimePicker.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Factura No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1016, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "VENTAS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbrirProductosButton
            // 
            this.AbrirProductosButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.AbrirProductosButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AbrirProductosButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.AbrirProductosButton.IconSize = 16;
            this.AbrirProductosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbrirProductosButton.Location = new System.Drawing.Point(351, 128);
            this.AbrirProductosButton.Name = "AbrirProductosButton";
            this.AbrirProductosButton.Size = new System.Drawing.Size(26, 24);
            this.AbrirProductosButton.TabIndex = 35;
            this.AbrirProductosButton.TabStop = false;
            this.AbrirProductosButton.UseVisualStyleBackColor = true;
            this.AbrirProductosButton.Click += new System.EventHandler(this.AbrirProductosButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.AgregarButton.IconColor = System.Drawing.Color.Maroon;
            this.AgregarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarButton.IconSize = 24;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(153, 199);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(97, 35);
            this.AgregarButton.TabIndex = 41;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarButton.IconColor = System.Drawing.Color.DarkGreen;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.IconSize = 24;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(256, 199);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 35);
            this.GuardarButton.TabIndex = 42;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CerrarPictureBox
            // 
            this.CerrarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.CerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarPictureBox.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CerrarPictureBox.IconColor = System.Drawing.Color.White;
            this.CerrarPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarPictureBox.IconSize = 24;
            this.CerrarPictureBox.Location = new System.Drawing.Point(991, 3);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(24, 24);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 40;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Costo del Producto:";
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CostoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.CostoTextBox.Location = new System.Drawing.Point(501, 128);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.ReadOnly = true;
            this.CostoTextBox.Size = new System.Drawing.Size(100, 23);
            this.CostoTextBox.TabIndex = 49;
            this.CostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PorcentajeVentaNUD
            // 
            this.PorcentajeVentaNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PorcentajeVentaNUD.Location = new System.Drawing.Point(677, 130);
            this.PorcentajeVentaNUD.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.PorcentajeVentaNUD.Name = "PorcentajeVentaNUD";
            this.PorcentajeVentaNUD.Size = new System.Drawing.Size(56, 20);
            this.PorcentajeVentaNUD.TabIndex = 50;
            this.PorcentajeVentaNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PorcentajeVentaNUD.ThousandsSeparator = true;
            this.PorcentajeVentaNUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.PorcentajeVentaNUD.ValueChanged += new System.EventHandler(this.PorcentajeVentaNUD_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(622, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "% Venta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(622, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Existencias:";
            // 
            // ExistenciasTextBox
            // 
            this.ExistenciasTextBox.BackColor = System.Drawing.Color.White;
            this.ExistenciasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistenciasTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.ExistenciasTextBox.Location = new System.Drawing.Point(722, 165);
            this.ExistenciasTextBox.Name = "ExistenciasTextBox";
            this.ExistenciasTextBox.ReadOnly = true;
            this.ExistenciasTextBox.Size = new System.Drawing.Size(88, 26);
            this.ExistenciasTextBox.TabIndex = 47;
            this.ExistenciasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 583);
            this.Controls.Add(this.PorcentajeVentaNUD);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExistenciasTextBox);
            this.Controls.Add(this.TotalFacturaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AbrirProductosButton);
            this.Controls.Add(this.DetallesDataGridView);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProductoComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FacturaTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVentas_FormClosing);
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcentajeVentaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalFacturaTextBox;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton AbrirProductosButton;
        private System.Windows.Forms.DataGridView DetallesDataGridView;
        private FontAwesome.Sharp.IconButton AgregarButton;
        private FontAwesome.Sharp.IconButton GuardarButton;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FacturaTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox CerrarPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PorcentajeVentaNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ExistenciasTextBox;
    }
}