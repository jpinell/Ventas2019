using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using static CapaDatos.ConjuntoDatos;

namespace CapaDatos
{
    public class CADProveedor
    {
        private static ProveedoresTableAdapter adaptador = new ProveedoresTableAdapter();

        public static ProveedoresDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertProveedor(ENTProveedor p)
        {
            adaptador.InsertProveedor(p.NoRuc, p.Empresa, p.Direccion, p.Telefono, p.Email);
        }

        public static void UpdateProveedor(ENTProveedor p)
        {
            adaptador.UpdateProveedor(p.NoRuc, p.Empresa, p.Direccion, p.Telefono, p.Email, p.IDProveedor);
        }

        public static void DeleteProveedor(int IDProveedor)
        {
            adaptador.DeleteProveedor(IDProveedor);
        }
    }
}
