using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Acceso
    {


        public Int32 Id { get; set; }
        public Int32 Id_persona { get; set; }
        public string Nombre_usuario { get; set; }
        public string Password { get; set; }
        public Int16 Baja { get; set; }

        public List<string> Mensajes { get; set; }
        public bool Error { get; set; }

        public Acceso(Int32 id_persona, string nombre_usuario, string password)
        {
            Mensajes = new List<string>();
            if (!Validaciones.ValidarAcceso(id_persona, nombre_usuario, password))
            {
                Id_persona = id_persona;
                Nombre_usuario = nombre_usuario;
                Password = password;
                Baja = 0;
                Error = false;
                Mensajes.Add("Registro exitoso!");
            }
            else
            {
                Error = true;
                foreach (string msj in Validaciones.MensajesError)
                {
                    Mensajes.Add(msj);
                }
            }
        }

        public Acceso(Int32 id_persona)
        {
            string[] acceso = new string[5];

            if (Acceso_datos.GetAcceso(id_persona, ref acceso))
            {
                try
                {
                    Id = Convert.ToInt32(acceso[0]);
                    Id_persona = Convert.ToInt32(acceso[1]);
                    Nombre_usuario = acceso[2];
                    Password = acceso[3];
                    Baja = Convert.ToInt16(acceso[4]);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                Error = true;
                Mensajes.Add("No se puede incializar el acceso seleccionado");
            }
        }

        public Acceso()
        {

        }

        public void Save()
        {
            if (Acceso_datos.Guardar(Id_persona, Nombre_usuario, Password, Baja))
            {
                this.Error = false;
                this.Mensajes.Add("Acceo guardado correctamente");
            }
            else
            {
                this.Error = true;
                this.Mensajes.Add("Error al guardar acceso");
            }
        }

        public bool ValidarAcceso(string usuario, string pass)
        {
            if (Acceso_datos.GetAcceso(usuario, pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarAcceso(string usuario, string pass)
        {
            return Acceso_datos.ActualizarPass(usuario, pass);
        }



































    }
}
