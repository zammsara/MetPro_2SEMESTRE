using CalcularNota.clases;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 2, Calcular nota");
            Nota NotaFinal = new Nota();
            double nota1, nota2, nota3, notafinal;
            Console.WriteLine("Ingresa la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());

            NotaFinal.Nota1 = nota1;
            NotaFinal.Nota2 = nota2;
            NotaFinal.Nota3 = nota3;

            notafinal = NotaFinal.calcularNF();
            Console.WriteLine($"Tu nota final es: {notafinal}");
        }
    }
}
