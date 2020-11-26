
namespace Presentacion
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.ArticuloTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PresentacionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CerrarPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new FontAwesome.Sharp.IconButton();
            this.EliminarButton = new FontAwesome.Sharp.IconButton();
            this.ActualizarButton = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            this.conjuntoDatos1 = new CapaDatos.ConjuntoDatos();
            this.AbrirCategoriasButton = new FontAwesome.Sharp.IconButton();
            this.AbrirPresentacionButton = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntoDatos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria *:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(100, 35);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(127, 21);
            this.CategoriaComboBox.TabIndex = 1;
            this.CategoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriaComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad *:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(100, 67);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(64, 20);
            this.CantidadTextBox.TabIndex = 3;
            // 
            // ArticuloTextBox
            // 
            this.ArticuloTextBox.Location = new System.Drawing.Point(100, 102);
            this.ArticuloTextBox.Name = "ArticuloTextBox";
            this.ArticuloTextBox.Size = new System.Drawing.Size(176, 20);
            this.ArticuloTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artículo *:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(100, 138);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(265, 20);
            this.DescripcionTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción:";
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Location = new System.Drawing.Point(100, 173);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.Size = new System.Drawing.Size(64, 20);
            this.CostoTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo *:";
            // 
            // PresentacionComboBox
            // 
            this.PresentacionComboBox.FormattingEnabled = true;
            this.PresentacionComboBox.Location = new System.Drawing.Point(100, 209);
            this.PresentacionComboBox.Name = "PresentacionComboBox";
            this.PresentacionComboBox.Size = new System.Drawing.Size(127, 21);
            this.PresentacionComboBox.TabIndex = 11;
            this.PresentacionComboBox.SelectedIndexChanged += new System.EventHandler(this.PresentacionComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Presentación *:";
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
            this.CerrarPictureBox.Location = new System.Drawing.Point(1031, 0);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(24, 24);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 13;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1067, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "PRODUCTOS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductoDataGridView
            // 
            this.ProductoDataGridView.AllowUserToAddRows = false;
            this.ProductoDataGridView.AllowUserToDeleteRows = false;
            this.ProductoDataGridView.AllowUserToOrderColumns = true;
            this.ProductoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProductoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoDataGridView.Location = new System.Drawing.Point(384, 36);
            this.ProductoDataGridView.Name = "ProductoDataGridView";
            this.ProductoDataGridView.ReadOnly = true;
            this.ProductoDataGridView.RowHeadersVisible = false;
            this.ProductoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductoDataGridView.Size = new System.Drawing.Size(671, 194);
            this.ProductoDataGridView.TabIndex = 18;
            this.ProductoDataGridView.TabStop = false;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.CancelarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarButton.IconSize = 22;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(384, 255);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(97, 35);
            this.CancelarButton.TabIndex = 15;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.EliminarButton.IconColor = System.Drawing.Color.DarkRed;
            this.EliminarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarButton.IconSize = 22;
            this.EliminarButton.Location = new System.Drawing.Point(221, 255);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 35);
            this.EliminarButton.TabIndex = 14;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ActualizarButton.IconColor = System.Drawing.Color.Navy;
            this.ActualizarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarButton.IconSize = 24;
            this.ActualizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarButton.Location = new System.Drawing.Point(118, 255);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(97, 35);
            this.ActualizarButton.TabIndex = 13;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarButton.IconColor = System.Drawing.Color.DarkGreen;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.IconSize = 24;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(15, 255);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 35);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // conjuntoDatos1
            // 
            this.conjuntoDatos1.DataSetName = "ConjuntoDatos";
            this.conjuntoDatos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AbrirCategoriasButton
            // 
            this.AbrirCategoriasButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.AbrirCategoriasButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AbrirCategoriasButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.AbrirCategoriasButton.IconSize = 16;
            this.AbrirCategoriasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbrirCategoriasButton.Location = new System.Drawing.Point(231, 33);
            this.AbrirCategoriasButton.Name = "AbrirCategoriasButton";
            this.AbrirCategoriasButton.Size = new System.Drawing.Size(26, 24);
            this.AbrirCategoriasButton.TabIndex = 16;
            this.toolTip1.SetToolTip(this.AbrirCategoriasButton, "Agregar Categoria del Producto");
            this.AbrirCategoriasButton.UseVisualStyleBackColor = true;
            this.AbrirCategoriasButton.Click += new System.EventHandler(this.AbrirCategoriasButton_Click);
            // 
            // AbrirPresentacionButton
            // 
            this.AbrirPresentacionButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.AbrirPresentacionButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AbrirPresentacionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AbrirPresentacionButton.IconSize = 16;
            this.AbrirPresentacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbrirPresentacionButton.Location = new System.Drawing.Point(231, 207);
            this.AbrirPresentacionButton.Name = "AbrirPresentacionButton";
            this.AbrirPresentacionButton.Size = new System.Drawing.Size(26, 24);
            this.AbrirPresentacionButton.TabIndex = 17;
            this.toolTip1.SetToolTip(this.AbrirPresentacionButton, "Agregar Presentación del Producto");
            this.AbrirPresentacionButton.UseVisualStyleBackColor = true;
            this.AbrirPresentacionButton.Click += new System.EventHandler(this.AbrirPresentacionButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 302);
            this.Controls.Add(this.AbrirPresentacionButton);
            this.Controls.Add(this.AbrirCategoriasButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ProductoDataGridView);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PresentacionComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArticuloTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntoDatos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox ArticuloTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PresentacionComboBox;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox CerrarPictureBox;
        private System.Windows.Forms.Label label7;
        private CapaDatos.ConjuntoDatos conjuntoDatos1;
        private System.Windows.Forms.DataGridView ProductoDataGridView;
        private FontAwesome.Sharp.IconButton CancelarButton;
        private FontAwesome.Sharp.IconButton EliminarButton;
        private FontAwesome.Sharp.IconButton ActualizarButton;
        private FontAwesome.Sharp.IconButton GuardarButton;
        private FontAwesome.Sharp.IconButton AbrirCategoriasButton;
        private FontAwesome.Sharp.IconButton AbrirPresentacionButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}