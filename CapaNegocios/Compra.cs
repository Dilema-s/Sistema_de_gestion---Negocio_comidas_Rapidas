using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Compra
    {
        public int Id_comprobante { get; set; }
        public int Numero_comprobante { get; set; }
        public DateTime Fecha_comprobante { get; set; }
        public int Id_proveedor { get; set; }

        public bool Error { get; set; }
        public List<string> Mensajes = new List<string>();

        public Compra() { }

        public Compra(int numero_comprobante, DateTime fecha_comprobante, int id_proveedor)
        {
            Numero_comprobante = numero_comprobante;
            Fecha_comprobante = fecha_comprobante;
            Id_proveedor = id_proveedor;
        }

        public Compra(Int32 numero_comprobante)
        {
            string[] compra = new string[4];

            if (Compra_datos.GetCompra(numero_comprobante, ref compra))
            {
                try
                {
                    Id_comprobante = Convert.ToInt32(compra[0]);
                    Numero_comprobante = Convert.ToInt32(compra[1]);
                    Fecha_comprobante = Convert.ToDateTime(compra[2]);
                    Id_proveedor = Convert.ToInt32(compra[3]);

                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                Error = true;
                Mensajes.Add("No se puede inicializar el comprobante seleccionado");
            }

        }

        public int Guardar()
        {
            int id = Compra_datos.Guardar(Numero_comprobante, Fecha_comprobante, Id_proveedor);
            if (id == 0)
            {
                Error = true;
                Mensajes.Add("Error al guardar usuario");
                return 0;
            }
            else
            {
                Error = false;
                Mensajes.Add("Usuario guardado correctamente");
                return id;
            }
        }

        public bool Eliminar(int id_compra)
        {
            return Compra_datos.Eliminar(id_compra);
        }


    }
}
