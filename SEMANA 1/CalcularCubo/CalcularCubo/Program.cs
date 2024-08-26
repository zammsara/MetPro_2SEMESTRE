using CalcularCubo.clases;

namespace CalcularCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3, Calcular el cubo");
            Cubo CalcularCubo = new Cubo();
            double num, cubo;
            Console.WriteLine("Ingresa un numero: ");
            num = double.Parse(Console.ReadLine());

            CalcularCubo.Num = num;

            cubo = CalcularCubo.calcularCubo();
            Console.WriteLine($"El cubo es: {cubo}");
        }
    }
}
