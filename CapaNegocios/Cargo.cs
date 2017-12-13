using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Cargo
    {
        public static DataTable cargarComboBox()
        {
            return Cargo_datos.cargarCombo();
        }
    }
}
