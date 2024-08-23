using Compras.clases;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1");
            Factura fact = new Factura();
            string producto = null;
            double precio=0, monto;
            int cantidad=0;
            Console.Write("Producto: ");
            producto = Console.ReadLine();
            Console.Write("Precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            fact.Producto = producto;
            fact.Precio = precio;
            fact.Cantidad = cantidad;

            monto = fact.calcularMonto();

            Console.WriteLine($"{producto}");
            Console.WriteLine($"{precio}");
            Console.WriteLine($"{cantidad}");
            Console.WriteLine($"{monto}");
        }
    }
}
