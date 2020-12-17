using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENTCompraDetalle
    {
        public int IDCompraDetalle { get; set; }
        public int IDCompra { get; set; }
        public float Cantidad { get; set; }
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoUnitario { get; set; }

    }
}
