namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double resultado;

            Console.WriteLine("Introduce el radio: ");
            radio = float.Parse(Console.ReadLine();

            resultado = Math.PI * Math.Pow(2, radio);

            Console.WriteLine($"El area del circulo es: {resultado}");
        }
    }
}
