using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CADCompraDetalle
    {
        private static CompraDetalleTableAdapter adaptador = new CompraDetalleTableAdapter();

        public static void InsertCompraDetalle(ENTCompraDetalle cd)
        {
            adaptador.InsertCompraDetalle(cd.IDCompra, cd.Cantidad, cd.IDProducto, cd.Descripcion, cd.CostoUnitario, cd.IDKardex);
        }
    }
}
