namespace BucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*La instrucción while comprueba una condición y ejecuta la instrucción 
             * que aparece después de while. La comprobación de la condición y la 
             * ejecución de dichas instrucciones se repetirán hasta que la condición 
             * sea false.*/
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine($"Hello World! El contador es {contador}");
                contador++;
            }
        }
    }
}
