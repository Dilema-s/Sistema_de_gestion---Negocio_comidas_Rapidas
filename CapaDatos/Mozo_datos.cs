using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Mozo_datos
    {
        public static bool GetMozo(Int32 id, ref string[] mozo)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM mozo where id_mozo = " + id + " and activo = 1";
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
                        for (int i = 0; i <= 7; i++)
                        {
                            try
                            {
                                mozo[i] = reader.GetString(i);
                            }
                            catch (Exception)
                            {
                                mozo[i] = "";
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

        public static bool Guardar(string dni, string nombre, string apellido, string calle, int numero, string telefono, int activo)
        {
            string consulta = @"INSERT INTO mozo (nombre, apellido, calle, nro, dni, telefono, activo) 
                              VALUES 
                              (@nombre, @apellido, @calle, @numero, @dni, @telefono, @activo)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@calle", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@numero", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@dni", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@telefono", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@activo", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = nombre;
                cx.Cmd.Parameters[1].Value = apellido;
                cx.Cmd.Parameters[2].Value = calle;
                cx.Cmd.Parameters[3].Value = numero;
                cx.Cmd.Parameters[4].Value = dni;
                cx.Cmd.Parameters[5].Value = telefono;
                cx.Cmd.Parameters[6].Value = activo;

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

        public static bool Actualizar(Int32 id, string dni, string nombre, string apellido, string calle, int nro, string telefono, short activo)
        {
            string consulta = @"UPDATE mozo SET nombre = @nombre, apellido = @apellido, calle = @calle,
                                nro = @numero, dni = @dni, telefono = @telefono WHERE id_mozo = @id"; 

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@calle", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@numero", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@dni", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@telefono", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@id", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = nombre;
                cx.Cmd.Parameters[1].Value = apellido;
                cx.Cmd.Parameters[2].Value = calle;
                cx.Cmd.Parameters[3].Value = nro;
                cx.Cmd.Parameters[4].Value = dni;
                cx.Cmd.Parameters[5].Value = telefono;
                cx.Cmd.Parameters[6].Value = id;

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

        public static bool Eliminar(int id)
        {
            string sql = "UPDATE mozo SET activo = 0 WHERE id_mozo = " + id;

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(sql);

                cx.abrir();
                cx.Cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static DataTable getAll()
        {
            string sql = "SELECT nombre, apellido, dni, id_mozo FROM mozo WHERE activo = 1";
            DataTable dt = new DataTable();

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(sql);
                MySqlDataAdapter sqlDate = new MySqlDataAdapter(cx.Cmd);
                sqlDate.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }
    }
}
