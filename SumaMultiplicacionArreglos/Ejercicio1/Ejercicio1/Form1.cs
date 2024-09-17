using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            //Utilizo la clase Random para crear un generador de numeros aleatorios
            Random rand = new Random();

            //Se crea un arreglo para llevar la cuenta de las sumas, del 2 a 12
            int[] sumas = new int[13]; 

            //Se simula el lanzamiento de los dos dados 36,000 veces
            for (int i = 0; i < 36000; i++)
            {
                //Se tiran los dados
                int dado1 = rand.Next(1, 7); //Numero aleatorio entre el rango 1-6
                int dado2 = rand.Next(1, 7);

                //Calcular la suma de ambos dados
                int suma = dado1 + dado2;

                //Incrementar el contador de la suma correstpondiente
                sumas[suma]++;
            }

            tbResultados.Clear();

            //Se imprimen los resultados en formato tabular
            tbResultados.AppendText("Suma\t Frecuecia\n"); //El "\t" en un tap
            for (int i = 0; i <= 12; i++) 
            {
                tbResultados.AppendText($"{i}\t{sumas[i]}\n");
            }

            //Se analiza si los resultados son razonables o no, cuantas veces salio el no7
            double porcentajeSiete = (double)sumas[7] / 36000 * 100;

            tbResultados.AppendText($"\nEl no.7 aparecio aproximadamente {porcentajeSiete:F2}% de veces.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbResultados_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
