using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace CapaNegocios
{
        public class Persona
        {
            public Int32 Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int dni { get; set; }
            public int Cargo { get; set; }
            public string Calle { get; set; }
            public string Altura { get; set; }
            public string Telefono { get; set; }
            public DateTime FechaIngreso { get; set; }
            public Int16 Baja { get; set; }

            public List<string> Mensajes { get; set; }
            public bool Error { get; set; }

            public Persona()
            {

            }
            
        public Persona(Int32 id, string nombre, string apellido, int dni, int cargo, string calle, string altura, string telefono, DateTime fechaIngreso)
        {
            Mensajes = new List<string>();

            if (!Validaciones.ValidarPersona(nombre, apellido, dni, telefono, fechaIngreso))
            {
                Id = id;
                Nombre = nombre;
                Apellido = apellido;
                this.dni = dni;
                Cargo = cargo;
                Calle = calle;
                Altura = altura;
                Telefono = telefono;
                FechaIngreso = fechaIngreso;
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

            public Persona(string nombre, string apellido, int dni, int cargo, string calle, string altura, string telefono, DateTime fechaIngreso)
            {
                Mensajes = new List<string>();

                if (!Validaciones.ValidarPersona(nombre, apellido, dni, telefono, fechaIngreso))
                {
                    Nombre = nombre;
                    Apellido = apellido;
                    this.dni = dni;
                    Cargo = cargo;
                    Calle = calle;
                    Altura = altura;
                    Telefono = telefono;
                    FechaIngreso = fechaIngreso;
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

            public Persona(Int32 id_persona)
            {
                string[] persona = new string[10];

                if (Persona_datos.GetPersona(id_persona, ref persona))
                {
                    try
                    {
                        Id = Convert.ToInt32(persona[0]);
                        Nombre = persona[1];
                        Apellido = persona[2];
                        dni = Convert.ToInt32(persona[3]);
                        Cargo = Convert.ToInt32(persona[4]);
                        Calle = persona[5];
                        Altura = persona[6];
                        Telefono = persona[7];
                        FechaIngreso = Convert.ToDateTime(persona[8]);
                        Baja = 0;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    Error = true;
                    Mensajes.Add("No se puede incializar el usuario seleccionado");
                }
            }

            public static DataTable getAll()
            {
                return Persona_datos.getAll();
            }

        public  bool getPersona(int id_persona)
        {
            string[] persona = new string[9];

            if (Persona_datos.GetPersona(id_persona, ref persona))
            {
                MessageBox.Show(persona[1], persona[2]);
                Nombre = persona[1];
                Apellido = persona[2];
            }
            return true;

        }


        public bool Eliminar(int id)
            {
                return Persona_datos.Eliminar(id);
            }

            public int Save()
            {
                int id = Persona_datos.Guardar(Nombre, Apellido, dni, Cargo, Calle, Altura, Telefono, FechaIngreso, Baja);
                if (id == 0)
                {
                    this.Error = true;
                    this.Mensajes.Add("Error al guardar usuario");
                    return 0;
                }
                else
                {
                    this.Error = false;
                    this.Mensajes.Add("Usuario guardado correctamente");
                    return id;
            }
        }

        public void Actualizar()
        {
            if (Persona_datos.Actualizar(Id, Nombre, Apellido, dni, Cargo, Calle, Altura, Telefono, FechaIngreso, Baja))
            {
                this.Error = false;
                this.Mensajes.Add("Usuario guardado correctamente");
            }
            else
            {
                this.Error = true;
                this.Mensajes.Add("Error al guardar usuario");
            }
        }



        public static DataSet getPersona2(int id_producto)
        {
            return Persona_datos.getpersona(id_producto);
        }

        public static void ImprimirVentasPorMozo(DateTime desde, DateTime hasta)
        {
            List<string[]> lista = new List<string[]>();
            lista = Persona_datos.VentasPorMozo(desde, hasta);

            string SheetsName = "Hoja1";
            ExcelManagement em = ExcelManagement.GetInstance();

            em.Open(Application.StartupPath + "\\VentasPorMozo.xlsx");

            int c = 2;

            foreach (string[] array in lista)
            {
                em.WriteCell(SheetsName, 1, 1, desde.Date);
                em.WriteCell(SheetsName, 1, 2, hasta.Date);
                em.WriteCell(SheetsName, c, 1, Convert.ToInt32(array[0]));
                em.WriteCell(SheetsName, c, 2, array[1]);
                em.WriteCell(SheetsName, c, 3, Convert.ToDouble(array[2]));
                c++;
            }

            string path = string.Concat(Application.StartupPath, "\\VentasPorMozo", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString(), ".xlsx");

            em.SaveAsNew(path);

            Process.Start(path);

        }


















    }
}
