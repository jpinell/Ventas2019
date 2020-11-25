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
    public class CADPresentacion
    {
        private static readonly PresentacionTableAdapter adaptador = new PresentacionTableAdapter();

        public static PresentacionDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertPresentacion(ENTPresentacion p)
        {
            adaptador.InsertPresentacion(p.Descripcion);
        }

        public static void UpdatePresentacion(ENTPresentacion p)
        {
            adaptador.UpdatePresentacion(p.Descripcion, p.IDPresentacion);
        }

        public static void DeletePresentacion(int IDPresentacion)
        {
            adaptador.DeletePresentacion(IDPresentacion);
        }
    }
}
