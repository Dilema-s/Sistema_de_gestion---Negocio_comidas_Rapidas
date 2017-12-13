using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Categoria_datos
    {
        // data set representa una cache de dtos de memoria
        public static DataSet cargarCombo()
        {
            DataSet data = new DataSet();
            string Query = "SELECT id_categoria, categoria FROM categoria ORDER BY categoria ";    
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
