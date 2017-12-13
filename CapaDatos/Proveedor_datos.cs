using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Proveedor_datos
    {
        public static bool GeProveedor(int id_proveedor, ref string[] proveedor)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM proveedor where id_proveedor = " + id_proveedor + " and baja = 0";
            try
            {
                Conexion cx = new Conexion();
                cx.setSQL(sql);
                cx.abrir();
                MySqlDataReader reader = cx.Cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i <= 2; i++)
                        {
                            try
                            {
                                proveedor[i] = reader.GetString(i);
                            }
                            catch (Exception)
                            {
                                proveedor[i] = "";
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
                reader.Close();
                cx.cerrar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static int Guardar(string nombre_proveedor, short baja)
        {
            string consulta = @"INSERT INTO proveedor (nombre, baja) 
                              VALUES 
                              (@nombre, @baja)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@baja", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = nombre_proveedor;
                cx.Cmd.Parameters[1].Value = baja;

                cx.abrir();

                cx.Cmd.ExecuteNonQuery();

                return Convert.ToInt32(cx.Cmd.LastInsertedId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public static DataTable cargarCombo()
        {
            DataTable data = new DataTable();
            string Query = "SELECT 0 id_proveedor, 'Seleccionar..' nombre UNION (SELECT id_proveedor, CONCAT(id_proveedor,' - ',nombre) as nombre FROM `proveedor` WHERE baja = 0 order by id_proveedor)";
            Conexion Cx = new Conexion();
            try
            {
                Cx.setSQL(Query);
                Cx.abrir();
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(data); //Cargamos data table
            }
            catch (Exception)
            {
                data = null;

            }
            Cx.cerrar();
            return data;
        }
    }
}
