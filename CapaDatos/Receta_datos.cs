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
    public class Receta_datos
    {

        //carga el comboBox de las unidades
        public static DataSet cargarCombo()
        {

            DataSet data = new DataSet();

            string Query = "SELECT id_unidad, unidad FROM unidad ORDER BY unidad ";
            // Con el "SELECT 0 id_unidad crea una tabla con id 0 y nombre "Seleccione..", despues con el union une los demas id y nombre restantes de la tabla provincia 

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

        // Busca el ultimo id_receta y le suma uno
        public static int ultimo_id_receta()
        {
            int id = 0;
            string Query = "SELECT MAX(id_receta) + 1 as ultimo_id FROM `receta`";

            try
            {
                Conexion Cx = new Conexion();
                Cx.abrir();
                Cx.setSQL(Query);
                MySqlDataReader reader = Cx.Cmd.ExecuteReader();

                if (reader.HasRows) // pregunta si hay datos
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
                reader.Close();
                Cx.cerrar();
            }
            catch (Exception e)
            {
                id = 0;
                MessageBox.Show(e.Message, "Error con la carga del ultimo id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return id;
        }

        public static bool guardarReceta(int id_receta, int id_producto, float precio_venta, string nombre, DateTime fecha)
        {
            //Pasamos a la consulta los valores por parametro
            string Query = @"INSERT INTO `receta`(id_receta, id_producto, precio_venta, nombre, fecha,baja)
                            VALUES ( @id_receta, @id_producto, @precio_venta, @nombre, @fecha,0) ";

            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(Query);


                cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters[0].Value = id_receta;

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters[1].Value = id_producto;

                cx.Cmd.Parameters.Add("@precio_venta", MySqlDbType.Float);
                cx.Cmd.Parameters[2].Value = precio_venta;

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters[3].Value = nombre;

                cx.Cmd.Parameters.Add("@fecha", MySqlDbType.Date);
                cx.Cmd.Parameters[4].Value = fecha;

                cx.abrir();
                cx.Cmd.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {
                    MessageBox.Show("El código receta ya esta siendo utilizado por otra receta", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
        }

        public static bool actualizarReceta(int id_receta, string nombre)
        {
            string consulta = "UPDATE receta SET nombre = @nombre WHERE id_receta = @id_receta";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = nombre;
                cx.Cmd.Parameters[1].Value = id_receta;

                cx.setSQL(consulta);

                

               

                cx.abrir();

                cx.Cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
         
        }

        public static DataTable recuperarDetalles(int id_receta)
        {

            string consulta = @"SELECT p.nombre,d.id_detalle_receta, d.id_receta,d.cantidad,u.unidad 
                         FROM detalle_receta d 
                         INNER JOIN producto p ON p.id_producto = d.id_producto 
                         INNER JOIN unidad u ON u.id_unidad = d.unidad
                         WHERE d.id_receta = @id_receta and d.baja = 0";

            DataTable data = new DataTable();
            Conexion Cx = new Conexion();
            try
            {
                Cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                Cx.Cmd.Parameters[0].Value = id_receta;
                Cx.setSQL(consulta);
                Cx.abrir();
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(data); //Cargamos data table

            }
            catch (MySqlException e)
            {
                MessageBox.Show("receta_datos" + e.Message);
                data = null;
            }
            Cx.cerrar();
            return data;
        }

        public static bool bajaReceta(int id_receta, int id_producto)
        {
            string consulta = @"UPDATE receta SET baja = 1 
                                WHERE id_receta = @id_receta and id_producto = @id_producto;
                                UPDATE detalle_receta SET baja = 1
                                WHERE id_receta = @id_receta";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();

                cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                
                cx.Cmd.Parameters[0].Value = id_receta;
                cx.Cmd.Parameters[1].Value = id_producto;
           

                cx.setSQL(consulta);
                cx.abrir();
                cx.Cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Receta_datos" + e.Message);
                return false;
            }

        }


        public static DataSet getReceta(int id_receta)
        {
            DataSet ds;

            string query = "select * from receta where baja = 0 and id_receta = @id_receta";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);

                cx.Cmd.Parameters.Add("@id_receta", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_receta;
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


        //public static DataGridView recuperarRecetas(int id_producto)
        //{
        //    string consulta = "select* from receta where id_producto = @id_producto and baja = 0";
        //    try
        //    {
        //        Conexion cx = new Conexion();
        //        cx.tipoTexto();

        //        cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
        //        cx.Cmd.Parameters[0].Value = id_producto;

        //        cx.setSQL(consulta);
        //        cx.abrir();
        //        cx.Cmd.ExecuteNonQuery();

        //        return true;
        //    }
        //    catch (MySqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return false;
        //    }

        //}













































    }
}
