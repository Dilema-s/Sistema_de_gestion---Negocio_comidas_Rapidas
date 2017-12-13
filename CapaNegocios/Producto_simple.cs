using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Producto_simple : Producto
    {
        private string marca;
        private int stock;
        private int  stock_minimo;

        public Producto_simple()
        {

        }

        public Producto_simple (int id, string nombre, string descripcion, int categoria, float precio_venta, float precio_costo, bool a_la_venta, string marca, int stock, int stock_minimo)
            : base(id, nombre, descripcion, categoria, precio_venta, precio_costo, a_la_venta)
        {
            Marca = marca;
            Stock = stock;
            Stock_minimo = stock_minimo;
        }

        public Producto_simple(Int32 id_producto)
        {
            string[] producto = new string[10];

            if (Producto_datos.GetProducto(id_producto, ref producto))
            {
                try
                {
                    Id_producto = Convert.ToInt32(producto[0]);
                    Nombre = producto[1];
                    Descripcion = producto[2];
                    Marca = producto[3];
                    base.Categoria = Convert.ToInt32(producto[4]);
                    Stock = Convert.ToInt32(producto[5]);
                    Stock_minimo = Convert.ToInt32(producto[6]);
                    Precio_venta = (float)Convert.ToDouble(producto[7]);
                    Precio_costo = (float)Convert.ToDouble(producto[8]);
                    A_la_venta = Convert.ToBoolean(producto[9]);

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("No se puede incializar el producto código: " + id_producto);
            }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int Stock_minimo
        {
            get { return stock_minimo; }
            set { stock_minimo = value; }
        }

        public bool guardar()
        {
            int venta = 0; 
            if (base.A_la_venta) //se transforma el valor bool en int para ingresarlo a la BD 
            {
                venta = 1;
            }

            if (Producto_datos.guardar_PrSimple(Id_producto, base.Nombre, base.Descripcion, base.Categoria, base.Precio_venta, base.Precio_costo, venta, Marca, Stock,Stock_minimo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool updateProductoSimple()
        {
            int venta = 0;
            if (base.A_la_venta) //se transforma el valor bool en int para ingresarlo a la BD 
            {
                venta = 1;
            }

            if (Producto_datos.updateProductoSimple(Id_producto, base.Nombre, base.Descripcion, base.Categoria, base.Precio_venta, base.Precio_costo, venta, Marca, Stock, Stock_minimo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ActualizarStock(int cant)
        {
            Stock += cant;
            if (Producto_datos.ActualizarStock(Id_producto, Stock))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarCosto(float costo)
        {
            Precio_costo = costo;
            if (Producto_datos.ActualizarCosto(Id_producto, Precio_costo))
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
