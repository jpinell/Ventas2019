using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CADVentaDetalle
    {
        private static VentaDetalleTableAdapter adaptador = new VentaDetalleTableAdapter();

        public static void InsertVentaDetalle(ENTVentaDetalle vd)
        {
            adaptador.InsertVentaDetalle(vd.IDVenta, vd.Cantidad, vd.IDProducto, vd.Descripcion, vd.Precio);
        }
    }
}
