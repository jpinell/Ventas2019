using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.ConjuntoDatos;

namespace CapaDatos
{
    public class CADProducto
    {
        private static ProductosTableAdapter adaptador = new ProductosTableAdapter();

        public static ProductosDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertProductoGetIDProducto(ENTProducto p)
        {
            adaptador.InsertProductoGetIDProducto(
                p.IDCategoria, 
                p.Cantidad, 
                p.Articulo, 
                p.Descripcion, 
                p.Costo, 
                p.IDPresentacion);
        }
    }
}
