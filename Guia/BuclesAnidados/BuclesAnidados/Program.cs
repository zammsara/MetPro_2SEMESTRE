namespace BuclesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se puede anidar un bucle while, do o for dentro de otro para crear una 
             * matriz mediante la combinación de cada elemento del bucle externo con 
             * cada elemento del bucle interno. Vamos a crear un conjunto de pares 
             * alfanuméricos para representar filas y columnas.*/
            Console.WriteLine("Bucle generador de filas: ");
            for (int fila = 1; fila < 11; fila++)
            {
                Console.WriteLine($"La fila es {fila}");
            }

            Console.WriteLine("Bucle generador de columnas: ");
            for (char columna = 'a'; columna < 'k'; columna++)
            {
                Console.WriteLine($"La columna es {columna}");
            }

            Console.WriteLine("Bucle para formar pares: ");
            for (int fila = 1; fila < 11; fila++)
            {
                for (char columna = 'a'; columna < 'k'; columna++)
                {
                    Console.WriteLine($"La celda es: ({fila}, {columna})");
                }
            }
        }
    }
}
