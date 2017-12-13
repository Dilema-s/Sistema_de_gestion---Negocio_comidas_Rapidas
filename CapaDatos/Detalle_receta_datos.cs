using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Detalle_receta_datos
    {

        public static bool guardarDetalle(int id_receta, int id_producto, int id_unidad, float cantidad, int baja)
        {
            string consulta = @"INSERT INTO detalle_receta (id_detalle_receta, id_receta, id_producto,cantidad, unidad, baja) 
                              VALUES 
                              (0, @id_receta, @id_producto, @cantidad, @unidad, @baja)";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);


                cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@cantidad", MySqlDbType.Float);
                cx.Cmd.Parameters.Add("@unidad", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@baja", MySqlDbType.Int16);


                cx.Cmd.Parameters[0].Value = id_receta;
                cx.Cmd.Parameters[1].Value = id_producto;
                cx.Cmd.Parameters[2].Value = cantidad;
                cx.Cmd.Parameters[3].Value = id_unidad;
                cx.Cmd.Parameters[4].Value = baja;


                cx.abrir();

                cx.Cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException e)
            {

                if (e.Number == 1062)
                {
                    int id_detalle_receta = buscar_id_Detalles(id_receta, id_producto);

                    if (id_detalle_receta > 0)
                    {
                        actualizarDetalles(id_detalle_receta, id_producto, id_unidad, cantidad);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El ingrediente ya esta el la lista, seleccionelo en la tabla y presione en 'Modificar Ingrediente'", "Ingrediente Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Detalle_receta_datos\n" + e.Message);
                }
                return false;

            }
        }

        public static bool actualizarDetalles (int id_detalle_receta, int id_producto, int id_unidad, float cantidad)
        {
            string consulta = @"UPDATE detalle_receta 
                                SET `id_producto`= @id_producto,
                                `cantidad`= @cantidad,
                               `unidad`= @unidad,`baja`= 0
                                WHERE id_detalle_receta = @id_detalle";

            Conexion cx = new Conexion();
            bool retorno;
            try
            {
                cx.setSQL(consulta);

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@cantidad", MySqlDbType.Float);
                cx.Cmd.Parameters.Add("@unidad", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@id_detalle", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = id_producto;
                cx.Cmd.Parameters[1].Value = cantidad;
                cx.Cmd.Parameters[2].Value = id_unidad;
                cx.Cmd.Parameters[3].Value = id_detalle_receta;

                cx.abrir();
                cx.Cmd.BeginExecuteNonQuery();
                MessageBox.Show("Exito", "Exito");
                retorno = true;
            }
            catch (Exception)
            {
                MessageBox.Show("no Exito", "no Exito");
                retorno = false;
            }
            cx.cerrar();
            return retorno;
        }

        public static int buscar_id_Detalles(int id_receta, int id_producto)
        {
            int id_detalle_receta = 0;
            string consulta = @"SELECT id_detalle_receta FROM `detalle_receta` 
                            WHERE id_producto = @id_producto and id_receta = @id_receta and baja = 1";
            Conexion cx = new Conexion();
          
            try
            {
                cx.setSQL(consulta);
                cx.abrir();
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_producto;
                cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                cx.Cmd.Parameters[1].Value = id_receta;


                IAsyncResult result = cx.Cmd.BeginExecuteReader();

                //while (!result.IsCompleted)
                //{
                //    // Wait for 1/10 second, so the counter
                //    // does not consume all available resources 
                //    // on the main thread.
                //    System.Threading.Thread.Sleep(100);
                //}

                using (MySqlDataReader reader = cx.Cmd.EndExecuteReader(result))
                {
                    while (reader.Read())
                    {
                        // Display all the columns. 
                        for (int i = 0; i < reader.FieldCount; i++)
                            id_detalle_receta = reader.GetInt32(i);
                    }
                }
            }
            catch (Exception)
            {
                id_detalle_receta = 0;
            }
            cx.cerrar();
            return id_detalle_receta;
        }

        public static bool bajaDetalle(int id_detalle_receta)
            {
                string consulta = @"UPDATE detalle_receta SET `baja` = 1 
                                    WHERE id_detalle_receta = @id_detalle_receta";

                try
                {
                    Conexion cx = new Conexion();
                    cx.tipoTexto();
                    cx.setSQL(consulta);

                    cx.Cmd.Parameters.Add("@id_detalle_receta", MySqlDbType.Int32);
                    cx.Cmd.Parameters[0].Value = id_detalle_receta;
                    cx.abrir();

                    cx.Cmd.ExecuteNonQuery();

                    return true;
                }
                catch (MySqlException e)
                { 
                    MessageBox.Show("Detalle_receta_datos\n" + e.Message);                 
                    return false;

                }







            }

        public static DataSet recuperarDetalle(int id_detalle_receta)
        {
            string consulta = @"SELECT id_producto, unidad, cantidad FROM `detalle_receta`
                                WHERE `id_detalle_receta` = @id_detalle and baja = 0";

            Conexion cx = new Conexion();
            DataSet ds;
            try
            {
                cx.setSQL(consulta);
                cx.abrir();
                cx.Cmd.Parameters.Add("@id_detalle", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_detalle_receta;
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(cx.Cmd);


                ds = new DataSet();
                sqlDat.Fill(ds); //Cargamos data set     
            }
            catch (Exception mse)
            {
                ds = null;
                MessageBox.Show(mse.Message, "ERROR");
            }
            cx.cerrar();
            return ds;
        }































        }
}
