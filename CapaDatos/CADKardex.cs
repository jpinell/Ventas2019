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

        public static ENTKardex SelectKardexByIDProducto(int IDProducto)
        {
            ENTKardex miKardex = null;
            KardexDataTable miTabla = adaptador.SelectKardexByIDProducto(IDProducto);

            if (miTabla.Rows.Count == 0) return miKardex;
            KardexRow miRegistro = (KardexRow)miTabla.Rows[0];
            miKardex = new ENTKardex();
            miKardex.Fecha = miRegistro.Fecha;
            miKardex.Concepto = miRegistro.Concepto;
            miKardex.Entrada = (float)miRegistro.Entrada;
            miKardex.Salida = (float)miRegistro.Salida;
            miKardex.Existencia = (float)miRegistro.Existencia;
            miKardex.CostoUnitario = miRegistro.CostoUnitario;
            miKardex.Debe = miRegistro.Debe;
            miKardex.Haber = miRegistro.Haber;
            miKardex.Saldo = miRegistro.Saldo;
            miKardex.CostoPromedio = miRegistro.CostoPromedio;
            miKardex.IDProducto = miRegistro.IDProducto;

            return miKardex;
        }
    }
}
