using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_10
{
    internal class Program
    {
        class Venta
        {
            public string Producto;
            public int Unidades;
        }

        static List<Venta> ventas = new List<Venta>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Productos de mPhone");
                Console.WriteLine("================================");
                Console.WriteLine("1: Ventas de mPhone 3000");
                Console.WriteLine("2: Ventas de mPad 3500");
                Console.WriteLine("3: Ventas de MAPBrook 3800");
                Console.WriteLine("4: Ventas de mWatch 8000");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ShowVentaDeProducto("mPhone 3000");
                        break;
                    case 2:
                        ShowVentaDeProducto("mPad 3500");
                        break;
                    case 3:
                        ShowVentaDeProducto("MAPBrook 3800");
                        break;
                    case 4:
                        ShowVentaDeProducto("mWatch 8000");
                        break;
                    case 5:
                        MostrarEstadisticasFinales();
                        Console.WriteLine("¡Hasta Luego!");
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ShowVentaDeProducto(string producto)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar Venta de {producto}");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar Venta");
                Console.WriteLine("2: Registrar Devolución");
                Console.WriteLine("3: Menu Principal");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ConfirmarVenta(producto);
                        break;
                    case 2:
                        ConfirmarDevolucion(producto);
                        break;
                    case 3:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ShowVentaDeProducto(string producto)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar Venta de {producto}");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar Venta");
                Console.WriteLine("2: Registrar Devolución");
                Console.WriteLine("3: Menu Principal");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ConfirmarVenta(producto);
                        break;
                    case 2:
                        ConfirmarDevolucion(producto);
                        break;
                    case 3:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ShowVentaDeProducto(string producto)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar Venta de {producto}");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar Venta");
                Console.WriteLine("2: Registrar Devolución");
                Console.WriteLine("3: Menu Principal");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ConfirmarVenta(producto);
                        break;
                    case 2:
                        ConfirmarDevolucion(producto);
                        break;
                    case 3:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ShowVentaDeProducto(string producto)
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"Registrar Venta de {producto}");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar Venta");
                Console.WriteLine("2: Registrar Devolución");
                Console.WriteLine("3: Menu Principal");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ConfirmarVenta(producto);
                        break;
                    case 2:
                        ConfirmarDevolucion(producto);
                        break;
                    case 3:
                        return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ConfirmarDevolucion(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la devolución de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la devolución del producto
                ventas.Add(new Venta { Producto = producto, Unidades = -1 });
                Console.WriteLine("Devolución registrada con éxito.");
            }
            Console.ReadKey();
        }
        static void ConfirmarDevolucion(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la devolución de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la devolución del producto
                ventas.Add(new Venta { Producto = producto, Unidades = -1 });
                Console.WriteLine("Devolución registrada con éxito.");
            }
            Console.ReadKey();
        }
        static void ConfirmarDevolucion(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la devolución de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la devolución del producto
                ventas.Add(new Venta { Producto = producto, Unidades = -1 });
                Console.WriteLine("Devolución registrada con éxito.");
            }
            Console.ReadKey();
        }
        static void ConfirmarDevolucion(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la devolución de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la devolución del producto
                ventas.Add(new Venta { Producto = producto, Unidades = -1 });
                Console.WriteLine("Devolución registrada con éxito.");
            }
            Console.ReadKey(); 
        }
        static void ConfirmarVenta(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la venta del producto
                ventas.Add(new Venta { Producto = producto, Unidades = 1 });
                Console.WriteLine("Venta registrada con éxito.");
            }
            Console.ReadKey();
        }
        static void ConfirmarVenta(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la venta del producto
                ventas.Add(new Venta { Producto = producto, Unidades = 1 });
                Console.WriteLine("Venta registrada con éxito.");
            }
            Console.ReadKey();
        }
        static void ConfirmarVenta(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la venta del producto
                ventas.Add(new Venta { Producto = producto, Unidades = 1 });
                Console.WriteLine("Venta registrada con éxito.");
            }
            Console.ReadKey(); ;
        }
        static void ConfirmarVenta(string producto)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================");
            Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registra la venta del producto
                ventas.Add(new Venta { Producto = producto, Unidades = 1 });
                Console.WriteLine("Venta registrada con éxito.");
            }
            Console.ReadKey();
        }
        static void MostrarEstadisticasFinales()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Reporte Final");
            Console.WriteLine("================================");
            Console.WriteLine("Productos Vendidos | Cantidad");
            Console.WriteLine("--------------------------------");

            // Crear un diccionario para almacenar las cantidades vendidas por producto
            Dictionary<string, int> cantidadesPorProducto = new Dictionary<string, int>();

            foreach (var venta in ventas)
            {
                string producto = venta.Producto;

                // Si el producto ya existe en el diccionario, suma la cantidad vendida
                if (cantidadesPorProducto.ContainsKey(producto))
                {
                    cantidadesPorProducto[producto] += venta.Unidades;
                }
                else
                {
                    // Si no existe en el diccionario, agrega una nueva entrada
                    cantidadesPorProducto[producto] = venta.Unidades;
                }
            }

            // Iterar sobre el diccionario para mostrar las cantidades vendidas
            foreach (var kvp in cantidadesPorProducto)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("--------------------------------");

            // Calcular el total general
            int totalGeneral = cantidadesPorProducto.Values.Sum();
            Console.WriteLine($"Total | {totalGeneral}");
            Console.WriteLine("================================");
            Console.ReadKey();
        }

    }
}