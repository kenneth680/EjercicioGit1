using System;
using System.Collections.Generic;
using System.Text;
//Kenneth Ramirez
//20241900233
//Tengo 20 años
//Me siento en la matrix usando gitbash y los repositorios
namespace EjercicioGit
{
        public class Producto
        {
            // 1. Atributos privados
            private string nombre;
            private decimal precioBase;
            private int cantidadStock;
            private string categoria;
            private string marca;

            // 2. Constructor
            public Producto(string nombreProducto, decimal precio, int stock,
                string categoriaProducto, string marcaProducto)
            {
                nombre = nombreProducto;
                precioBase = precio;
                cantidadStock = stock;
                categoria = categoriaProducto;
                marca = marcaProducto;
            }


            // Método 1: Mostrar toda la información del producto
            public void MostrarInformacion()
            {
                Console.WriteLine("----- INFORMACIÓN DEL PRODUCTO -----");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Marca: {marca}");
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine($"Precio Base: L.{precioBase}");
                Console.WriteLine($"Cantidad en Stock: {cantidadStock} unidades");
                Console.WriteLine("------------------------------------");
            }

            // Método 2: Calcular precio con descuento
            public void CalcularPrecioConDescuento(decimal descuento)
            {
                decimal precioFinal = precioBase - descuento;
                Console.WriteLine($"Precio Base: L.{precioBase}");
                Console.WriteLine($"Descuento: L.{descuento}");
                Console.WriteLine($"Precio con Descuento: L.{precioFinal}\n");
            }

            // Método 3: Calcular valor total del inventario
            public void CalcularValorInventario()
            {
                decimal valorTotal = precioBase * cantidadStock;
                Console.WriteLine($"Precio Base: L.{precioBase}");
                Console.WriteLine($"Cantidad en Stock: {cantidadStock} unidades");
                Console.WriteLine($"Valor Total del Inventario: L.{valorTotal}\n");
            }

            // Método 4: Calcular precio con costo de envío
            public void CalcularPrecioConEnvio(decimal costoEnvio)
            {
                decimal precioFinal = precioBase + costoEnvio;
                Console.WriteLine($"Precio Base: L.{precioBase}");
                Console.WriteLine($"Costo de Envío: L.{costoEnvio}");
                Console.WriteLine($"Precio Total con Envío: L.{precioFinal}\n");
            }

            // Método 5: Calcular precio con impuesto
            public void CalcularPrecioConImpuesto(decimal impuesto)
            {
                decimal precioFinal = precioBase + impuesto;
                Console.WriteLine($"Precio Base: L.{precioBase}");
                Console.WriteLine($"Impuesto: L.{impuesto}");
                Console.WriteLine($"Precio con Impuesto: L.{precioFinal}\n");
            }
        }
    

}
