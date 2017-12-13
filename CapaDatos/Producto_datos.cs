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
    public class Producto_datos
    {
        //inserta un producto_simple en la base de datos
        public static bool guardar_PrSimple(int id, string nombre, string descripcion, int categoria, float precio_venta, float precio_costo, int a_la_venta, string marca, int stock, int stock_minimo)
        {

            //Pasamos a la consulta los valores por parametro
            string Query = @"INSERT INTO `producto`(id_producto, nombre,descripcion,categoria,precio_venta,precio_costo,lista_precio,baja,marca,stock,stock_minimo)
                            VALUES ( @id, @nombre, @descripcion, @categoria, @p_venta, @p_costo, @a_la_venta,0,@marca,@stock,@stock_minimo) ";

            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(Query);


                cx.Cmd.Parameters.Add("@id", MySqlDbType.Int32);
                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters[0].Value = id;

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters[1].Value = nombre;

                cx.Cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar);
                cx.Cmd.Parameters[2].Value = descripcion;

                cx.Cmd.Parameters.Add("@categoria", MySqlDbType.Int32);
                cx.Cmd.Parameters[3].Value = categoria;

                cx.Cmd.Parameters.Add("@p_venta", MySqlDbType.Float);
                cx.Cmd.Parameters[4].Value = precio_venta;

                cx.Cmd.Parameters.Add("@p_costo", MySqlDbType.Float);
                cx.Cmd.Parameters[5].Value = precio_costo;

                cx.Cmd.Parameters.Add("@a_la_venta", MySqlDbType.Int32);
                cx.Cmd.Parameters[6].Value = a_la_venta;

                cx.Cmd.Parameters.Add("@marca", MySqlDbType.VarChar);
                cx.Cmd.Parameters[7].Value = marca;

                cx.Cmd.Parameters.Add("@stock", MySqlDbType.Int32);
                cx.Cmd.Parameters[8].Value = stock;

                cx.Cmd.Parameters.Add("@stock_minimo", MySqlDbType.Int32);
                cx.Cmd.Parameters[9].Value = stock_minimo;


                cx.abrir();
                cx.Cmd.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {
                    MessageBox.Show("El código ya esta siendo utilizado por un producto, elija otro", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
        }


        //inserta un producto_compuesto en la base de datos
        public static bool guardar_Producto_Compuesto(int id, string nombre, string descripcion, int categoria, float precio_venta, float precio_costo, int a_la_venta)
        {

            //Pasamos a la consulta los valores por parametro
            string Query = @"INSERT INTO `producto`(id_producto, nombre,descripcion,categoria,precio_venta,precio_costo,lista_precio,baja)
                            VALUES ( @id, @nombre, @descripcion, @categoria, @p_venta, @p_costo, @a_la_venta,0) ";

            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(Query);


                cx.Cmd.Parameters.Add("@id", MySqlDbType.Int32);
                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters[0].Value = id;

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters[1].Value = nombre;

                cx.Cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar);
                cx.Cmd.Parameters[2].Value = descripcion;

                cx.Cmd.Parameters.Add("@categoria", MySqlDbType.Int32);
                cx.Cmd.Parameters[3].Value = categoria;

                cx.Cmd.Parameters.Add("@p_venta", MySqlDbType.Float);
                cx.Cmd.Parameters[4].Value = precio_venta;

                cx.Cmd.Parameters.Add("@p_costo", MySqlDbType.Float);
                cx.Cmd.Parameters[5].Value = precio_costo;

                cx.Cmd.Parameters.Add("@a_la_venta", MySqlDbType.Int32);
                cx.Cmd.Parameters[6].Value = a_la_venta;




                cx.abrir();
                cx.Cmd.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {
                    MessageBox.Show("El código ya esta siendo utilizado por un producto, elija otro", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
        }

        public static bool GetProducto(int id_producto, ref string[] producto)
        {
            //para setear un string de varias líneas se debe agregar un @antes de las primeras comillas dobles del string
            string sql = "SELECT * FROM producto where id_producto = " + id_producto + " and baja = 0";
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
                                producto[i] = reader.GetString(i);
                            }
                            catch (Exception)
                            {
                                producto[i] = "";
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

        public static bool ActualizarStock(int id_producto, int stock)
        {
            string consulta = "UPDATE producto SET stock = @stock WHERE id_producto = @id_producto";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@stock", MySqlDbType.Int32);

                cx.Cmd.Parameters[0].Value = id_producto;
                cx.Cmd.Parameters[1].Value = stock;

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

        public static bool ActualizarCosto(int id_producto, float costo)
        {
            string consulta = "UPDATE producto SET precio_costo = @costo WHERE id_producto = @id_producto";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters.Add("@costo", MySqlDbType.Float);

                cx.Cmd.Parameters[0].Value = id_producto;
                cx.Cmd.Parameters[1].Value = costo;

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

        //devuelve un dataTable con los productos que se usan como ingredientes para las recetas
        public static DataTable cargarComboProducto()
        {
            DataTable data = new DataTable();
            string Query = "SELECT id_producto, CONCAT(nombre, ' - ' ,marca) as nombre FROM `producto` WHERE baja = 0 and lista_precio = 0  order by nombre";
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

        // Busca el ultimo id_producto y le suma uno
        public static int ultimo_id_producto()
        {
            int id = 0;
            string Query = "SELECT MAX(id_producto) + 1 as ultimo_id FROM `producto`";
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

        public static DataTable getAll()
        {
            DataTable dt = new DataTable();

            string consulta = @"SELECT p.id_producto,p.nombre,p.descripcion,p.marca,p.stock,p.stock_minimo,p.precio_venta,p.precio_costo ,cat.categoria
                                FROM producto p
                                INNER JOIN categoria cat on cat.id_categoria = p.categoria
                                where baja = 0";
            Conexion Cx = new Conexion();
            try
            {
                Cx.setSQL(consulta);
                Cx.abrir();
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(dt); //Cargamos data table   
            }
            catch (MySqlException ex)
            {
                dt = null;
                MessageBox.Show("Error", "Error al cargar todos los producto en la tabla\n" + ex.Message);
            }
            Cx.cerrar();
            return dt;
        }

        public static DataTable getProductosVenta()
        {
            DataTable dt = new DataTable();

            string consulta = @"SELECT p.id_producto,p.nombre,p.descripcion,p.marca,p.stock,p.stock_minimo,p.precio_venta,p.precio_costo ,cat.categoria
                                FROM producto p
                                INNER JOIN categoria cat on cat.id_categoria = p.categoria
                                where p.baja = 0 and p.lista_precio = 1";

            Conexion Cx = new Conexion();
            try
            {
                Cx.setSQL(consulta);
                Cx.abrir();
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(dt); //Cargamos data table   
            }
            catch (MySqlException ex)
            {
                dt = null;
                MessageBox.Show("Error", "Error al cargar todos los producto en la tabla\n" + ex.Message);
            }
            Cx.cerrar();
            return dt;
        }

        

        public static DataTable buscarProducto(string consulta, string columna)
        {
            DataTable dt = new DataTable();

            string query;


            if (columna.Equals("nombre"))
            {
                query = @"select p.id_producto,p.nombre,p.descripcion,p.marca,p.stock,p.stock_minimo,p.precio_venta,p.precio_costo ,cat.categoria
                                FROM producto p
                                INNER JOIN categoria cat on cat.id_categoria = p.categoria
                                where baja = 0 AND Concat (p.nombre,' ', p.marca) like '%" + consulta + "%'";
            }
            else
            {
                query = @"select p.id_producto,p.nombre,p.descripcion,p.marca,p.stock,p.stock_minimo,p.precio_venta,p.precio_costo ,cat.categoria
                                FROM producto p
                                INNER JOIN categoria cat on cat.id_categoria = p.categoria
                                where baja = 0 AND "+ columna +" like '%" + consulta + "%'";
            }
           

            Conexion Cx = new Conexion();
            try
            {
                Cx.setSQL(query);
                Cx.abrir();

                //Cx.Cmd.Parameters.Add("@columna", MySqlDbType.VarChar);
                //Cx.Cmd.Parameters[0].Value = columna;

                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(dt); //Cargamos data table   
            }
            catch (MySqlException ex)
            {
                dt = null;
                MessageBox.Show("Error", "Error al cargar los producto en la tabla\n" + ex.Message);
            }
            Cx.cerrar();
            return dt;
        }

        public static bool bajaProducto(int id_producto)
        {
            string consulta = "UPDATE producto SET baja = 1 WHERE id_producto = @id_producto";

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                
                cx.Cmd.Parameters[0].Value = id_producto;

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

        public static DataSet getReceta(int id_producto)
        {
            DataSet ds;

            string query = "select * from receta where baja = 0 and id_producto = @id_producto";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);
               
                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters[0].Value = id_producto;
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(cx.Cmd);

                
                ds = new DataSet();
                sqlDat.Fill(ds); //Cargamos data set                
            }
            catch (MySqlException mse)
            {
                ds = null;
                MessageBox.Show(mse.Message,"ERROR");
            }


            cx.cerrar();
            return ds;
        }

        public static DataTable getCompuestos()
        {
            DataTable ds;

            string query = @" SELECT * FROM producto p
                            WHERE id_producto IN      
                                     (SELECT DISTINCT id_producto 
                                     FROM receta r 
                                     WHERE r.baja = 0) 
                            AND p.baja = 0";

            Conexion cx = new Conexion();
            try
            {
                cx.abrir();
                cx.setSQL(query);

              
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(cx.Cmd);


                ds = new DataTable();
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

        public static DataTable getProducto(int id_producto)
        {
            DataTable dt = new DataTable();

            string consulta = @"SELECT *
                                FROM producto p  
                                WHERE baja = 0 and id_producto = @id_producto";
            Conexion Cx = new Conexion();
            try
            {
                Cx.setSQL(consulta);
                Cx.abrir();
                Cx.Cmd.Parameters.Add("id_producto",MySqlDbType.Int32);
                Cx.Cmd.Parameters[0].Value = id_producto;

                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(dt); //Cargamos data table   
            }
            catch (MySqlException ex)
            {
                dt = null;
                MessageBox.Show("Error", "Error al cargar todos los producto en la tabla\n" + ex.Message);
            }
            Cx.cerrar();
            return dt;
        }

        //actualiza un producto_simple en la base de datos
        public static bool updateProductoSimple(int id, string nombre, string descripcion, int categoria, float precio_venta, float precio_costo, int a_la_venta, string marca, int stock, int stock_minimo)
        {

            //Pasamos a la consulta los valores por parametro
            string Query = @"UPDATE producto 
                            SET `nombre`=@nombre,
                            `descripcion`=@descripcion,
                            `marca`=@marca,
                            `categoria`= @categoria,
                            `stock`= @stock,
                            `stock_minimo`= @stock_minimo,
                            `precio_venta`= @p_venta,
                            `precio_costo`= @p_costo,
                            `lista_precio`= @lista_precio
                             WHERE id_producto = @id_producto";

            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(Query);


            

                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters[0].Value = nombre;

                cx.Cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar);
                cx.Cmd.Parameters[1].Value = descripcion;

                cx.Cmd.Parameters.Add("@marca", MySqlDbType.VarChar);
                cx.Cmd.Parameters[2].Value = marca;

                cx.Cmd.Parameters.Add("@categoria", MySqlDbType.Int32);
                cx.Cmd.Parameters[3].Value = categoria;

                cx.Cmd.Parameters.Add("@stock", MySqlDbType.Int32);
                cx.Cmd.Parameters[4].Value = stock;

                cx.Cmd.Parameters.Add("@stock_minimo", MySqlDbType.Int32);
                cx.Cmd.Parameters[5].Value = stock_minimo;

                cx.Cmd.Parameters.Add("@p_venta", MySqlDbType.Float);
                cx.Cmd.Parameters[6].Value = precio_venta;

                cx.Cmd.Parameters.Add("@p_costo", MySqlDbType.Float);
                cx.Cmd.Parameters[7].Value = precio_costo;

                cx.Cmd.Parameters.Add("@lista_precio", MySqlDbType.Int32);
                cx.Cmd.Parameters[8].Value = a_la_venta;

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters[9].Value = id;



                cx.abrir();
                cx.Cmd.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {
                    MessageBox.Show("El código ya esta siendo utilizado por un producto, elija otro", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
        }

        //actualiza un producto_compuesto en la base de datos
        public static bool updateProductoCompuesto(int id, string nombre, string descripcion, int categoria, float precio_venta, float precio_costo, int a_la_venta)
        {

            //Pasamos a la consulta los valores por parametro
            string Query = @"UPDATE producto 
                            SET `nombre`= @nombre,
                            `descripcion`= @descripcion,
                            `categoria`= @categoria,
                            `precio_venta`= @p_venta,
                            `precio_costo`= @p_costo,
                            `lista_precio`= @lista_precio
                             WHERE id_producto = @id_producto";


            try
            {
                //establecemos conexion
                Conexion cx = new Conexion();
                cx.setSQL(Query);

                //le pasamos el valor a los parametros en orden
                cx.Cmd.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cx.Cmd.Parameters[0].Value = nombre;

                cx.Cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar);
                cx.Cmd.Parameters[1].Value = descripcion;

                cx.Cmd.Parameters.Add("@categoria", MySqlDbType.Int32);
                cx.Cmd.Parameters[2].Value = categoria;

                cx.Cmd.Parameters.Add("@p_venta", MySqlDbType.Float);
                cx.Cmd.Parameters[3].Value = precio_venta;

                cx.Cmd.Parameters.Add("@p_costo", MySqlDbType.Float);
                cx.Cmd.Parameters[4].Value = precio_costo;

                cx.Cmd.Parameters.Add("@lista_precio", MySqlDbType.Int32);
                cx.Cmd.Parameters[5].Value = a_la_venta;

                cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
                cx.Cmd.Parameters[6].Value = id;



                cx.abrir();
                cx.Cmd.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                if (e.Number == 1062)
                {
                    MessageBox.Show("EEEEEl código ya esta siendo utilizado por un producto, elija otro", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(e.Message);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
        }



        public static DataTable cargarComboSimple()
        {
            DataTable data = new DataTable();
            //string Query = "SELECT 0 id_producto, 'Seleccionar..' nombre UNION (SELECT id_producto, CONCAT(id_producto,' - ',nombre) as nombre FROM `producto` WHERE baja = 0 order by id_producto)";
            string Query = "SELECT id_producto FROM producto WHERE baja = 0 order by id_producto";
            Conexion Cx = new Conexion();
            try
            {
                Cx.setSQL(Query);
                Cx.abrir();
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(Cx.Cmd);
                sqlDat.Fill(data); //Cargamos data table
            }
            catch (Exception e)
            {
                data = null;
                MessageBox.Show(e.Message);

            }
            Cx.cerrar();
            return data;
        }


        public static string getDescripcionProducto(int id_producto)
        {
            string descrip = "";
            string Query = "SELECT nombre FROM `producto` WHERE id_producto = " + id_producto;
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
                        descrip = reader.GetString(0);
                    }
                }
                reader.Close();

            }
            catch (Exception e)
            {
                descrip = "";
                MessageBox.Show(e.Message, "Error al buscar nombre de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cx.cerrar();
            return descrip;
        }
        public static List<string[]> ProductosConsumidosComanda(DateTime desde, DateTime hasta)
        {
            string consulta = @"select det_com.tipo, det_com.id_producto, descripcion, sum(det_com.cantidad)
                                from
                                (select if(exists(select id_producto from receta where id_producto = dc.id_producto), 'Compuesto', 'Simple') as tipo, dc.*
                                from detalle_comanda dc
                                inner join comanda c
                                on c.id_comanda = dc.id_comanda
                                where c.fecha between @desde and @hasta
                                ) det_com
                                inner join producto p
                                on det_com.id_producto = p.id_producto
                                group by det_com.id_producto
                                order by tipo";

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
                    lista.Add(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() });
                }

                return lista;
            }
            catch (Exception e)
            {
                return lista;
            }
        }

        public static List<string[]> MPConsumidaPorCompuestos(DateTime desde, DateTime hasta)
        {
            string consulta = @"select dr.id_producto, p.nombre, sum(dc.cantidad*dr.cantidad) as total, u.unidad
                                from detalle_comanda dc
                                inner join receta r
                                on dc.id_producto = r.id_producto
                                left join detalle_receta dr
                                on r.id_receta = dr.id_receta
                                inner join producto p
                                on dr.id_producto = p.id_producto
                                inner join unidad u
                                on dr.unidad = u.id_unidad
                                inner join comanda c
                                on c.id_comanda = dc.id_comanda
                                where dc.id_producto in
                                (select id_producto from receta)
                                and r.baja = 0
                                and c.fecha between @desde and @hasta
                                group by dr.id_producto, p.nombre, u.unidad";

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
                    lista.Add(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() });
                }

                return lista;
            }
            catch (Exception e)
            {
                return lista;
            }
        }

        public static List<string[]> PreciosPorCategoria()
        {
            string consulta = @"select c.categoria, id_producto, nombre, precio_venta
                                from producto p
                                inner join categoria c
                                on p.categoria = c.id_categoria";

            List<string[]> lista = new List<string[]>();

            DataTable dt = new DataTable();

            try
            {
                Conexion cx = new Conexion();
                cx.tipoTexto();
                cx.setSQL(consulta);

                MySqlDataAdapter sqlDate = new MySqlDataAdapter(cx.Cmd);
                sqlDate.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() });
                }

                return lista;
            }
            catch (Exception e)
            {
                return lista;
            }
        }










        //public static DataSet getTodasRecetas(int id_producto)
        //{
        //    DataSet ds;

        //    string query = "select COUNT(*) from receta where id_producto = @id_producto";

        //    Conexion cx = new Conexion();
        //    try
        //    {
        //        cx.abrir();
        //        cx.setSQL(query);

        //        cx.Cmd.Parameters.Add("@id_producto", MySqlDbType.Int32);
        //        cx.Cmd.Parameters[0].Value = id_producto;
        //        MySqlDataAdapter sqlDat = new MySqlDataAdapter(cx.Cmd);


        //        ds = new DataSet();
        //        sqlDat.Fill(ds); //Cargamos data set                
        //    }
        //    catch (MySqlException mse)
        //    {
        //        ds = null;
        //        MessageBox.Show(mse.Message, "ERROR");
        //    }


        //    cx.cerrar();
        //    return ds;
        //}




































































































    }


}
