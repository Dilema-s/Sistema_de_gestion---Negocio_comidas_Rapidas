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
    public class Comanda_datos
    {

        // inserta una comanda con todos sus datos excepto total que se actualiza al final
        public static bool insertComanda(int id_comanda,int puesto, DateTime fecha, int id_mozo, int mesa, float total, int estado)
        {
            string consulta = @"INSERT INTO comanda (`id_comanda`, `puesto`, `fecha`, `id_persona`, `mesa`, `total`, `estado`, `baja`) 
                                VALUES (@id_comanda ,@puesto,@fecha,@id_mozo,@mesa,@total,@estado, 0)";

            bool resultado = false;
            Conexion cx = new Conexion();
            try
            {
                //establecemos conexion

                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters[0].Value = id_comanda;

                cx.Cmd.Parameters.Add("@puesto", MySqlDbType.Int32);
                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters[1].Value = puesto;

                cx.Cmd.Parameters.Add("fecha", MySqlDbType.DateTime);
                cx.Cmd.Parameters[2].Value = fecha;

                cx.Cmd.Parameters.Add("@id_mozo", MySqlDbType.Int32);
                cx.Cmd.Parameters[3].Value = id_mozo;

                cx.Cmd.Parameters.Add("@mesa", MySqlDbType.Int32);
                cx.Cmd.Parameters[4].Value = mesa;

                cx.Cmd.Parameters.Add("@total", MySqlDbType.Float);
                cx.Cmd.Parameters[5].Value = total;
        
                cx.Cmd.Parameters.Add("@estado", MySqlDbType.Int32);
                cx.Cmd.Parameters[6].Value = estado;

                cx.abrir();
                cx.Cmd.ExecuteNonQuery();

                resultado =  true;
            }
            catch (MySqlException e)
            {
                resultado = false;
                MessageBox.Show(e.Message);
            }

            cx.cerrar();
            return resultado;
        }

        public static DataSet getComanda(int id_comanda)
        {
            DataSet ds;

            string query = "select * from comanda where baja = 0 and id_comanda = @id_comanda";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);

                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_comanda;
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

        // Busca el ultimo id_comanda y le suma uno
        public static int ultimo_id_comanda()
        {
            int id = 0;
            string Query = "SELECT MAX(id_comanda) + 1 as ultimo_id FROM comanda";
            Conexion Cx = new Conexion();
            try
            {

                Cx.abrir();
                Cx.setSQL(Query);
                MySqlDataReader reader = Cx.Cmd.ExecuteReader();

                if (reader.HasRows) // pregunta si hay datos
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("ultimo_id");
                    }
                }
                reader.Close();

            }
            catch (Exception e)
            {
                id = 0;
                MessageBox.Show(e.Message, "Error con la carga del ultimo id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cx.cerrar();
            return id;
        }

        public static DataSet getAll(DateTime fecha)
        {
            DataSet ds;

            string query = @"SELECT `id_comanda`,  `fecha`, `id_persona`, `mesa`, `total`, es.estado , es.id_estadoComanda
                            FROM comanda c 
                            INNER JOIN estadocomanda es ON es.id_estadoComanda = c.estado 
                            WHERE fecha BETWEEN @desde AND @hasta";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);

                cx.Cmd.Parameters.Add("@desde", MySqlDbType.String);
                cx.Cmd.Parameters[0].Value = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString() + " 00:00:00";
                cx.Cmd.Parameters.Add("@hasta", MySqlDbType.String);
                cx.Cmd.Parameters[1].Value = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString() + " 23:59:59";

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

        //actualiza un producto_simple en la base de datos
        public static bool bajaComanda(int id_comanda)
        {

            string consulta = "select sum(total) as total from detalle_comanda where id_comanda = @id_comanda and baja = 0";

            //Pasamos a la consulta los valores por parametro
            string Query = @"UPDATE `comanda` 
                            SET `total`= @total,
                            `estado`= @id_estado,
                            `baja`= 1 
                             WHERE id_comanda = @id_comanda";

            

            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(consulta);
                int total = 0;
                int estado = 2;
                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_comanda;

                
                cx.abrir();
                MySqlDataReader reader = cx.Cmd.ExecuteReader();

                if (reader.HasRows) // pregunta si hay datos
                {

                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            total = 0;
                            estado = 3;
                            MessageBox.Show("La comanda esta vacia, no posee ningún producto cargado");
                        }
                        else
                        {
                            total = reader.GetInt32("total");
                            estado = 2;
                        }
                    }
                   
                }
                reader.Close();
                cx.cerrar();

                Conexion Cx = new Conexion();
                Cx.abrir();
                Cx.setSQL(Query);

                Cx.Cmd.Parameters.Add("@total", MySqlDbType.Int32);
                Cx.Cmd.Parameters[0].Value = total;

                Cx.Cmd.Parameters.Add("@id_estado", MySqlDbType.Int32);
                Cx.Cmd.Parameters[1].Value = estado;

                Cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                Cx.Cmd.Parameters[2].Value = id_comanda;

                Cx.Cmd.ExecuteNonQuery();
                Cx.cerrar();
               
                
                return true;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1048)
                {
                    MessageBox.Show("La comanda esta vacia, no posee ningún producto cargado");
                    return true;
                }
                else
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                              
                
            }
        }

        public static List<string[]> VentasPorDia(DateTime desde, DateTime hasta)
        {
            string consulta = @"select DATE(fecha), sum(c.total)
                                from comanda c
                                inner join detalle_comanda dc
                                on c.id_comanda = dc.id_comanda
                                where fecha between @desde and @hasta
                                group by DATE(fecha)";

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
                    lista.Add(new string[] { row[0].ToString(), row[1].ToString() });
                }

                return lista;
            }
            catch (Exception e)
            {
                return lista;
            }
        }

        //calcula el subtotal de una comanda 
        public static int getSubtotal(int id_comanda)
        {

            string consulta = "select sum(total) as subtotal from detalle_comanda where id_comanda = @id_comanda and baja = 0";

            //Pasamos a la consulta los valores por parametro
            string Query = @"UPDATE comanda 
                            SET `total`= @total
                             WHERE id_comanda = @id_comanda and baja = 0";



            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(consulta);
                int subtotal = 0;
                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_comanda;


                cx.abrir();
                MySqlDataReader reader = cx.Cmd.ExecuteReader();

                if (reader.HasRows) // pregunta si hay datos
                {

                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            subtotal = 0;                           
                        }
                        else
                        {
                            subtotal = reader.GetInt32("subtotal");
                        }
                    }

                }
                reader.Close();
                cx.cerrar();

                Conexion Cx = new Conexion();
                Cx.abrir();
                Cx.setSQL(Query);

                Cx.Cmd.Parameters.Add("@total", MySqlDbType.Int32);
                Cx.Cmd.Parameters[0].Value = subtotal;

                Cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                Cx.Cmd.Parameters[1].Value = id_comanda;

                Cx.Cmd.ExecuteNonQuery();
                Cx.cerrar();


                return subtotal;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1048)
                {
                    MessageBox.Show("La comanda esta vacia, no posee ningún producto cargado");
                    return -1;
                }
                else
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }


            }
        }























    }
}
