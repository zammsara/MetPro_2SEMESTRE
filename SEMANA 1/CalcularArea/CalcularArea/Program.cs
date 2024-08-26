using CalcularArea.clases;

namespace CalcularArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5, Calcular area de un circulo");
            Area areaCirculo = new Area();
            double radio, areacirculo;
            Console.WriteLine("Ingrese el radio de un circulo:");
            radio = double.Parse(Console.ReadLine());   

            areaCirculo.Radio = radio;

            areacirculo = areaCirculo.calcularArea();
            Console.WriteLine($"El area es: {areacirculo}");

        }
    }
}
