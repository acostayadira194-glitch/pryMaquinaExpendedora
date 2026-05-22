using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaquinaExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// ¿Por qué elegiste esos tipos de datos específicos para el precio y el inventario?
            /// Usé decimal para el precio porque es dinero y da más precisión.
            /// El int lo usé para el inventario porque solo se manejan cantidades enteras.

            /// ¿Cómo aplicaste el encapsulamiento para evitar que el menú principal altere el inventario de un producto directamente sin pasar por las reglas de validación?
            /// Usé atributos privados para que no se pueda modificar directamente desde el programa principal.
            /// Solo se puede cambiar usando los métodos comprar y abastecer(llenar) dentro de la clase.
            

            Producto coca = new Producto("Coca Cola", 22, 20);
            Producto sprite = new Producto("Sprite", 18, 30);
            Producto pepsi = new Producto("Pepsi", 18, 15);
            Producto sabritas = new Producto("Sabritas Adobadas", 15, 25);
            Producto doritos = new Producto("Doritos Nacho", 10, 20);
            Producto choco = new Producto("Chocorroles", 20, 15);
            Producto galletas = new Producto("Galletas Marías", 15, 17);

            int opcionMenu;

            do
            {
                Console.WriteLine("\n===== MAQUINA EXPENDEDORA =====");
                Console.WriteLine("1. Ver productos");
                Console.WriteLine("2. Comprar");
                Console.WriteLine("3. Abastecer");
                Console.WriteLine("4. Salir");

                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        coca.mostrarResultados();
                        sprite.mostrarResultados();
                        pepsi.mostrarResultados();
                        sabritas.mostrarResultados();
                        doritos.mostrarResultados();
                        choco.mostrarResultados();
                        galletas.mostrarResultados();
                        break;

                    case 2:
                        Console.WriteLine("\nElige producto:");
                        Console.WriteLine("1 Coca Cola\n2 Sprite\n3 Pepsi\n4 Sabritas Adobadas\n5 Doritos Nacho\n6 Chocorroles\n7 Galletas Marías");

                        int opcionCompra = int.Parse(Console.ReadLine());

                        Console.WriteLine("Cantidad:");
                        int cantidadCompra = int.Parse(Console.ReadLine());

                        if (opcionCompra == 1) coca.comprar(cantidadCompra);
                        else if (opcionCompra == 2) sprite.comprar(cantidadCompra);
                        else if (opcionCompra == 3) pepsi.comprar(cantidadCompra);
                        else if (opcionCompra == 4) sabritas.comprar(cantidadCompra);
                        else if (opcionCompra == 5) doritos.comprar(cantidadCompra);
                        else if (opcionCompra == 6) choco.comprar(cantidadCompra);
                        else if (opcionCompra == 7) galletas.comprar(cantidadCompra);

                        Console.WriteLine("\nPresiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("\nElige producto para abastecer:");
                        Console.WriteLine("1 Coca Cola\n2 Sprite\n3 Pepsi\n4 Sabritas Adobadas\n5 Doritos Nacho\n6 Chocorroles\n7 Galletas Marías");

                        int opcionAbasto = int.Parse(Console.ReadLine());

                        Console.WriteLine("Cantidad a agregar:");
                        int cantidadAbasto = int.Parse(Console.ReadLine());

                        if (opcionAbasto == 1) coca.abastecer(cantidadAbasto);
                        else if (opcionAbasto == 2) sprite.abastecer(cantidadAbasto);
                        else if (opcionAbasto == 3) pepsi.abastecer(cantidadAbasto);
                        else if (opcionAbasto == 4) sabritas.abastecer(cantidadAbasto);
                        else if (opcionAbasto == 5) doritos.abastecer(cantidadAbasto);
                        else if (opcionAbasto == 6) choco.abastecer(cantidadAbasto);
                        else if (opcionAbasto == 7) galletas.abastecer(cantidadAbasto);

                        break;

                    case 4:
                        Console.WriteLine("Saliendo, gracias por usar la máquina expendedora");
                        break;
                }

            } while (opcionMenu != 4);
        }
    }
}

