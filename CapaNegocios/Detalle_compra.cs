using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Detalle_compra
    {
        public int Id_detalle { get; set; }
        public Producto_simple Producto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int Id_comprobante { get; set; }

        public bool Error { get; set; }
        public List<string> Mensajes = new List<string>();

        public Detalle_compra() { }

        public Detalle_compra(Producto_simple id_producto, double precio, int cantidad, int id_comprobante)
        {
            Producto = id_producto;
            Precio = precio;
            Cantidad = cantidad;
            Id_comprobante = id_comprobante;
        }
        public Detalle_compra(int id_detalle, Producto_simple producto, double precio, int cantidad, int id_comprobante)
        {
            Id_detalle = id_detalle;
            Producto = producto;
            Precio = precio;
            Cantidad = cantidad;
            Id_comprobante = id_comprobante;
        }

        //public Detalle_compra(Int32 numero_comprobante)
        //{
        //    string[] detalle = new string[5];

        //    if (Detalle_compra_datos.GetDetalle(numero_comprobante, ref detalle))
        //    {
        //        try
        //        {
        //            Id_detalle = Convert.ToInt32(detalle[0]);
        //            Id_producto = Convert.ToInt32(detalle[1]);
        //            Precio = Convert.ToDouble(detalle[2]);
        //            Cantidad = Convert.ToDouble(detalle[3]);
        //            Id_comprobante = Convert.ToInt32(detalle[4]);

        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }

        //    }
        //    else
        //    {
        //        Error = true;
        //        Mensajes.Add("No se puede inicializar el detalle seleccionado");
        //    }

        //}

        public IList<Detalle_compra> ListaDetalles(int numero_comprobante)
        {
            IList<Detalle_compra> lista = new List<Detalle_compra>();

            IList<string[]> listaStr = new List<string[]>();

            if (Detalle_compra_datos.GetDetalles(numero_comprobante, ref listaStr))
            {
                foreach (string[] lStr in listaStr)
                {
                    try
                    {
                        lista.Add(new Detalle_compra(
                            Id_detalle = Convert.ToInt32(lStr[0]),
                            Producto = new Producto_simple(Convert.ToInt32(lStr[1])),
                            Precio = Convert.ToDouble(lStr[2]),
                            Cantidad = Convert.ToInt32(lStr[3]),
                            Id_comprobante = Convert.ToInt32(lStr[4])
                        ));
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }


            }
            else
            {
                Error = true;
                Mensajes.Add("No se puede inicializar el detalle seleccionado");
            }
            return lista;
        }

        public void Guardar()
        {
            if (Detalle_compra_datos.Guardar(Producto.Id_producto, Precio, Cantidad, Id_comprobante))
            {
                Error = false;
                Mensajes.Add("detalle guardado correctamente");
            }
            else
            {
                Error = true;
                Mensajes.Add("Error al guardar detalle");
            }
        }
    }
}
