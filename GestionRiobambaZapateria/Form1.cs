using GestionRiobambaZapateria;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using VentasZapatos;

namespace GestionRiobambaZapateria
{

    public partial class Form1 : Form
    {
        // Instancia de ListZapatos para manejar la lista de ventas
        private ListZapatos listZapatos = new ListZapatos();

        public Form1()
        {
            InitializeComponent();

            // Llenar el ComboBox con los días de la semana
            comboBoxDias.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            comboBoxDias.SelectedIndex = 0; // Seleccionar el primer día por defecto
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que hay un elemento seleccionado en el ComboBox
            if (comboBoxDias.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un día de la semana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores ingresados
            string dia = comboBoxDias.SelectedItem.ToString();
            int adidas = string.IsNullOrEmpty(mtbAdidas.Text) ? 0 : int.Parse(mtbAdidas.Text);
            int nike = string.IsNullOrEmpty(mtbNike.Text) ? 0 : int.Parse(mtbNike.Text);
            int puma = string.IsNullOrEmpty(mtbPuma.Text) ? 0 : int.Parse(mtbPuma.Text);
            decimal precioAdidas = string.IsNullOrEmpty(mtbPrecioAdidas.Text) ? 0 : decimal.Parse(mtbPrecioAdidas.Text);
            decimal precioNike = string.IsNullOrEmpty(mtbPrecioNike.Text) ? 0 : decimal.Parse(mtbPrecioNike.Text);
            decimal precioPuma = string.IsNullOrEmpty(mtbPrecioPuma.Text) ? 0 : decimal.Parse(mtbPrecioPuma.Text);

            // Crear un objeto VentaDia con los datos ingresados
            VentaDia venta = new VentaDia(dia, adidas, nike, puma, precioAdidas, precioNike, precioPuma);

            // Agregar la venta a la lista
            listZapatos.AgregarVenta(venta);

            // Limpiar los campos para el próximo ingreso
            LimpiarCampos();

            // Mostrar mensaje de confirmación
            MessageBox.Show("Datos guardados satisfactoriamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los MaskedTextBox
            mtbNike.Clear();
            mtbAdidas.Clear();
            mtbPuma.Clear();
            mtbPrecioNike.Clear();
            mtbPrecioAdidas.Clear();
            mtbPrecioPuma.Clear();
        }



        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Abrir el segundo formulario y pasar la instancia de ListZapatos
            Form2 form2 = new Form2(listZapatos);
            form2.Show();
            this.Hide(); // Ocultar el formulario actua
        }

       
    }
}