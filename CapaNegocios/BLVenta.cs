using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLVenta
    {
        public static int InsertVentasGetIDVenta(ENTVenta v)
        {
            return CADVenta.InsertVentasGetIDVenta(v);
        }
    }
}
