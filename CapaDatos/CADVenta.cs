using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CADVenta
    {
        private static VentasTableAdapter adaptador = new VentasTableAdapter();

        public static int InsertVentasGetIDVenta(ENTVenta v)
        {
            return (int)adaptador.InsertVentasGetIDVenta(v.Fecha,v.NoFactura);
        }
    }
}
