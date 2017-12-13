using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Produto_compuesto : Producto
    {
        private LinkedList<Receta> listaRecetas;

        public Produto_compuesto()
        {

        }

        public Produto_compuesto(int id, string nombre, string descripcion, int categoria, float precio_venta, float precio_costo, bool a_la_venta)
            : base(id, nombre, descripcion, categoria, precio_venta, precio_costo, a_la_venta)
        {
            listaRecetas = new LinkedList<Receta>();
        }

     

        public LinkedList<Receta> ListaRecetas 
        {
            get { return listaRecetas; }
            set { listaRecetas = value; }
        }

        public bool GuardarProducto_compuesto()
        {
            int venta = 0;
            if (A_la_venta) //se transforma el valor bool en int para ingresarlo a la BD 
            {
                venta = 1;
            }
            return Producto_datos.guardar_Producto_Compuesto(Id_producto,Nombre,Descripcion,Categoria,Precio_venta,Precio_costo,venta);
        }


        public bool updateProductoCompuesto()
        {
            int venta = 0;
            if (A_la_venta) //se transforma el valor bool en int para ingresarlo a la BD 
            {
                venta = 1;
            }
            return Producto_datos.updateProductoCompuesto(Id_producto, Nombre, Descripcion, Categoria, Precio_venta, Precio_costo, venta);
        }


        public static DataTable getCompuestos()
        {
            return Producto_datos.getCompuestos();
        }




































    }
}
