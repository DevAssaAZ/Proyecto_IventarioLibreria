using Negocio.Ventas_cn.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.RegistroVentas.Facturacion
{
    public static class AccionesDelDataGridViewFacturacion
    {
        

        public static void Acciones(DataGridView dgvFacturacion, DataGridViewCellEventArgs e)
        {
            MetodosFacturacion obj_factura = new MetodosFacturacion();
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que tanto la fila como la columna sean válidas
                {
                    DataGridViewRow row = dgvFacturacion.Rows[e.RowIndex];
                    if (row != null && row.Cells.Count > 0) // Verifica que la fila y las celdas no estén vacías
                    {
                        if (dgvFacturacion.Columns[e.ColumnIndex].Name == "ELIMINAR")
                        {
                            if (e.RowIndex >= 0)
                            {
                                string idFactura = row.Cells["ID"].Value.ToString();
                                obj_factura.Id = Convert.ToInt32(idFactura);
                                if (MessageBox.Show("¿Está seguro de eliminar esta factura?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (obj_factura.EliminarFacturacion())
                                    {
                                        MessageBox.Show("Factura eliminada con éxito");
                                        DatosLoaderFacturacion.CargarDatos(dgvFacturacion);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar la factura");
                                    }
                                }
                            }
                        }
                        else if (dgvFacturacion.Columns[e.ColumnIndex].Name == "VER")
                        {
                            if (e.RowIndex >= 0)
                            {
                                
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fila seleccionada está vacía.");
                    }
                }
                else
                {
                    MessageBox.Show("La fila o la columna seleccionada no son válidas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }
    }
}
