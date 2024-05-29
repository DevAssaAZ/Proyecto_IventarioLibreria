using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.Entrada
{
    public static class EventoSeleccionComboBox
    {
        //Metodo de evento de seleccion de SelectedIndexChanged del cbLibros
        public static void SelectedIndexChanged(object sender, EventArgs e, TextBox txtNombreLibro, ref string nombrelibro, ref int idLibro)
        {
            // Obtener el ComboBox que lanzó el evento
            ComboBox comboBox = (ComboBox)sender;

            // Asegurarse de que hay un elemento seleccionado
            if (comboBox.SelectedItem != null)
            {
                // Obtener el DataRowView del elemento seleccionado
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;

                // Mostrar el título del libro en el TextBox (asumiendo que hay una columna 'TITULO')
                txtNombreLibro.Text = selectedRow["TITULO"].ToString();
                nombrelibro = selectedRow["TITULO"].ToString();

                // Obtener la ID del libro 
                idLibro = Convert.ToInt32(selectedRow["ID"]);
            }
        }
    }
}
