using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Acceso_datos
    {

        public static bool GetAcceso(int id_persona, ref string[] acceso)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM acceso where id_persona = " + id_persona + " and baja = 0";
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
                        for (int i = 0; i <= 4; i++)
                        {
                            try
                            {
                                acceso[i] = reader.GetString(i);
                            }
                            catch (Exception)
                            {
                                acceso[i] = "";
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

        public static bool Guardar(Int32 id_persona, string nombre_usuario, string password, Int16 baja)
        {
            string consulta = @"INSERT INTO acceso (id_persona, nombre_usuario, password, baja) 
                              VALUES 
                              (@id_persona, @nombre_usuario, @password, @baja)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@id_persona", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@nombre_usuario", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@password", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@baja", MySqlDbType.Int16);

                cx.Cmd.Parameters[0].Value = id_persona;
                cx.Cmd.Parameters[1].Value = nombre_usuario;
                cx.Cmd.Parameters[2].Value = password;
                cx.Cmd.Parameters[3].Value = baja;

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

        public static bool Actualizar(Int32 id, Int32 id_persona, string nombre_usuario, string password, Int16 baja)
        {
            string consulta = @"UPDATE acceso SET id_persona = @id_persona, nombre_usuario = @nombre_usuario,
                                password = @password, baja = @baja WHERE id = @id";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@id_persona", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@nombre_usuario", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@password", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@baja", MySqlDbType.Int16);
                cx.Cmd.Parameters.Add("@id", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = id_persona;
                cx.Cmd.Parameters[1].Value = nombre_usuario;
                cx.Cmd.Parameters[2].Value = password;
                cx.Cmd.Parameters[3].Value = baja;
                cx.Cmd.Parameters[4].Value = id;

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

        public static bool GetAcceso(string usuario, string pass)
        {
            string sql = "SELECT * FROM acceso where nombre_usuario = '" + usuario + "' and password = '" + pass + "' and baja = 0";
            try
            {
                Conexion cx = new Conexion();
                cx.setSQL(sql);
                cx.abrir();
                MySqlDataReader reader = cx.Cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
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
        }

        public static bool ActualizarPass(string usuario, string pass)
        {
            string consulta = @"UPDATE acceso
                                SET password = @password WHERE nombre_usuario = @nombre_usuario";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@nombre_usuario", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@password", MySqlDbType.VarChar);

                cx.Cmd.Parameters[0].Value = usuario;
                cx.Cmd.Parameters[1].Value = pass;

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











    }
}
