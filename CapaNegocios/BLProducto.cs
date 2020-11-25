using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLProducto
    {
        public static object GetData()
        {
            return CADProducto.GetData();
        }

        public static void InsertProductoGetIDProducto(ENTProducto p)
        {
            CADProducto.InsertProductoGetIDProducto(p);
        }
    }
}
