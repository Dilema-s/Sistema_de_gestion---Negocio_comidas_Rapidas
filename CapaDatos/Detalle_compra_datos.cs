using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Detalle_compra_datos
    {
        //public static bool GetDetalle(int numero_comprobante, ref string[] detalle)
        //{
        //    //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
        //    string sql = "SELECT * FROM mozo where id_mozo = " + id + " and activo = 1";
        //    try
        //    {
        //        Conexion cx = new Conexion();
        //        cx.setSQL(sql);
        //        cx.abrir();
        //        MySqlDataReader reader = cx.Cmd.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                for (int i = 0; i <= 7; i++)
        //                {
        //                    try
        //                    {
        //                        mozo[i] = reader.GetString(i);
        //                    }
        //                    catch (Exception)
        //                    {
        //                        mozo[i] = "";
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //        reader.Close();
        //        cx.cerrar();
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public static bool Guardar(int id_producto, double precio, double cantidad, int id_comprobante)
        {
            string consulta = @"INSERT INTO detalle_comprobante (id_producto, precio, cantidad, id_comprobante_compra) 
                              VALUES 
                              (@id_producto, @precio, @cantidad, @id_comprobante_compra)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@precio", MySqlDbType.Double);
                cx.Cmd.Parameters.Add("@cantidad", MySqlDbType.Double);
                cx.Cmd.Parameters.Add("@id_comprobante_compra", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = id_producto;
                cx.Cmd.Parameters[1].Value = precio;
                cx.Cmd.Parameters[2].Value = cantidad;
                cx.Cmd.Parameters[3].Value = id_comprobante;

                cx.abrir();

                cx.Cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //Carga a la lista pasada como parámetro todos los registros de detalles del comprobante 
        public static bool GetDetalles(int numero_comprobante, ref IList<string[]> listaStr)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM detalle_comprobante where id_comprobante_compra = " + numero_comprobante;
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
                        try
                        {
                            listaStr.Add(new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) });
                        }
                        catch (Exception)
                        {
                            listaStr.Add(new string[] { "", "", "", "", "" });
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
    }
}
