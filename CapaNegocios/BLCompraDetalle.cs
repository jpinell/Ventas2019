using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLCompraDetalle
    {
        public static void InsertCompraDetalle(ENTCompraDetalle cd)
        {
            CADCompraDetalle.InsertCompraDetalle(cd);
        }

    }
}
