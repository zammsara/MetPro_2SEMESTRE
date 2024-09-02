using UseIf.models;

namespace UseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Decidir si es niño, joven o adulto
             
            Niño: 0-12
            Joven: 13-25
            Adulto:26 a ++
            */

            int edad = 0;
            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingresa tu edad: ");
            try
            {
                edad = int.Parse(Console.ReadLine());
                Evaluate evaluate = new Evaluate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
