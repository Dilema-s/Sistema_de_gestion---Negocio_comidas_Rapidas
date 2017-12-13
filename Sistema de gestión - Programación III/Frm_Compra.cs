using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_Compra : Form
    {
        public Frm_Compra()
        {
            InitializeComponent();
            cbProveedor.DataSource = Proveedor.cargarCombo();
            cbProveedor.ValueMember = "id_proveedor";
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.SelectedIndex = 1;
            DataTable dt = Producto.cargarComboSimple();
            id_producto.ValueMember = "id_producto";
            id_producto.DisplayMember = "id_producto";
            id_producto.DataSource = dt;
            id_producto.DataPropertyName = "id_producto";
        }

        private void Frm_Compra_Load_1(object sender, EventArgs e)
        {
        }

        private void dgvCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(dgvCompra.CurrentRow.Cells[2].Value);
                double cantidad = Convert.ToDouble(dgvCompra.CurrentRow.Cells[3].Value);
                double total = precio * cantidad;
                dgvCompra.CurrentRow.Cells[4].Value = total;
            }
            catch (Exception)
            {

                //throw;
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            int nro_comp = 0;
            try
            {
                nro_comp = Convert.ToInt32(tbNumeroComp.Text);
            }
            catch (Exception)
            {
                Funciones.mError(this, "Número de comprobante incorrecto");
            }
            int id_proveedor = cbProveedor.SelectedIndex;

            Validaciones.MensajesError.Clear();

            if (!Validaciones.ValidarComprobante(nro_comp, fecha, id_proveedor))
            {
                Compra compra = new Compra(nro_comp, fecha, id_proveedor);

                if (compra.Error)
                {
                    foreach (string msj in compra.Mensajes)
                    {
                        Funciones.mError(this, msj);
                    }

                }
                else
                {
                    int id_comprobante = 0;
                    try
                    {
                        id_comprobante = compra.Guardar();
                    }
                    catch (Exception ew)
                    {
                        Funciones.mError(this, "Error al guardar comprobante: " + ew.Message);
                    }

                    IList<Detalle_compra> listaDetalle = new List<Detalle_compra>();

                    // Validación de cada detalle de comprobante
                    Validaciones.MensajesError.Clear();
                    for (int i = 0; i < dgvCompra.Rows.Count - 1; i++)
                    {
                        if (!Validaciones.ValidarDetalleComprobante(Convert.ToInt32(dgvCompra.Rows[i].Cells[0].Value), Convert.ToDouble(dgvCompra.Rows[i].Cells[2].Value), Convert.ToInt32(dgvCompra.Rows[i].Cells[3].Value)))
                        {

                        }
                        else
                        {
                            foreach (string msj in Validaciones.MensajesError)
                            {
                                Funciones.mError(this, msj);
                            }
                            return;
                        }

                    }

                    for (int i = 0; i < dgvCompra.Rows.Count - 1; i++)
                    {
                        listaDetalle.Add(new Detalle_compra(new Producto_simple(Convert.ToInt32(dgvCompra.Rows[i].Cells[0].Value)), Convert.ToDouble(dgvCompra.Rows[i].Cells[2].Value), Convert.ToInt32(dgvCompra.Rows[i].Cells[3].Value), id_comprobante));
                    }

                    foreach (Detalle_compra dc in listaDetalle)
                    {
                        try
                        {
                            dc.Guardar();
                            if (dc.Producto.ActualizarStock(dc.Cantidad))
                            {

                            }
                            else
                            {
                                Funciones.mError(this, "Error al actualizar stock del producto: " + dc.Producto.Descripcion);
                            }
                            if (dc.Producto.ActualizarCosto((float)dc.Precio))
                            {

                            }
                            else
                            {
                                Funciones.mError(this, "Error al actualizar el precio del producto: " + dc.Producto.Descripcion);
                            }
                        }
                        catch (Exception)
                        {
                            compra.Eliminar(id_comprobante);
                        }
                    }

                    Funciones.mError(this, "Registro exitoso");
                    tbNumeroComp.Text = "";
                    dgvCompra.Rows.Clear();
                }
            }
            else
            {
                foreach (string msj in Validaciones.MensajesError)
                {
                    Funciones.mError(this, msj);
                }
            }




        }

        private void dgvCompra_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCompra.CurrentCell.ColumnIndex == 0)
            {
                dgvCompra.CurrentRow.Cells[1].Value = Producto.getDescripcionProducto(Convert.ToInt32(dgvCompra.CurrentCell.EditedFormattedValue));
            }
        }

        

        private void dgvCompra_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dgvCompra.Rows[e.RowIndex].ErrorText = "";

            double newInteger;

            string headerText = dgvCompra.Columns[e.ColumnIndex].HeaderText;

            if (!headerText.Equals("Precio") && !headerText.Equals("Cantidad")) return;

            if (dgvCompra.Rows[e.RowIndex].IsNewRow) { return; }
            if (!double.TryParse(e.FormattedValue.ToString(),
                out newInteger) || newInteger < 0)
            {
                e.Cancel = true;
                dgvCompra.Rows[e.RowIndex].ErrorText = "Los valores de precio y cantidad deben ser numéricos";
            }


        }

        private void tbNumeroComp_Validating(object sender, CancelEventArgs e)
        {

            //double newInteger;

            //if (!double.TryParse(e.ToString(),
            //    out newInteger) || newInteger < 0)
            //{
            //    e.Cancel = true;
            //    Funciones.mError(this, "Los valores de precio y cantidad deben ser numéricos");
            //}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
