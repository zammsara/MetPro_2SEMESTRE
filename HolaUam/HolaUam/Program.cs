namespace HolaUam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leer nombre y saludar
            string nombre;
            string apellido;
            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} {apellido}, mucho gusto."); 
        }
    }
}
