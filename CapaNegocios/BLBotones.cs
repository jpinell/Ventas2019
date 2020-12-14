using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaNegocios
{
    public class BLBotones
    {
        public static void HabilitarBotones(bool activo, IconButton boton1, IconButton boton2, IconButton boton3)
        {
            //ACTIVA O DESACTIVA LOS BOTONES
            boton1.Enabled = activo;
            boton2.Enabled = !activo;
            boton3.Enabled = !activo;

           
            //if (boton1.Enabled == true)
            //{
            //    boton1.BackColor = Color.FromArgb(21, 30, 41);
            //    boton1.IconColor = Color.White;
            //}
            //else
            //{
            //    boton1.BackColor = Color.FromArgb(177, 180, 183);
            //    boton1.IconColor = Color.Black;
            //}
        }
    }
}
