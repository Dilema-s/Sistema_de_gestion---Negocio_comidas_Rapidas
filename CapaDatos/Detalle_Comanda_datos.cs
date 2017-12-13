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
    public class Detalle_Comanda_datos
    {
        public static bool guardarDetalle(int id_comanda, int id_producto, string nombre, float cantidad, float precio_venta, float precio_costo, float total, int baja)
        {
            string consulta = @"INSERT INTO detalle_comanda(`id_detalle_comanda`, `id_comanda`, `id_producto`, `nombre`, `cantidad`, `precio_venta`, `precio_costo`, `total`, `baja`) 
                                VALUES (null,@id_comanda,@id_producto,@nombre,@cantidad,@precio_venta,@precio_costo,@total,@baja)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);


                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.String);
                cx.Cmd.Parameters.Add("@cantidad", MySqlDbType.Float);
                cx.Cmd.Parameters.Add("@precio_venta", MySqlDbType.Float);
                cx.Cmd.Parameters.Add("@precio_costo", MySqlDbType.Float);         
                cx.Cmd.Parameters.Add("@total", MySqlDbType.Int16);
                cx.Cmd.Parameters.Add("@baja", MySqlDbType.Int16);


                cx.Cmd.Parameters[0].Value = id_comanda;
                cx.Cmd.Parameters[1].Value = id_producto;
                cx.Cmd.Parameters[2].Value = nombre;
                cx.Cmd.Parameters[3].Value = cantidad;
                cx.Cmd.Parameters[4].Value = precio_venta;
                cx.Cmd.Parameters[5].Value = precio_costo;
                cx.Cmd.Parameters[6].Value = total;
                cx.Cmd.Parameters[7].Value = baja;


                cx.abrir();

                cx.Cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException e)
            {

                if (e.Number == 1062)
                {                   
                    MessageBox.Show("El producto ya esta el la lista, seleccionelo en la tabla, presione en 'Modificar Ingrediente'", "Producto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Detalle_comanda_datos\n" + e.Message);
                }
                return false;

            }
        }

        public static DataSet getDetalle(int id_comanda)
        {
            DataSet ds;

            string query = "select * from detalle_comanda where baja = 0 and id_comanda = @id_comanda";

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

        public static bool detalleRepetido(int id_comanda, int id_producto)
        {

            bool resultado = false;
            string query = "select Count(*) from detalle_comanda where baja = 0 and id_comanda = @id_comanda and id_producto = @id_producto";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);

                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_comanda;
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters[1].Value = id_producto;

                MySqlDataReader reader = cx.Cmd.ExecuteReader();

                if (reader.HasRows) // pregunta si hay datos
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0) > 0)
                        {
                            resultado = true;
                            return resultado;
                        }
                        else
                        {
                            return resultado;
                        }
                    }
                }
                
                else
                {
                    return resultado;
                }
                reader.Close();
                cx.cerrar();                       
            }
            catch (MySqlException mse)
            {               
                MessageBox.Show(mse.Message, "ERROR");
                return resultado;
            }


            cx.cerrar();
            return resultado;
        }

        // true si comanda ya esta abierta, false si no esta abierta
        public static bool verificarComandaAbierta(int mesa, int estado, DateTime desde, DateTime hasta)
        {
            string consulta = @"SELECT count(*) FROM comanda 
                            WHERE mesa = @mesa
                            AND estado = 1 
                            AND fecha BETWEEN @desde AND @hasta";
            try
            {
                Conexion cx = new Conexion();
                cx.abrir();
                cx.tipoTexto();
                cx.setSQL(consulta);


                cx.Cmd.Parameters.Add("@mesa", MySqlDbType.Int32);

                cx.Cmd.Parameters.Add("@desde", MySqlDbType.String);
                cx.Cmd.Parameters.Add("@hasta", MySqlDbType.String);

                cx.Cmd.Parameters[0].Value = mesa;

                cx.Cmd.Parameters[1].Value = desde.Year.ToString() + "-" + desde.Month.ToString() + "-" + desde.Day.ToString() + " 00:00:00";
                cx.Cmd.Parameters[2].Value = hasta.Year.ToString() + "-" + hasta.Month.ToString() + "-" + hasta.Day.ToString() + " 23:59:59";               

                MySqlDataReader reader = cx.Cmd.ExecuteReader();

                if (reader.HasRows) // pregunta si hay datos
                {
                    while (reader.Read())
                    {
                      
                        if (reader.GetInt32(0) > 0)
                        {   
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                else 
                {
                    MessageBox.Show("ERROR. Detalle_Comanda_datos");
                    return false;
                   
                }
                reader.Close();
                cx.cerrar();

                return true;
            }
            catch (MySqlException e)
            {

                if (e.Number == 1062)
                {
                    MessageBox.Show("El producto ya esta el la lista, seleccionelo en la tabla, presione en 'Modificar Ingrediente'", "Producto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Detalle_comanda_datos\n" + e.Message);
                }
                return false;

            }
        }


        public static bool eliminarDetalle(int id_detalle)
        {
            string sql = @"UPDATE detalle_comanda SET baja= 1 WHERE id_detalle_comanda = @id_detalle";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(sql);

                cx.Cmd.Parameters.Add("@id_detalle", MySqlDbType.Int16);
                cx.Cmd.Parameters[0].Value = id_detalle;

                cx.abrir();
                cx.Cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool actualizarCantidad(int id_comanda, int id_producto, int cantidad)
        {

            //string query = "Select cantidad from detalle_comanda where baja = 0 and id_producto = @id_producto and id_comanda = @id_comanda";

            string consulta = @"UPDATE detalle_comanda det 
                              SET `cantidad`= det.cantidad + @cantidad ,`total`=det.precio_venta * det.cantidad  
                              WHERE id_comanda = @id_comanda AND
                              id_producto = @id_producto and baja = 0";
         
            try
            {
                
                Conexion cx = new Conexion();
                cx.tipoTexto();

                cx.Cmd.Parameters.Add("@cantidad", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = cantidad;
                cx.Cmd.Parameters.Add("@id_comanda", MySqlDbType.Int32);
                cx.Cmd.Parameters[1].Value = id_comanda;
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters[2].Value = id_producto;
                


                cx.setSQL(consulta);
                cx.abrir();

                cx.Cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message, "ERROR");
                return false;
            }

        }





























































































    }
}
