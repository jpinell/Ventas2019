using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENTProducto
    {
        public int IDProducto { get; set; }
        public int IDCategoria { get; set; }
        public float Cantidad { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int IDPresentacion { get; set; }

    }
}
