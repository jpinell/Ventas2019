
namespace Presentacion
{
    partial class FormExcel
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
            this.ImportarButton = new FontAwesome.Sharp.IconButton();
            this.ImportarDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrosTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImportarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportarButton
            // 
            this.ImportarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ImportarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ImportarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ImportarButton.IconColor = System.Drawing.Color.Black;
            this.ImportarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImportarButton.Location = new System.Drawing.Point(340, 12);
            this.ImportarButton.Name = "ImportarButton";
            this.ImportarButton.Size = new System.Drawing.Size(185, 31);
            this.ImportarButton.TabIndex = 0;
            this.ImportarButton.Text = "Importar Datos Excel";
            this.ImportarButton.UseVisualStyleBackColor = false;
            this.ImportarButton.Click += new System.EventHandler(this.ImportarButton_Click);
            // 
            // ImportarDataGridView
            // 
            this.ImportarDataGridView.AllowUserToAddRows = false;
            this.ImportarDataGridView.AllowUserToDeleteRows = false;
            this.ImportarDataGridView.AllowUserToOrderColumns = true;
            this.ImportarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportarDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImportarDataGridView.Location = new System.Drawing.Point(0, 49);
            this.ImportarDataGridView.Name = "ImportarDataGridView";
            this.ImportarDataGridView.ReadOnly = true;
            this.ImportarDataGridView.Size = new System.Drawing.Size(1108, 516);
            this.ImportarDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Registros:";
            // 
            // RegistrosTextBox
            // 
            this.RegistrosTextBox.BackColor = System.Drawing.Color.White;
            this.RegistrosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrosTextBox.Location = new System.Drawing.Point(666, 14);
            this.RegistrosTextBox.Name = "RegistrosTextBox";
            this.RegistrosTextBox.ReadOnly = true;
            this.RegistrosTextBox.Size = new System.Drawing.Size(102, 26);
            this.RegistrosTextBox.TabIndex = 3;
            this.RegistrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 565);
            this.Controls.Add(this.RegistrosTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportarDataGridView);
            this.Controls.Add(this.ImportarButton);
            this.Name = "FormExcel";
            this.Text = "FormExcel";
            ((System.ComponentModel.ISupportInitialize)(this.ImportarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ImportarButton;
        private System.Windows.Forms.DataGridView ImportarDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegistrosTextBox;
    }
}