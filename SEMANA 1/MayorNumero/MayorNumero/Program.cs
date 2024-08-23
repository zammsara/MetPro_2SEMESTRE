namespace MayorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mayor;
            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            num3 = int.Parse(Console.ReadLine());
            mayor = num1;
            if (num2 >  mayor) { mayor = num2; }
            if (num3 > mayor) { num3 = num2; }
            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
