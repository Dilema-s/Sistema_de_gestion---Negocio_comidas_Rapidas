using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Cargo_datos
    {
            // data set representa una cache de dtos de memoria
        public static DataTable cargarCombo()
        {
            DataTable data = new DataTable();
            string Query = "SELECT * FROM cargo";
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
