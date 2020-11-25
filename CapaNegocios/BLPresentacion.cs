using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLPresentacion
    {
        public static object GetData()
        {
            return CADPresentacion.GetData();
        }

        public static void InsertPresentacion(ENTPresentacion p)
        {
            CADPresentacion.InsertPresentacion(p);
        }

        public static void UpdatePresentacion(ENTPresentacion p)
        {
            CADPresentacion.UpdatePresentacion(p);
        }

        public static void DeletePresentacion(int IDPresentacion)
        {
            CADPresentacion.DeletePresentacion(IDPresentacion);
        }
    }
}
