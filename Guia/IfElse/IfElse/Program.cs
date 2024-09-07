namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingresa un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero: ");
            b = int.Parse(Console.ReadLine());
            if (a + b > 10)
                Console.WriteLine("La suma es mayor que 10");
            else
                Console.WriteLine("La suma es menor que 10");
        }
    }
}
