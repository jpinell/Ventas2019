using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CompraDetalle
    {
        /* Se hace esta clase para solamente cargar estos datos 
         * en el DataGrid del Detalle de las compras
         */
        public int IDProducto { get; set; }
        public float Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal SubTotal { get { return (decimal)Cantidad * CostoUnitario; } }
    }
}
