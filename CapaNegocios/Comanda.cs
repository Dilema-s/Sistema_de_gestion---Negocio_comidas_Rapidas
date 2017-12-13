using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Comanda
    {
        private int id_comanda;
        private int puesto;
        private DateTime fecha;
        private int id_persona;
        private int mesa;
        private float total;
        private int estado;
        private int baja;


        public Comanda(int id_comanda,int puesto, DateTime fecha, int id_mozo, int mesa, float total, int estado)
        {
            Id_Comanda = id_comanda;
            Puesto = puesto;
            Fecha = fecha;
            Id_persona = id_mozo;
            Mesa = mesa;
            Total = total;
            Estado = estado;
            Baja = 0;
        }

        public Comanda()
        {

        }


        public int Id_Comanda
        {
            get { return id_comanda; }
            set { id_comanda = value; }
        }

        public int Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }

        public int Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
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


    
        public bool insertComanda()
        {
            return Comanda_datos.insertComanda(Id_Comanda,Puesto, Fecha, Id_persona, Mesa, Total, Estado); 
        }

        public static DataSet getComanda(int id_comanda)
        {
            return Detalle_Comanda_datos.getDetalle(id_comanda);
        }

        public static int ultimo_id_comanda()
        {
            return Comanda_datos.ultimo_id_comanda();
        }

        public static DataSet getAll(DateTime fecha)
        {
            return Comanda_datos.getAll(fecha);
        }

        public static bool bajaComanda(int id_comanda)
        {
            return Comanda_datos.bajaComanda(id_comanda);
        }


        public static void ImprimirVentasDiarias(DateTime desde, DateTime hasta)
        {
            List<string[]> lista = new List<string[]>();
            lista = Comanda_datos.VentasPorDia(desde, hasta);

            string SheetsName = "Hoja1";
            ExcelManagement em = ExcelManagement.GetInstance();

            em.Open(Application.StartupPath + "\\VentasDiarias.xlsx");

            int c = 2;

            foreach (string[] array in lista)
            {
                em.WriteCell(SheetsName, 1, 1, desde.Date);
                em.WriteCell(SheetsName, 1, 2, hasta.Date);
                em.WriteCell(SheetsName, c, 1, array[0]);
                em.WriteCell(SheetsName, c, 2, Convert.ToDouble(array[1]));
                c++;
            }

            string path = string.Concat(Application.StartupPath, "\\VentasDiarias", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString(), ".xlsx");

            em.SaveAsNew(path);

            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "EXCEL.EXE";
            //startInfo.Arguments = path;
            //Process.Start(startInfo);
            System.Diagnostics.Process.Start(path);

        }


        public static int getSubtotal(int id_comanda)
        {
            return Comanda_datos.getSubtotal(id_comanda);
        }





















































































































































    }
}
