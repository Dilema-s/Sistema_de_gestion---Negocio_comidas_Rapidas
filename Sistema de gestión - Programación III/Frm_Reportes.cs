using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan dif = dtpHastaVentasMozo.Value - dtpDesdeVentasMozo.Value;
            if (dif.Days < 0)
            {
                Funciones.mError(this, "Fechas ingresadas incorrectas");
            }
            else
            {
                Persona.ImprimirVentasPorMozo(dtpDesdeVentasMozo.Value, dtpHastaVentasMozo.Value);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimeSpan dif = dtpHastaMP.Value - dtpDesdeMP.Value;
            if (dif.Days < 0)
            {
                Funciones.mError(this, "Fechas ingresadas incorrectas");
            }
            else
            {
                Producto.ImprimirMateriaPrimaUtilizada(dtpDesdeMP.Value, dtpHastaMP.Value);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Producto.ImprimirPreciosPorCategoria();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TimeSpan dif = dtpHastaVentasDia.Value - dtpDesdeVentasDia.Value;
            if (dif.Days < 0)
            {
                Funciones.mError(this, "Fechas ingresadas incorrectas");
            }
            else
            {
                Comanda.ImprimirVentasDiarias(dtpDesdeVentasDia.Value, dtpHastaVentasDia.Value);
            }
        }
    }
}
