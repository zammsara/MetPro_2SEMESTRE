namespace Saludo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leer nombre y saludar
            string nombre, apellido;

            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} {apellido}, mucho gusto.");
        }
    }
}
