using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENTCompra
    {
        public int IDCompra { get; set; }
        public int IDProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string NoFactura { get; set; }

    }
}
