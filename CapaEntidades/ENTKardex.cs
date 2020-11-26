using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENTKardex
    {
        public int IDKardex { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public float Entrada { get; set; }
        public float Salida { get; set; }
        public float Existencia { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
        public decimal CostoPromedio { get; set; }
        public int IDProducto { get; set; }
    }
}
