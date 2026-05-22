using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaquinaExpendedora
{
    internal class Producto
    {
        private string nombreProducto;
        private decimal costoUnitario;
        private int stock;

        public Producto(string nombreProducto, decimal costoUnitario, int stockInicial)
        {
            this.nombreProducto = nombreProducto;
            this.costoUnitario = costoUnitario;
            this.stock = stockInicial;
        }

        public void comprar(int cantidadCompra)
        {
            if (stock >= cantidadCompra)
            {
                stock = stock - cantidadCompra;
                decimal totalPago = cantidadCompra * costoUnitario;

                Console.WriteLine("Total a pagar: " + totalPago);
            }
            else
            {
                Console.WriteLine("No hay suficiente existencia del producto");
            }
        }

        public void abastecer(int cantidadAgregar)
        {
            if (cantidadAgregar > 0)
            {
                stock += cantidadAgregar;
            }
            else
            {
                Console.WriteLine("Cantidad no válida");
            }
        }

        public void mostrarResultados()
        {
            Console.WriteLine("Producto: " + nombreProducto +  "\nPrecio: " + costoUnitario + "\nExistencias: " + stock  );
        }
    }
}
