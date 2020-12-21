using CapaDatos.ConjuntoDatosTableAdapters;
using CapaEntidades;
using static CapaDatos.ConjuntoDatos;

namespace CapaDatos
{
    public class CADKardex
    {
        private static readonly KardexTableAdapter adaptador = new KardexTableAdapter();

        public static KardexDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertKardex(ENTKardex k)
        {
            adaptador.InsertKardex(
                k.Fecha, 
                k.Concepto, 
                k.Entrada, 
                k.Salida, 
                k.Existencia, 
                k.CostoUnitario, 
                k.Debe, 
                k.Haber, 
                k.Saldo, 
                k.CostoPromedio, 
                k.IDProducto);
        }

        public static int SelectIDKardexByIDProducto(int IDProducto)
        {
            return (int)adaptador.SelectIDKardexByIDProducto(IDProducto);
        }

        public static KardexDataTable SelectKardex(int IDProducto)
        {
            return adaptador.SelectKardex(IDProducto);
        }

        public static ENTKardex SelectKardexByIDProducto(int IDProducto)
        {
            ENTKardex miKardex = null;
            KardexDataTable miTabla = adaptador.SelectKardexByIDProducto(IDProducto);

            if (miTabla.Rows.Count == 0) return miKardex;
            KardexRow miRegistro = (KardexRow)miTabla.Rows[0];

            miKardex = new ENTKardex
            {
                IDKardex = miRegistro.IDKardex,
                Fecha = miRegistro.Fecha,
                Concepto = miRegistro.Concepto,
                Entrada = (float)miRegistro.Entrada,
                Salida = (float)miRegistro.Salida,
                Existencia = (float)miRegistro.Existencia,
                CostoUnitario = miRegistro.CostoUnitario,
                Debe = miRegistro.Debe,
                Haber = miRegistro.Haber,
                Saldo = miRegistro.Saldo,
                CostoPromedio = miRegistro.CostoPromedio,
                IDProducto = miRegistro.IDProducto
            };

            return miKardex;
        }
    }
}
