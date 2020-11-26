
namespace Presentacion
{
    partial class FormKardex
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
            this.CerrarPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.KardexDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KardexDataGridView)).BeginInit();
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
            this.CerrarPictureBox.Location = new System.Drawing.Point(776, 2);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(24, 24);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 15;
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
            this.label7.Size = new System.Drawing.Size(800, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "KARDEX";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione un Producto:";
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(142, 35);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(205, 21);
            this.ProductoComboBox.TabIndex = 17;
            this.ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoComboBox_SelectedIndexChanged);
            // 
            // KardexDataGridView
            // 
            this.KardexDataGridView.AllowUserToAddRows = false;
            this.KardexDataGridView.AllowUserToDeleteRows = false;
            this.KardexDataGridView.AllowUserToOrderColumns = true;
            this.KardexDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KardexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KardexDataGridView.Location = new System.Drawing.Point(12, 62);
            this.KardexDataGridView.Name = "KardexDataGridView";
            this.KardexDataGridView.ReadOnly = true;
            this.KardexDataGridView.Size = new System.Drawing.Size(776, 376);
            this.KardexDataGridView.TabIndex = 18;
            // 
            // FormKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KardexDataGridView);
            this.Controls.Add(this.ProductoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKardex";
            this.Text = "FormKardex";
            this.Load += new System.EventHandler(this.FormKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KardexDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox CerrarPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.DataGridView KardexDataGridView;
    }
}