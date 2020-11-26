
namespace Presentacion
{
    partial class FormPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.PresentacionDataGridView = new System.Windows.Forms.DataGridView();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.CancelarButton = new FontAwesome.Sharp.IconButton();
            this.EliminarButton = new FontAwesome.Sharp.IconButton();
            this.ActualizarButton = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PresentacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "PRESENTACION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PresentacionDataGridView
            // 
            this.PresentacionDataGridView.AllowUserToAddRows = false;
            this.PresentacionDataGridView.AllowUserToDeleteRows = false;
            this.PresentacionDataGridView.AllowUserToOrderColumns = true;
            this.PresentacionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresentacionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PresentacionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PresentacionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.PresentacionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this.PresentacionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PresentacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PresentacionDataGridView.Location = new System.Drawing.Point(12, 112);
            this.PresentacionDataGridView.Name = "PresentacionDataGridView";
            this.PresentacionDataGridView.ReadOnly = true;
            this.PresentacionDataGridView.RowHeadersVisible = false;
            this.PresentacionDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PresentacionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PresentacionDataGridView.Size = new System.Drawing.Size(541, 203);
            this.PresentacionDataGridView.TabIndex = 19;
            this.PresentacionDataGridView.TabStop = false;
            this.PresentacionDataGridView.Click += new System.EventHandler(this.PresentacionDataGridView_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DescripcionTextBox.Location = new System.Drawing.Point(101, 45);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(180, 20);
            this.DescripcionTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Presentación:";
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
            this.CerrarPictureBox.Location = new System.Drawing.Point(541, 2);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(24, 24);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 21;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.CancelarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarButton.IconSize = 22;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(444, 71);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(97, 35);
            this.CancelarButton.TabIndex = 18;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.EliminarButton.IconColor = System.Drawing.Color.DarkRed;
            this.EliminarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarButton.IconSize = 22;
            this.EliminarButton.Location = new System.Drawing.Point(307, 71);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 35);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ActualizarButton.IconColor = System.Drawing.Color.Navy;
            this.ActualizarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarButton.IconSize = 24;
            this.ActualizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarButton.Location = new System.Drawing.Point(204, 71);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(97, 35);
            this.ActualizarButton.TabIndex = 16;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarButton.IconColor = System.Drawing.Color.DarkGreen;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.IconSize = 24;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(101, 71);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 35);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 321);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PresentacionDataGridView);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPresentacion";
            this.Load += new System.EventHandler(this.FormPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresentacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox CerrarPictureBox;
        private FontAwesome.Sharp.IconButton CancelarButton;
        private FontAwesome.Sharp.IconButton EliminarButton;
        private FontAwesome.Sharp.IconButton ActualizarButton;
        private FontAwesome.Sharp.IconButton GuardarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PresentacionDataGridView;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}