using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public static class Validaciones
    {
        public static List<string> MensajesError = new List<string>();
        public static bool Error;

        public static bool ValidarProducto(string nombre, string descrip, string categ, decimal stock_min)
        {
            Error = false;
            if (nombre.Length < 4)
            {
                MensajesError.Add("Nombre de producto incorrecto.");
                Error = true;
            }

            if (descrip.Length < 4)
            {
                MensajesError.Add("Descripción de producto incorrecta.");
                Error = true;
            }

            if (categ.Length < 4)
            {
                MensajesError.Add("Categoría de producto incorrecta.");
                Error = true;
            }

            if (stock_min <= 0)
            {
                MensajesError.Add("El stock mínimo debe ser superior a 0.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarPersona(string nombre, string apellido, int dni, string telefono, DateTime fecha_ingreso)
        {
            Error = false;
            if (nombre.Length < 2)
            {
                MensajesError.Add("Nombre incorrecto.");
                Error = true;
            }

            if (apellido.Length < 2)
            {
                MensajesError.Add("Apellido incorrecto.");
                Error = true;
            }

            if (dni < 5000000)
            {
                MensajesError.Add("Dni incorrecto.");
                Error = true;
            }

            if (telefono.Length < 6)
            {
                MensajesError.Add("Teléfono incorrecto.");
                Error = true;
            }

            TimeSpan ts = DateTime.Today - fecha_ingreso;

            if (ts.Days > 365 || ts.Days < 0) //Acepta fechas de ingreso como máximo de un año atrás
            {
                MensajesError.Add("Fecha de ingreso incorrecta.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarComanda(int puesto, DateTime fecha, int id_persona, int mesa, decimal total, string estado)
        {
            Error = false;
            if (puesto < 1)
            {
                MensajesError.Add("Puesto incorrecto.");
                Error = true;
            }

            TimeSpan ts = DateTime.Today - fecha;

            if (ts.Days > 1 || ts.Days < 0)//La fecha de la comanda debe ser de hoy o en casos particulares, de ayer.
            {
                MensajesError.Add("Fecha de comanda incorrecta.");
                Error = true;
            }

            if (id_persona < 0)
            {
                MensajesError.Add("Mozo incorrecto.");
                Error = true;
            }

            if (mesa < 1)
            {
                MensajesError.Add("Número de mesa incorrecta.");
                Error = true;
            }

            if (total < 0)
            {
                MensajesError.Add("Importe de comanda incorrecto.");
                Error = true;
            }

            if (estado.Length < 2)
            {
                MensajesError.Add("Estado de comanda incorrecto.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarDetalleComanda(int id_comanda, int id_producto, string nombre, decimal cantidad, decimal precio_venta, decimal precio_costo, decimal total)
        {
            Error = false;
            if (id_comanda < 0)
            {
                MensajesError.Add("Número de comanda incorrecto.");
                Error = true;
            }

            if (id_producto < 0)
            {
                MensajesError.Add("Número de producto incorrecto.");
                Error = true;
            }

            if (nombre.Length < 4)
            {
                MensajesError.Add("Producto incorrecto.");
                Error = true;
            }

            if (cantidad < 0)
            {
                MensajesError.Add("Cantidad incorrecta.");
                Error = true;
            }

            if (precio_costo < 0)
            {
                MensajesError.Add("Precio de costo incorrecto.");
                Error = true;
            }

            if (total < 0)
            {
                MensajesError.Add("Importe total incorrecto.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarComprobante(int numero_comp, DateTime fecha, int id_proveedor)
        {
            Error = false;
            if (numero_comp < 0)
            {
                MensajesError.Add("Número de comprobante incorrecto.");
                Error = true;
            }

            TimeSpan ts = DateTime.Today - fecha;

            if (ts.Days < 0)
            {
                MensajesError.Add("Fecha de comprobante incorrecta.");
                Error = true;
            }

            if (id_proveedor < 0)
            {
                MensajesError.Add("Número de proveedor incorrecto.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarDetalleComprobante(int id_producto, double precio, decimal cantidad)
        {
            Error = false;
            if (id_producto < 0)
            {
                MensajesError.Add("Número de producto incorrecto.");
                Error = true;
            }

            if (precio < 0)
            {
                MensajesError.Add("Precio incorrecto. No debe ser negativo.");
                Error = true;
            }

            if (cantidad < 0)
            {
                MensajesError.Add("Cantidad incorrecta. No debe ser un valor negativo.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarReceta(int version, string nombre, DateTime fecha)
        {
            Error = false;
            if (version < 0)
            {
                MensajesError.Add("Versión de receta incorrecta.");
                Error = true;
            }


            if (nombre.Length < 4)
            {
                MensajesError.Add("Nombre de receta incorrecto.");
                Error = true;
            }

            TimeSpan ts = DateTime.Today - fecha;

            if (ts.Days < 0 || ts.Days > 30)
            {
                MensajesError.Add("Fecha de receta incorrecta.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarDetalleReceta(int id_receta, int version, int id_producto, decimal cantidad, string unidad)
        {
            Error = false;
            if (id_receta < 0)
            {
                MensajesError.Add("Número de receta incorrecto.");
                Error = true;
            }

            if (version < 0)
            {
                MensajesError.Add("Versión incorrecta.");
                Error = true;
            }

            if (id_producto < 0)
            {
                MensajesError.Add("Número de producto incorrecto.");
                Error = true;
            }

            if (cantidad < 0)
            {
                MensajesError.Add("Cantidad incorrecta. No debe ser un valor negativo.");
                Error = true;
            }

            if (unidad.Length == 0)
            {
                MensajesError.Add("Unidad de producto incorrecto.");
                Error = true;
            }

            return Error;
        }

        public static bool ValidarAcceso(int id_persona, string nombre_usuario, string password)
        {
            Error = false;
            if (id_persona < 0)
            {
                MensajesError.Add("Número de receta incorrecto.");
                Error = true;
            }

            if (nombre_usuario.Length < 6)
            {
                MensajesError.Add("Usuario incorrecto. Debe tener una longitud mayor a 5 caractéres");
                Error = true;
            }

            if (password.Length < 6)
            {
                MensajesError.Add("Contraseña incorrecta. Debe tener una longitud mayor a 5 caractéres");
                Error = true;
            }

            return Error;
        }

        public static bool ValidadPassword(string pass1, string pass2)
        {
            if (pass1.CompareTo(pass2) == 0)
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