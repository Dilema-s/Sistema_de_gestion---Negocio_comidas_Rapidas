using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Producto
    {
        //ATRIBUTOS

        private int id_producto;
        private string nombre;
        private string descripcion;
        private int categoria;
        private float precio_costo;
        private float precio_venta;
        private bool a_la_venta;
        

        //CONSTRUCTOR

        public Producto()
        {

        }

        public Producto(int id, string nombre, string descripcion, int categoria,float precio_venta, float precio_costo, bool a_la_venta)
        {
            Id_producto = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Precio_costo = precio_costo;
            Precio_venta = precio_venta;
            A_la_venta = a_la_venta;
        }


        //GETTER Y SETTER

        public Int32 Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public float Precio_venta
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }

        public float Precio_costo
        {
            get { return precio_costo; }
            set { precio_costo = value; }
        }


        public bool A_la_venta
        {
            get { return a_la_venta; }
            set { a_la_venta = value; }
        }

        //Data table con todos los productos que hacen de ingredientes para las recetas
        public static DataTable cargarComboProducto()
        {
            return Producto_datos.cargarComboProducto();
        }

        //devuelve el ultimo id_producto + 1
        public static int Id_producto_siguiente()
        {
            return Producto_datos.ultimo_id_producto();
        }

        public static DataTable getAll()
        {
            return Producto_datos.getAll();
        }

        public static DataTable getProductosVenta()
        {
            return Producto_datos.getProductosVenta();
        }

        

        public static DataTable getProducto(int id_producto)
        {
            return Producto_datos.getProducto(id_producto);
        }

        public static DataTable buscarProducto(string consulta, string columna)
        {
            return Producto_datos.buscarProducto(consulta, columna);
        }

        public static bool bajaProducto(int id_producto)
        {
            return Producto_datos.bajaProducto(id_producto);
        }

        public static DataSet getReceta(int id_producto)
        {
            return Producto_datos.getReceta(id_producto);
        }

        public static DataTable cargarComboSimple()
        {
            return Producto_datos.cargarComboSimple();
        }

        public static string getDescripcionProducto(int id_producto)
        {
            return Producto_datos.getDescripcionProducto(id_producto);
        }

        public static void ImprimirMateriaPrimaUtilizada(DateTime desde, DateTime hasta)
        {
            List<string[]> listaProdConsCom = new List<string[]>();
            List<string[]> listaConsComp = new List<string[]>();
            listaProdConsCom = Producto_datos.ProductosConsumidosComanda(desde, hasta);
            listaConsComp = Producto_datos.MPConsumidaPorCompuestos(desde, hasta);

            string SheetsName = "Hoja1";
            ExcelManagement em = ExcelManagement.GetInstance();

            em.Open(Application.StartupPath + "\\MateriaPrimaUtilizada.xlsx");

            int c = 2;

            foreach (string[] array in listaProdConsCom)
            {
                em.WriteCell(SheetsName, 1, 1, desde.Date);
                em.WriteCell(SheetsName, 1, 2, hasta.Date);
                em.WriteCell(SheetsName, c, 1, array[0]);
                em.WriteCell(SheetsName, c, 2, Convert.ToInt32(array[1]));
                em.WriteCell(SheetsName, c, 3, array[2]);
                em.WriteCell(SheetsName, c, 4, Convert.ToDouble(array[3]));
                c++;
            }

            c = 2;

            foreach (string[] array in listaConsComp)
            {
                em.WriteCell(SheetsName, c, 6, Convert.ToInt32(array[0]));
                em.WriteCell(SheetsName, c, 7, array[1]);
                em.WriteCell(SheetsName, c, 8, Convert.ToDouble(array[2]));
                em.WriteCell(SheetsName, c, 9, array[3]);
                c++;
            }

            string path = string.Concat(Application.StartupPath, "\\MateriaPrimaUtilizada", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString(), ".xlsx");

            em.SaveAsNew(path);

            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "EXCEL.EXE";
            //startInfo.Arguments = path;
            //Process.Start(startInfo);
            System.Diagnostics.Process.Start(path);

        }

        public static void ImprimirPreciosPorCategoria()
        {
            List<string[]> lista = new List<string[]>();
            lista = Producto_datos.PreciosPorCategoria();

            string SheetsName = "Hoja1";
            ExcelManagement em = ExcelManagement.GetInstance();

            em.Open(Application.StartupPath + "\\PreciosPorCategoria.xlsx");

            int c = 2;

            foreach (string[] array in lista)
            {
                em.WriteCell(SheetsName, c, 1, array[0]);
                em.WriteCell(SheetsName, c, 2, Convert.ToInt32(array[1]));
                em.WriteCell(SheetsName, c, 3, array[2]);
                em.WriteCell(SheetsName, c, 4, Convert.ToDouble(array[3]));
                c++;
            }

            string path = string.Concat(Application.StartupPath, "\\PreciosPorCategoria", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString(), ".xlsx");

            em.SaveAsNew(path);

            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "EXCEL.EXE";
            //startInfo.Arguments = path;
            //Process.Start(startInfo);
            System.Diagnostics.Process.Start(path);

        }

























































































































    }


}
