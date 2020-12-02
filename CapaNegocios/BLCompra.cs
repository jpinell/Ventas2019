using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLCompra
    {
        public static int InsertComprasGetIDCompra(ENTCompra c)
        {
            return CADCompra.InsertComprasGetIDCompra(c);
        }

    }
}
