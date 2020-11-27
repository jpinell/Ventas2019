using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class BLProveedor
    {
        public static object GetData()
        {
            return CADProveedor.GetData();
        }

        public static void InsertProveedor(ENTProveedor p)
        {
            CADProveedor.InsertProveedor(p);
        }

        public static void UpdateProveedor(ENTProveedor p)
        {
            CADProveedor.UpdateProveedor(p);
        }

        public static void DeleteProveedor(int IDProveedor)
        {
            CADProveedor.DeleteProveedor(IDProveedor);
        }
    }
}
