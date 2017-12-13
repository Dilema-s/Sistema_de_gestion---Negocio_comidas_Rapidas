using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;

namespace CapaNegocios
{
    class ExcelManagement
    {
        private static ExcelManagement excelManagement;

        private static ExcelPackage excelPackage;

        /// <summary>
        /// Determina si estan las intancias necesarias para el funcionamiento de los metodos
        /// </summary>
        /// <returns></returns>
        private Boolean ExistAllInstances()
        {
            return (excelManagement != null) && (excelPackage != null);
        }

        /// <summary>
        /// Obtiene una instancia del manejador de Excel
        /// </summary>
        /// <returns></returns>
        public static ExcelManagement GetInstance()
        {
            if (excelManagement == null)
            {
                excelManagement = new ExcelManagement();
            }
            return excelManagement;
        }

        /// <summary>
        /// Obtiene una una obja determinada de no encontrarla la crea. Esta hoja permite el acceso a EPPlus
        /// </summary>
        /// <param name="workSheets"></param>
        /// <returns></returns>
        public ExcelWorksheet ExcelWorksheet(string workSheets)
        {
            if (excelPackage == null) return null;
            var worksheet = excelPackage.Workbook.Worksheets[workSheets];
            if (worksheet == null)
            {
                worksheet = excelPackage.Workbook.Worksheets.Add(workSheets);
            }
            return worksheet;
        }

        /// <summary>
        /// Abre un xlsx como plantilla
        /// </summary>
        /// <param name="Path">Ruta completa donde de donde se obtiene la plantilla</param>
        /// <returns></returns>
        public Boolean Open(string Path)
        {
            if (excelManagement == null) return false;
            FileInfo file = new FileInfo(Path);
            if (file.Exists)
            {
                try
                {
                    excelPackage = new ExcelPackage(file);
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            throw new IOException(String.Format("Plantilla no encotnrada en {0}", Path));
        }

        /// <summary>
        /// Guarda como un nuevo archivo el excel resultante
        /// </summary>
        /// <param name="Path">Ruta donde se almacenará el excel</param>
        /// <returns></returns>
        public Boolean SaveAsNew(string Path)
        {
            if (!ExistAllInstances()) return false;
            try
            {
                excelPackage.SaveAs(new FileInfo(Path));
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Escrive una lista de objetos en la hoja seleccionada
        /// </summary>
        /// <param name="workSheets">Nombre de la hoja en la que se quiere guardar, si no la encuentra la crea</param>
        /// <param name="row">Fila desde donde se quiere comenzar a guardar los datos</param>
        /// <param name="column">Columna desde donde se quieren empezar a guardar los datos (Se incrementa por cada propiedad de los objetos de la lista)</param>
        /// <param name="listObject">Lista de objetos que se quieren escribir</param>
        /// <returns></returns>
        public Boolean WriteMultipleRows(string workSheets, int row, int column, IEnumerable<dynamic> listObject)
        {
            if (!ExistAllInstances()) return false;
            ExcelWorksheet worksheet = ExcelWorksheet(workSheets);
            int c;

            foreach (var item in listObject)
            {
                c = 0;
                foreach (var item1 in item.GetType().GetProperties())
                {
                    worksheet.Cells[row, column + c++].Value = item1.GetValue(item);
                }
                row++;
            }
            return true;
        }

        /// <summary>
        /// Escribe en una celda en particular
        /// </summary>
        /// <param name="workSheets">Nombre de la hoja con la que se quiere trabajar</param>
        /// <param name="row">Fila que se quiere escribir</param>
        /// <param name="column">Columna que se quiere escribir</param>
        /// <param name="object">Dato que se quiere escribir</param>
        /// <returns></returns>
        public Boolean WriteCell(string workSheets, int row, int column, dynamic @object)
        {
            if (!ExistAllInstances()) return false;
            ExcelWorksheet worksheet = ExcelWorksheet(workSheets);
            worksheet.Cells[row, column].Value = @object.ToString();
            return true;
        }
    }
}
