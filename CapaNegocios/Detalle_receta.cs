using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Detalle_receta
    {
        private int id_detalle_receta;
        private int id_receta;
 
        private int id_producto;
        private int id_unidad;
        private int baja;
        private float cantidad;

        public Detalle_receta(int id_receta, int id_producto, int unidad, float cantidad, int baja)
        {
            Id_receta = id_receta;
            Id_producto = id_producto;
            Id_unidad = unidad;
            Cantidad = cantidad;
            Id_detalle_receta = 0;
            Baja = baja;
        }

        public int Id_detalle_receta
        {
           get {return id_detalle_receta;}
           set { id_detalle_receta = value; }
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

        public int Id_unidad
        {
            get { return id_unidad; }
            set { id_unidad = value; }
        }

        public int Baja
        {
            get { return baja; }
            set { baja = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }




        public bool guardarDetalle()
        {
            if (Detalle_receta_datos.guardarDetalle(Id_receta, Id_producto, Id_unidad, Cantidad, Baja))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool eliminarDetalle(int id_detalle)
        {
            if (Detalle_receta_datos.bajaDetalle(id_detalle))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static DataSet recuperarDetalle(int id_detalle_receta)
        {
            return Detalle_receta_datos.recuperarDetalle(id_detalle_receta);
        }

        public static bool actualizarDetalle(int id_detalle_receta,int id_producto,int id_unidad,float cantidad)
        {
            if (Detalle_receta_datos.actualizarDetalles(id_detalle_receta, id_producto,id_unidad,cantidad))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        


























    }
}
