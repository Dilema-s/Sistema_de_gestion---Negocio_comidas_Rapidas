using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Unidad
    {
        public static DataSet cargarComboBox()
        {
            return Unidad_datos.cargarCombo();
        }
    }
}
