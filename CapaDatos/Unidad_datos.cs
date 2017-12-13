using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Unidad_datos
    {
        // data set representa una cache de dtos de memoria
        public static DataSet cargarCombo()
        {

            DataSet data = new DataSet();

            string Query = "SELECT id_unidad, unidad FROM unidad ORDER BY unidad ";
            // Con el "SELECT 0 id_unidad crea una tabla con id 0 y nombre "Seleccione..", despues con el union une los demas id y nombre restantes de la tabla provincia 

            try
            {
                Conexion Cx = new Conexion();
                Cx.setSQL(Query);
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);

                sqlDat.Fill(data); //Cargamos data set

            }
            catch (Exception)
            {

                data = null;
            }


            return data;
        }
    }
}
