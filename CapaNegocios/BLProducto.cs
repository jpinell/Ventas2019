﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BLProducto
    {
        public static object GetData()
        {
            return CADProducto.GetData();
        }

        public static string GetDescripcionByIDProducto(int IDProducto)
        {
            return CADProducto.GetDescripcionByIDProducto(IDProducto).ToString();
        }

        public static int InsertProductoGetIDProducto(ENTProducto p)
        {
            return CADProducto.InsertProductoGetIDProducto(p);
        }

        public static void UpdatePrecioProductoByIDProducto(float Cantidad, decimal Precio, int IDProducto)
        {
            CADProducto.UpdatePrecioProductoByIDProducto(Cantidad, Precio, IDProducto);
        }

        public static ENTProducto SelectProductoByIDProducto(int IDProducto)
        {
            return CADProducto.SelectProductoByIDProducto(IDProducto);
        }

        public static void UpdateCantidadVenta(float Cantidad, int IDProducto)
        {
            CADProducto.UpdateCantidadVenta(Cantidad, IDProducto);
        }
    }
}
