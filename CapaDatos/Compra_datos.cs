using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Compra_datos
    {
        public static bool GetCompra(int numero_comprobante, ref string[] compra)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM comprobante_compra where numero_comp = " + numero_comprobante;
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
                        for (int i = 0; i <= 3; i++)
                        {
                            try
                            {
                                compra[i] = reader.GetString(i);
                            }
                            catch (Exception)
                            {
                                compra[i] = "";
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

        public static int Guardar(int numero_comprobante, DateTime fecha_comprobante, int id_proveedor)
        {
            string consulta = @"INSERT INTO comprobante_compra (numero_comp, fecha, id_proveedor) 
                              VALUES 
                              (@numero_comp, @fecha, @id_proveedor)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@numero_comp", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@fecha", MySqlDbType.DateTime);
                cx.Cmd.Parameters.Add("@id_proveedor", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = numero_comprobante;
                cx.Cmd.Parameters[1].Value = fecha_comprobante;
                cx.Cmd.Parameters[2].Value = id_proveedor;

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

        public static bool Eliminar(int id_compra)
        {
            string sql = "UPDATE comprobante_compra SET baja = 1 WHERE id_comprobante_compra = " + id_compra;

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(sql);
                cx.Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
