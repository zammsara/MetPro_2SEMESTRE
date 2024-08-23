namespace NumeroParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingresa un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) {
                Console.WriteLine("El numero " + numero + " es par.");
                }else {
                Console.WriteLine("El numero " + numero + " es impar.");
                }

        }
    }
}
