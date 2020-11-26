using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class BLBotones
    {
        public static void HabilitarBotones(bool activo, Button boton1, Button boton2, Button boton3)
        {
            //ACTIVA O DESACTIVA LOS BOTONES
            boton1.Enabled = activo;
            boton2.Enabled = !activo;
            boton3.Enabled = !activo;
        }
    }
}
