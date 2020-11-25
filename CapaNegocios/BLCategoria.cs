using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLCategoria
    {
        public static object GetData()
        {
            return CADCategoria.GetData();
        }

        public static void InsertCategorias(ENTCategoria c)
        {
            CADCategoria.InsertCategorias(c);
        }

        public static void UpdateCategorias(ENTCategoria c)
        {
            CADCategoria.UpdateCategorias(c);
        }

        public static void DeleteCategorias(int IDCategoria)
        {
            CADCategoria.DeleteCategorias(IDCategoria);
        }
    }
}
