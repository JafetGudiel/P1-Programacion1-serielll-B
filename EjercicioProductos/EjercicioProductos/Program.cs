using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de productos:");
            Console.WriteLine("ingrese el precio de loas 3 productos comprados: ");
            Console.WriteLine("Ingrese el precio del primer producto: ");
            int producto1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del segundo producto producto: ");
            int producto2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del Tercer producto: ");
            int producto3 = int.Parse(Console.ReadLine());
            int sumaDeProductos = producto1 + producto2 + producto3;

            if (sumaDeProductos > 100 )
            {
                double descuento = sumaDeProductos * 0.15;
                double total = sumaDeProductos - descuento;
                Console.WriteLine("su total bruto es de {0}", sumaDeProductos);
                Console.WriteLine("el total de su descuento es de: {0}", descuento);
                Console.WriteLine("El total de su compra con el descuento es de: {0}", total);
            }
            else
            {
                Console.WriteLine("No ha obtenido ningun descuento");
                Console.WriteLine("Su total a pagar es de: {0}", sumaDeProductos);
            }
            Console.ReadLine();
           
        }
    }
}
