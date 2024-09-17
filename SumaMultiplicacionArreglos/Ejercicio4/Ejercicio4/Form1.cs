using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        // Arreglo para contar el numero de vendedores en cada rango
        private int[] rangoSalarios = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // se limpia el ListBox antes de mostrar los resultados
            listBoxResults.Items.Clear();

            // Lee el texto del TextBox y lo divide en lineas
            string[] infoVentas = tbInfoVentas.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Reinicia el conteo
            Array.Clear( rangoSalarios, 0, rangoSalarios.Length);

            foreach (string venta in infoVentas)
            {
                if (double.TryParse(venta, out double salesAmount))
                {
                    // Calcula el salario
                    double commission = 0.09 * salesAmount;
                    int totalSalary = (int)(200 + commission);

                    // Determina el rango de salario
                    if (totalSalary >= 200 && totalSalary <= 299)
                        rangoSalarios[0]++;
                    else if (totalSalary >= 300 && totalSalary <= 399)
                        rangoSalarios[1]++;
                    else if (totalSalary >= 400 && totalSalary <= 499)
                        rangoSalarios[2]++;
                    else if (totalSalary >= 500 && totalSalary <= 599)
                        rangoSalarios[3]++;
                    else if (totalSalary >= 600 && totalSalary <= 699)
                        rangoSalarios[4]++;
                    else if (totalSalary >= 700 && totalSalary <= 799)
                        rangoSalarios[5]++;
                    else if (totalSalary >= 800 && totalSalary <= 899)
                        rangoSalarios[6]++;
                    else if (totalSalary >= 900 && totalSalary <= 999)
                        rangoSalarios[7]++;
                    else if (totalSalary >= 1000)
                        rangoSalarios[8]++;
                }
                else
                {
                    MessageBox.Show($"La venta '{venta}' no es un numero valido.", "Error", MessageBoxButtons.OK);
                }
            }

            // Muestra los resultados en el ListBox
            listBoxResults.Items.Add("Rango de salario: Cantidad de vendedores");
            listBoxResults.Items.Add("$200-$299: " + rangoSalarios[0]);
            listBoxResults.Items.Add("$300-$399: " + rangoSalarios[1]);
            listBoxResults.Items.Add("$400-$499: " + rangoSalarios[2]);
            listBoxResults.Items.Add("$500-$599: " + rangoSalarios[3]);
            listBoxResults.Items.Add("$600-$699: " + rangoSalarios[4]);
            listBoxResults.Items.Add("$700-$799: " + rangoSalarios[5]);
            listBoxResults.Items.Add("$800-$899: " + rangoSalarios[6]);
            listBoxResults.Items.Add("$900-$999: " + rangoSalarios[7]);
            listBoxResults.Items.Add("$1000 o superior: " + rangoSalarios[8]);
        }

                //tbInfoVentas
    private void txtSalesData_TextChanged(object sender, EventArgs e)
        {
            //InfoVentas
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

