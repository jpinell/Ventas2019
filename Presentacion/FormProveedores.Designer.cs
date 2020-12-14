
namespace Presentacion
{
    partial class FormProveedores
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
            this.CerrarPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RucTextBox = new System.Windows.Forms.TextBox();
            this.EmpresaTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new FontAwesome.Sharp.IconButton();
            this.EliminarButton = new FontAwesome.Sharp.IconButton();
            this.ActualizarButton = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.CerrarPictureBox.Location = new System.Drawing.Point(714, 0);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(24, 24);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 12;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(748, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "PROVEEDORES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de RUC *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la Empresa *:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección *:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono *:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo Electrónico *:";
            // 
            // RucTextBox
            // 
            this.RucTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RucTextBox.Location = new System.Drawing.Point(139, 38);
            this.RucTextBox.Name = "RucTextBox";
            this.RucTextBox.Size = new System.Drawing.Size(218, 20);
            this.RucTextBox.TabIndex = 1;
            // 
            // EmpresaTextBox
            // 
            this.EmpresaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EmpresaTextBox.Location = new System.Drawing.Point(139, 67);
            this.EmpresaTextBox.Name = "EmpresaTextBox";
            this.EmpresaTextBox.Size = new System.Drawing.Size(360, 20);
            this.EmpresaTextBox.TabIndex = 3;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DireccionTextBox.Location = new System.Drawing.Point(139, 97);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(605, 20);
            this.DireccionTextBox.TabIndex = 5;
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TelefonoTextBox.Location = new System.Drawing.Point(139, 131);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(105, 20);
            this.TelefonoTextBox.TabIndex = 7;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EmailTextBox.Location = new System.Drawing.Point(139, 162);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(353, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ProveedorDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 257);
            this.panel1.TabIndex = 23;
            // 
            // ProveedorDataGridView
            // 
            this.ProveedorDataGridView.AllowUserToAddRows = false;
            this.ProveedorDataGridView.AllowUserToDeleteRows = false;
            this.ProveedorDataGridView.AllowUserToOrderColumns = true;
            this.ProveedorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProveedorDataGridView.MultiSelect = false;
            this.ProveedorDataGridView.Name = "ProveedorDataGridView";
            this.ProveedorDataGridView.ReadOnly = true;
            this.ProveedorDataGridView.Size = new System.Drawing.Size(748, 257);
            this.ProveedorDataGridView.TabIndex = 0;
            this.ProveedorDataGridView.TabStop = false;
            this.ProveedorDataGridView.Click += new System.EventHandler(this.ProveedorDataGridView_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.CancelarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarButton.IconSize = 22;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(499, 200);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(97, 35);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.EliminarButton.IconColor = System.Drawing.Color.DarkRed;
            this.EliminarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarButton.IconSize = 22;
            this.EliminarButton.Location = new System.Drawing.Point(345, 200);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 35);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.BackColor = System.Drawing.Color.White;
            this.ActualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ActualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ActualizarButton.IconColor = System.Drawing.Color.Navy;
            this.ActualizarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarButton.IconSize = 24;
            this.ActualizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarButton.Location = new System.Drawing.Point(242, 200);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(97, 35);
            this.ActualizarButton.TabIndex = 11;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarButton.UseVisualStyleBackColor = false;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarButton.IconColor = System.Drawing.Color.DarkGreen;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.IconSize = 24;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(139, 200);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 35);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 498);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.EmpresaTextBox);
            this.Controls.Add(this.RucTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox CerrarPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RucTextBox;
        private System.Windows.Forms.TextBox EmpresaTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProveedorDataGridView;
        private FontAwesome.Sharp.IconButton CancelarButton;
        private FontAwesome.Sharp.IconButton EliminarButton;
        private FontAwesome.Sharp.IconButton ActualizarButton;
        private FontAwesome.Sharp.IconButton GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}