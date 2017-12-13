using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Detalle_comanda
    {

        private int id_detalle_comanda;
        private int id_comanda;
        private int id_producto;
        private string nombre_producto;
        private float cantidad;
        private float precio_venta;
        private float precio_costo;
        private float total;
        private int baja;
        

        public Detalle_comanda(int id_detalle_comanda, int id_comanda, int id_producto, string nombre, 
                              float cantidad, float precio_venta, float precio_costo, float total, int baja)
        {
            Id_detalle_comanda = id_detalle_comanda;
            Id_comanda = id_comanda;
            Id_producto = id_producto;
            Nombre_producto = nombre;
            Cantidad = cantidad;
            Precio_costo = precio_costo;
            Precio_venta = precio_venta;
            Total = total;           
            Baja = baja;
        }

        public int Id_detalle_comanda
        {
            get { return id_detalle_comanda; }
            set { id_detalle_comanda = value; }
        }

        public int Id_comanda
        {
            get { return id_comanda; }
            set { id_comanda = value; }
        }

        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        public string Nombre_producto
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
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

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Baja
        {
            get { return baja; }
            set { baja = value; }
        }




        public bool guardarDetalle()
        {
            return Detalle_Comanda_datos.guardarDetalle(id_comanda, Id_producto, Nombre_producto, Cantidad, Precio_venta, Precio_costo, Total, Baja);
        }

        public static bool detalleRepetido(int id_producto, int id_comanda)
        {
            return Detalle_Comanda_datos.detalleRepetido(id_comanda, id_producto);          
        }


        public static bool verificarComandaAbierta(int mesa, int estado, DateTime desde, DateTime hasta)
        {
            return Detalle_Comanda_datos.verificarComandaAbierta(mesa, estado, desde, hasta);
        }

        public static bool eliminarDetalle(int id_detalle)
        {
            return Detalle_Comanda_datos.eliminarDetalle(id_detalle);
        }


        public static bool actualizarCantidad(int id_producto, int id_comanda, int cantidad)
        {
            return Detalle_Comanda_datos.actualizarCantidad(id_comanda, id_producto, cantidad);
        }


































































































































    }
}
