using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using static CapaDatos.ConjuntoDatos;

namespace CapaDatos
{
    public class CADCategoria
    {
        private static readonly CategoriasTableAdapter adaptador = new CategoriasTableAdapter();

        public static CategoriasDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertCategorias(ENTCategoria c)
        {
            adaptador.InsertCategorias(c.Categoria, c.Descripcion);
        }

        public static void UpdateCategorias(ENTCategoria c)
        {
            adaptador.UpdateCategorias(c.Categoria, c.Descripcion, c.IDCategoria);
        }

        public static void DeleteCategorias(int IDCategoria)
        {
            adaptador.DeleteCategorias(IDCategoria);
        }
    }
}
