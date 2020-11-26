using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using static CapaDatos.ConjuntoDatos;

namespace CapaDatos
{
    public class CADProducto
    {
        private static readonly ProductosTableAdapter adaptador = new ProductosTableAdapter();

        public static ProductosDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static int InsertProductoGetIDProducto(ENTProducto p)
        {
            return (int)adaptador.InsertProductoGetIDProducto(
                p.IDCategoria,
                p.Cantidad,
                p.Articulo,
                p.Descripcion,
                p.Costo,
                p.IDPresentacion);
        }
    }
}
