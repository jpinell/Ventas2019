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

        public static string GetDescripcionByIDProducto(int IDProducto)
        {
            return adaptador.GetDescripcionByIDProducto(IDProducto).ToString();
        }

        public static int InsertProductoGetIDProducto(ENTProducto p)
        {
            return (int)adaptador.InsertProductoGetIDProducto(
                p.IDCategoria,
                p.Cantidad,
                p.Articulo,
                p.Descripcion,
                p.Precio,
                p.IDPresentacion);
        }

        public static void UpdateProducto(ENTProducto p)
        {
            adaptador.UpdateProducto(
                p.IDCategoria, 
                p.Cantidad, 
                p.Articulo, 
                p.Descripcion, 
                p.Precio, 
                p.IDPresentacion, 
                p.IDProducto);
        }

        public static void UpdatePrecioProductoByIDProducto(float Cantidad, decimal Precio, int IDProducto)
        {
            adaptador.UpdatePrecioProductoByIDProducto(Cantidad, Precio, IDProducto);
        }

        public static ENTProducto SelectProductoByIDProducto(int IDProducto)
        {
            ENTProducto miProducto = null;
            ProductosDataTable miTabla = adaptador.SelectProductoByIDProducto(IDProducto);

            if (miTabla.Rows.Count == 0) return miProducto;
            ProductosRow miRegistro = (ProductosRow)miTabla.Rows[0];

            miProducto = new ENTProducto
            {
                IDProducto = miRegistro.IDProducto,
                IDCategoria = miRegistro.IDCategoria,
                Cantidad = (float)miRegistro.Cantidad,
                Articulo = miRegistro.Articulo,
                Descripcion = miRegistro.Descripcion,
                Precio = miRegistro.Precio,
                IDPresentacion = miRegistro.IDPresentacion,
            };

            return miProducto;
        }

        public static void UpdateCantidadVenta(float Cantidad, int IDProducto)
        {
            adaptador.UpdateCantidadVenta(Cantidad, IDProducto);
        }
    }
}
