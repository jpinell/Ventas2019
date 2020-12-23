using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;

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