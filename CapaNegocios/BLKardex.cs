using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLKardex
    {
        public static object GetData()
        {
            return CADKardex.GetData();
        }

        public static void InsertKardex(ENTKardex k)
        {
            CADKardex.InsertKardex(k);
        }

        public static int SelectIDKardexByIDProducto(int IDProducto)
        {
            return CADKardex.SelectIDKardexByIDProducto(IDProducto);
        }

        public static ENTKardex SelectKardexByIDProducto(int vidProducto)
        {
            return CADKardex.SelectKardexByIDProducto(vidProducto);
        }
    }
}
