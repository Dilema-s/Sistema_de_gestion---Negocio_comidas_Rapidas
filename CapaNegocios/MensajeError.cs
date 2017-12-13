using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class MensajeError
    {


        LinkedList<String> listaResultados = new LinkedList<string>();
        private bool resultado;
        private bool defoult;

        public MensajeError()
        {
            setResultado(false);
            defoult = true;

        }



        public LinkedList<String> getListaResultados()
        {
            return listaResultados;
        }

        public void mensaje_error(String mensaje)
        {
            if (defoult == true)
            {
                listaResultados.Clear();
                defoult = false;
            }
            this.listaResultados.AddLast(mensaje);
        }

        public bool getResultado()
        {
            return resultado;
        }

        public void setResultado(bool resultado)
        {
            if (defoult == true)
            {
                listaResultados.Clear();
                if (resultado == true)
                {
                    listaResultados.AddLast("Operación correcta");
                }
                else
                {
                    listaResultados.AddLast("Operación con errores");
                }
            }
            this.resultado = resultado;

        }


        public String toString()
        {
            String mensaje = "";

            foreach (var value in listaResultados)
            {
                mensaje = mensaje + value;
            }

            return mensaje;
        }



    }
}
