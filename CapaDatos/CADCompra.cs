using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CADCompra
    {
        private static ComprasTableAdapter adaptador = new ComprasTableAdapter();

        public static int InsertComprasGetIDCompra(ENTCompra c)
        {
            return (int)adaptador.InsertComprasGetIDCompra(c.IDProveedor, c.Fecha, c.NoFactura);
        }

    }
}
