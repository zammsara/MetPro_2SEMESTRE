namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*El bucle do ... while primero ejecuta el código 
             * y después comprueba la condición.*/
            int contador = 0;
            do
            {
                Console.WriteLine($"Hello World! El contador es {contador}");
                contador++;
            } while (contador < 10);
        }
    }
}
