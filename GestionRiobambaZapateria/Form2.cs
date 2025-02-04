using System;
using System.Windows.Forms;
using VentasZapatos;

namespace GestionRiobambaZapateria
{
    public partial class Form2 : Form
    {
        // Variable para almacenar la lista de ventas
        private ListZapatos listZapatos;

        // Constructor que acepta un parámetro de tipo ListZapatos
        public Form2(ListZapatos listZapatos)
        {
            InitializeComponent();
            this.listZapatos = listZapatos; // Asignar la lista recibida
            ConfigurarDataGridView(); // Configurar el DataGridView
            MostrarVentas(listZapatos.ObtenerVentas()); // Mostrar todas las ventas al abrir el formulario
        }

        private void ConfigurarDataGridView()
        {
            // Definir las columnas del DataGridView
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("Dia", "Día");
            dgvInventario.Columns.Add("Adidas", "Adidas");
            dgvInventario.Columns.Add("Nike", "Nike");
            dgvInventario.Columns.Add("Puma", "Puma");
            dgvInventario.Columns.Add("PrecioAdidas", "Precio Adidas");
            dgvInventario.Columns.Add("PrecioNike", "Precio Nike");
            dgvInventario.Columns.Add("PrecioPuma", "Precio Puma");
            dgvInventario.Columns.Add("TotalVentas", "Total Ventas");

            // Ajustar el ancho de las columnas
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void btnNike_Click(object sender, EventArgs e)
        {
            // Filtrar ventas de Nike
            MostrarVentas(listZapatos.FiltrarVentasPorMarca("nike"));
        }
        private void MostrarVentas(List<VentaDia> ventas)
        {
            // Limpiar el DataGridView
            dgvInventario.Rows.Clear();

            // Agregar las ventas filtradas al DataGridView
            foreach (var venta in ventas)
            {
                dgvInventario.Rows.Add(
                    venta.Dia,
                    venta.Nike,
                    venta.Adidas,
                    venta.Puma,
                    venta.PrecioNike.ToString("C"), // Formato de moneda
                    venta.PrecioAdidas.ToString("C"),   // Formato de moneda
                    venta.PrecioPuma.ToString("C"),   // Formato de moneda
                    venta.CalcularTotalVentas().ToString("C") // Total de ventas
                );
            }
        }

        private void btnAdidas_Click_1(object sender, EventArgs e)
        {
            MostrarVentas(listZapatos.FiltrarVentasPorMarca("adidas"));
        }

        private void btnPuma_Click_1(object sender, EventArgs e)
        {
            // Filtrar ventas de Puma
            MostrarVentas(listZapatos.FiltrarVentasPorMarca("puma"));
        }

        private void btnTodos_Click_1(object sender, EventArgs e)
        {
            MostrarVentas(listZapatos.ObtenerVentas());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Regresar al menú principal (Form1)
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }
    }
}