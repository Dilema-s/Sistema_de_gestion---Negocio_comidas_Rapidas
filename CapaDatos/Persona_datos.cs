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
    public class Persona_datos
    {
        public static bool GetPersona(int id_persona, ref string[] persona)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM persona where id_persona = " + id_persona + " and baja = 0";
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
                        for (int i = 0; i <= 9; i++)
                        {
                            try
                            {
                                persona[i] = reader.GetString(i);
                            }
                            catch (Exception)
                            {
                                persona[i] = "";
                               
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

        public static DataTable getAll()
        {
            string sql = "SELECT nombre, apellido, cargo, id_persona FROM persona WHERE baja = 0";
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

       

        public static bool Eliminar(int id)
        {
            string sql = "UPDATE persona SET baja = 1 WHERE id_persona = " + id;

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

        public static int Guardar(string nombre, string apellido, int dni, int cargo, string calle, string altura, string telefono, DateTime fechaIngreso, short baja)
        {
            string consulta = @"INSERT INTO persona (nombre, apellido, dni, cargo, calle, altura, telefono, fecha_ingreso, baja) 
                              VALUES 
                              (@nombre, @apellido, @dni, @cargo, @calle, altura, @telefono, @fecha_ingreso, @baja)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@dni", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@cargo", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@calle", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@altura", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@telefono", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@fecha_ingreso", MySqlDbType.Date);
                cx.Cmd.Parameters.Add("@baja", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = nombre;
                cx.Cmd.Parameters[1].Value = apellido;
                cx.Cmd.Parameters[2].Value = dni;
                cx.Cmd.Parameters[3].Value = cargo;
                cx.Cmd.Parameters[4].Value = calle;
                cx.Cmd.Parameters[5].Value = altura;
                cx.Cmd.Parameters[6].Value = telefono;
                cx.Cmd.Parameters[7].Value = fechaIngreso;
                cx.Cmd.Parameters[8].Value = baja;

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

        public static bool Actualizar(int id, string nombre, string apellido, int dni, int cargo, string calle, string altura, string telefono, DateTime fechaIngreso, short baja)
        {
            string consulta = @"UPDATE persona SET nombre = @nombre, apellido = @apellido, dni = @dni, cargo = @cargo, calle = @calle,
                                altura = @altura, telefono = @telefono, fecha_ingreso = @fecha_ingreso WHERE id_persona = @id";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@dni", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@cargo", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@calle", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@altura", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@telefono", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@fecha_ingreso", MySqlDbType.Date);
                cx.Cmd.Parameters.Add("@id", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = nombre;
                cx.Cmd.Parameters[1].Value = apellido;
                cx.Cmd.Parameters[2].Value = dni;
                cx.Cmd.Parameters[3].Value = cargo;
                cx.Cmd.Parameters[4].Value = calle;
                cx.Cmd.Parameters[5].Value = altura;
                cx.Cmd.Parameters[6].Value = telefono;
                cx.Cmd.Parameters[7].Value = fechaIngreso;
                cx.Cmd.Parameters[8].Value = id;

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

        public static List<string[]> VentasPorMozo(DateTime desde, DateTime hasta)
        {
            string consulta = @"SELECT c.id_persona, CONCAT(p.nombre, ' ', apellido) as Nombre, SUM(cantidad*precio_venta) as Ventas
                            FROM comanda c
                            INNER JOIN detalle_comanda dc
                            ON c.id_comanda = dc.id_comanda
                            INNER JOIN persona p
                            ON c.id_persona = p.id_persona
                            WHERE c.fecha BETWEEN @desde AND @hasta
                            GROUP BY id_persona";

            List<string[]> lista = new List<string[]>();

            DataTable dt = new DataTable();

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);


                cx.Cmd.Parameters.Add("@desde", MySqlDbType.DateTime);
                cx.Cmd.Parameters.Add("@hasta", MySqlDbType.DateTime);

                cx.Cmd.Parameters[0].Value = desde;
                cx.Cmd.Parameters[1].Value = hasta;

                MySqlDataAdapter sqlDate = new MySqlDataAdapter(cx.Cmd);
                sqlDate.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString() });
                }

                return lista;
            }
            catch (Exception e)
            {
                return lista;
            }
        }

        public static DataSet getpersona(int id_persona)
        {
            DataSet ds;

            string query = "select * from persona where baja = 0 and id_persona = @id_persona";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);
    
                cx.Cmd.Parameters.Add("@id_persona", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_persona;
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(cx.Cmd);


                ds = new DataSet();
                sqlDat.Fill(ds); //Cargamos data set                
            }
            catch (MySqlException mse)
            {
                ds = null;
                MessageBox.Show(mse.Message, "ERROR");
            }


            cx.cerrar();
            return ds;
        }






















    }
}
