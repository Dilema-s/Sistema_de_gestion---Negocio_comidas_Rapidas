using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class Proveedor
    {
        public int Id_proveedor { get; set; }
        public string Nombre_proveedor { get; set; }
        public Int16 Baja { get; set; }

        public List<string> Mensajes { get; set; }
        public bool Error { get; set; }

        public Proveedor()
        {

        }

        public Proveedor(Int32 id_proveedor)
        {
            string[] proveedor = new string[3];

            if (Proveedor_datos.GeProveedor(id_proveedor, ref proveedor))
            {
                try
                {
                    Id_proveedor = Convert.ToInt32(proveedor[0]);
                    Nombre_proveedor = proveedor[1];
                    Baja = Convert.ToInt16(proveedor[2]);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                Error = true;
                Mensajes.Add("No se puede incializar el usuario seleccionado");
            }
        }

        public int Save()
        {
            int id = Proveedor_datos.Guardar(Nombre_proveedor, Baja);
            if (id == 0)
            {
                this.Error = true;
                this.Mensajes.Add("Error al guardar proveedor");
                return 0;
            }
            else
            {
                this.Error = false;
                this.Mensajes.Add("Usuario proveedor correctamente");
                return id;
            }
        }

        public static DataTable cargarCombo()
        {
            return Proveedor_datos.cargarCombo();
        }
    }
}
