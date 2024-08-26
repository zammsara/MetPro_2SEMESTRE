using CalcularRaiz.clases;

namespace CalcularRaiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4, Calcular la raiz cuadrada");
            Raiz raiz = new Raiz();
            double num, raizC;
            Console.WriteLine("Ingresa un numero: ");
            num = double.Parse(Console.ReadLine());

            raiz.Num = num;

            raizC = raiz.calcularRaiz();
            Console.WriteLine($"La raiz cuadrada es: {raizC}");
        }
    }
}
