using Negocio.Libros_cn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Metodos.Stock.Entrada
{
    public static class ComboboxLibrosLleno
    {
        //Metodo para llenar el combobox de libros
        public static void LlenarComboBox(ComboBox cbLibros, EventHandler eventHandler)
        {
            try
            {
                MetodosLibros libro_N = new MetodosLibros();
                DataTable tablaLibros = libro_N.MostrarLibros();

                // Configurar el ComboBox
                cbLibros.DisplayMember = "TITULO";  // Columna que se mostrará en el ComboBox
                cbLibros.ValueMember = "ID";  // Columna que representará el valor de cada ítem (asumiendo que tienes una columna 'ID')
                cbLibros.DataSource = tablaLibros;

                // Suscribirse al evento SelectedIndexChanged
                cbLibros.SelectedIndexChanged += eventHandler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
        }

    }
}
