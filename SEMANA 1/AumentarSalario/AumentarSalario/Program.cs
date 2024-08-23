namespace AumentarSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, cargo;
            double salario, aumento, nuevoSalario;

            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu cargo: ");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingresa tu salario: ");
            salario = double.Parse(Console.ReadLine());
            aumento = salario * 0.10;
            nuevoSalario = aumento + salario;
            Console.WriteLine(nombre + " " + cargo + " " + nuevoSalario);
        }
    }
}
