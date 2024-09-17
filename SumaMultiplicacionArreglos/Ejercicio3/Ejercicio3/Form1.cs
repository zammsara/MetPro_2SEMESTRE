using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {

        // Numero de vendedores (4) y productos (5)
        const int numVendedores = 4; //Columnas
        const int numProductos = 5; //Filas

        // Matriz bidimencional de ventas
        decimal[,] sales = new decimal[numProductos, numVendedores];
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dataGridView1.ColumnCount = numVendedores + 2; // +1 para el nombre de los prodductos y +1 para el total de los productos
            dataGridView1.Columns[0].Name = "Producto";
            for (int i = 1; i <= numVendedores; i++)
            {
                dataGridView1.Columns[i].Name = "Vendedor " + i;
            }
            dataGridView1.Columns[numVendedores + 1].Name = "Total Producto";
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProcesarVentas_Click(object sender, EventArgs e)
        {
            // Datos de ejemplo. Cada línea representa un volante con:
            // [vendedor, producto, total de ventas en dolares]
            var ventasDelMes = new (int vendedor, int producto, decimal valor)[]
            {
                (1, 1, 100m), (2, 1, 200m), (3, 1, 150m), (4, 1, 80m),  //La m al final del valor de
                (1, 2, 90m),  (2, 2, 130m), (3, 2, 110m), (4, 2, 120m), //total de ventas en dolares,
                (1, 3, 300m), (2, 3, 180m), (3, 3, 200m), (4, 3, 210m), //indica que el numero es decimal
                (1, 4, 250m), (2, 4, 160m), (3, 4, 270m), (4, 4, 220m), //se usa para asegurar la precision
                (1, 5, 100m), (2, 5, 90m),  (3, 5, 110m), (4, 5, 130m)  //en la operacion financiera
            };

            // Limpiar matriz antes de procesar
            Array.Clear(sales, 0, sales.Length);

            // Procesar cada volante
            foreach (var venta in ventasDelMes)
            {
                int vendedorIdx = venta.vendedor - 1;
                int productoIdx = venta.producto - 1;
                sales[productoIdx, vendedorIdx] += venta.valor;
            }

            // Mostrar la tabla en el DataGridView
            MostrarVentas();
        }
        
        //Metodo para mostrar los datos de las ventas en la DataGridView
        private void MostrarVentas()
        {
            dataGridView1.Rows.Clear();

            // Calcular totales por producto y vendedor
            decimal[] totalPorProducto = new decimal[numProductos];
            decimal[] totalPorVendedor = new decimal[numVendedores];

            // Llenar el DataGridView con las ventas y calcular totales
            for (int i = 0; i < numProductos; i++)
            {
                decimal totalProducto = 0;
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = "Producto " + (i + 1);

                //Rellenar las celdas con las ventas de cada vendedor
                for (int j = 0; j < numVendedores; j++)
                {
                    decimal venta = sales[i, j];
                    row.Cells[j + 1].Value = venta;
                    totalProducto += venta; //Acumular el total del producto
                    totalPorVendedor[j] += venta; //Acumular el total del vendedor
                }

                totalPorProducto[i] = totalProducto;
                row.Cells[numVendedores + 1].Value = totalProducto; //ptal del producto
                dataGridView1.Rows.Add(row);
            }

           

            //Fila para mostrar los totales por vendedor
           var totalRow = new DataGridViewRow();
            totalRow.CreateCells(dataGridView1);
            totalRow.Cells[0].Value = "Total Vendedor";

            decimal granTotal = 0;
            for (int j = 0; j < numVendedores; j++)
            {
                totalRow.Cells[j + 1].Value = totalPorVendedor[j]; // Total por vendedor
                granTotal += totalPorVendedor[j]; // Sumar el gran total
            }

            totalRow.Cells[numVendedores + 1].Value = granTotal; // Gran total final
            dataGridView1.Rows.Add(totalRow);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

