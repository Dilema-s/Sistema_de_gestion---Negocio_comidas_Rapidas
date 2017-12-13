using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Mozo
    {
        Int32 id_mozo;
        private string nombre;
        private string apellido;
        private string calle;
        private int nro;
        private string dni;
        private string telefono;
        private Int16 activo;

        private string mensaje;
        private bool error;

        public Mozo()
        {

        }

        public Mozo(Int32 id_mozo)
        {
            string[] mozo = new string[8];

            if (Mozo_datos.GetMozo(id_mozo, ref mozo))
            {
                try
                {
                    this.id_mozo = Convert.ToInt32(mozo[0]);
                    nombre = mozo[1];
                    apellido = mozo[2];
                    calle = mozo[3];
                    nro = Convert.ToInt32(mozo[4]);
                    dni = mozo[5];
                    telefono = mozo[6];
                    activo = Convert.ToInt16(mozo[7]);

                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                error = true;
                mensaje = "No se puede incializar el mozo seleccionado";
            }

        }

        public static DataTable getAll()
        {
            return Mozo_datos.getAll();
        }

        public static bool Eliminar(int id)
        {
            return Mozo_datos.Eliminar(id);
        }

        public Mozo(string dni, string nombre, string apellido, string calle, int nro, string telefono)
        {
            if (validar(dni, nombre, apellido, calle, nro))
            {
                this.dni = dni;
                this.nombre = nombre;
                this.apellido = apellido;
                this.calle = calle;
                this.nro = nro;
                this.telefono = telefono;
                activo = 1;
            }
            else
            {
                Error = true;
            }

        }

        public Mozo(Int32 id, string dni, string nombre, string apellido, string calle, int nro, string telefono)
        {
            if (validar(dni, nombre, apellido, calle, nro))
            {
                this.id_mozo = id;
                this.dni = dni;
                this.nombre = nombre;
                this.apellido = apellido;
                this.calle = calle;
                this.nro = nro;
                this.telefono = telefono;
                activo = 1;
            }
            else
            {
                Error = true;
            }

        }

        public void Save()
        {
            if (Mozo_datos.Guardar(dni, nombre, apellido, calle, nro, telefono, activo))
            {
                this.Error = false;
                this.Mensaje = "Mozo guardado correctamente";
            }
            else
            {
                this.Error = true;
                this.Mensaje = "Error al guardar mozo";
            }
        }

        public void Actualizar()
        {
            if(Mozo_datos.Actualizar(id_mozo, dni, nombre, apellido, calle, nro, telefono, activo))
            {
                this.Error = false;
                this.Mensaje = "Mozo guardado correctamente";
            }
            else
            {
                this.Error = true;
                this.Mensaje = "Error al guardar mozo";
            }
        }

        private bool validar(string dni, string nombre, string apellido, string calle, int nro)
        {
            string mensajeError = "";
            // validar dni
            // mensajeError += ValidarDni(dni);
            // validar nombre
            // validar apellido
            // validar calle
            // validar nro

            this.Mensaje = mensajeError;

            if (mensajeError.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }



        public bool Error
        {
            get { return error; }
            set { error = value; }
        }

        public Int32 Id_mozo
        {
            get { return id_mozo; }
            set { id_mozo = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public int Nro
        {
            get { return nro; }
            set { nro = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
    }
}

