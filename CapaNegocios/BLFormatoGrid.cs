using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class BLFormatoGrid
    {
        public static void FormatoGrid(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            grid.EnableHeadersVisualStyles = false; //Desactivar los estilos visuales del datagrid
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Navy;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.BorderStyle = BorderStyle.None;

            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 25;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;

            grid.MultiSelect = false;
            grid.ScrollBars = ScrollBars.Vertical;
            //grid.Columns[0].Visible = false;
        }
    }
}
