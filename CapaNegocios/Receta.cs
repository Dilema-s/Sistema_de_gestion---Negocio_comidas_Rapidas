using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class Receta
    {
        private int id_receta;
        private string nombre;
        private int id_producto;
        private DateTime fecha;
        private float precio_venta;
        LinkedList<int> listaIngredientes;

        public Receta()
        {
            Id_receta = ultimo_id_receta();
            listaIngredientes = new LinkedList<int>();
            Precio_venta = 0;
        }

        public Receta(int id_producto, string nombre, DateTime fecha, float p_venta)
        {
            Id_receta = ultimo_id_receta();          
            Nombre = nombre;
            Fecha = fecha;
            Precio_venta = 0;
            listaIngredientes = new LinkedList<int>();
        }



        public int Id_receta
        {
            get { return id_receta; }
            set { id_receta = value; }
        }

        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public float Precio_venta
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }

        public LinkedList<int> ListaIngredientes
        {
            get { return listaIngredientes; }
            set { listaIngredientes = value; }
        }



    

        private int ultimo_id_receta()
        {
            return Receta_datos.ultimo_id_receta();
        }

        public  bool guardarReceta()
        {
            return Receta_datos.guardarReceta(Id_receta,Id_producto,Precio_venta,Nombre,Fecha);
        }

        public bool actualizarReceta()
        {
            return Receta_datos.actualizarReceta(Id_receta, Nombre);
        }

        public DataTable recuperarDetalles()
        {
            return Receta_datos.recuperarDetalles(Id_receta);
        }

        public static DataTable recuperarDetalles(int id_receta)
        {
            return Receta_datos.recuperarDetalles(id_receta);
        }

        public static bool bajaReceta(int id_recetaa, int id_producto)
        {
            return Receta_datos.bajaReceta(id_recetaa, id_producto);
        }

        public static DataSet getReceta(int id_receta)
        {
            return Receta_datos.getReceta(id_receta);
        }



























































    }
}
