using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENTVentaDetalle
    {
        public int IDVentaDetalle { get; set; }
        public int IDVenta { get; set; }
        public float Cantidad { get; set; }
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get { return (decimal)Cantidad * Precio; } }
    }
}
