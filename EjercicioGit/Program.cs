using EjercicioGit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------* SISTEMA DE GESTIÓN DE PRODUCTOS ----------");

        // 4. Crear 3 productos distintos
        Producto producto1 = new Producto("Laptop HP Pavilion", 15000.00m, 25,
            "Tecnología", "HP");

        Producto producto2 = new Producto("Refrigeradora Samsung", 12500.00m, 15,
            "Electrodomésticos", "Samsung");

        Producto producto3 = new Producto("Smartwatch Xiaomi", 2500.00m, 50,
            "Accesorios", "Xiaomi");

        // Mostrar información del Producto 1
        Console.WriteLine("PRODUCTO 1");
        producto1.MostrarInformacion();
        producto1.CalcularPrecioConDescuento(1500.00m);
        producto1.CalcularValorInventario();
        producto1.CalcularPrecioConEnvio(250.00m);
        producto1.CalcularPrecioConImpuesto(2250.00m);

        // Mostrar información del Producto 2
        Console.WriteLine("PRODUCTO 2");
        producto2.MostrarInformacion();
        producto2.CalcularPrecioConDescuento(2000.00m);
        producto2.CalcularValorInventario();
        producto2.CalcularPrecioConEnvio(500.00m);
        producto2.CalcularPrecioConImpuesto(1875.00m);

        // Mostrar información del Producto 3
        Console.WriteLine("PRODUCTO 3");
        producto3.MostrarInformacion();
        producto3.CalcularPrecioConDescuento(300.00m);
        producto3.CalcularValorInventario();
        producto3.CalcularPrecioConEnvio(100.00m);
        producto3.CalcularPrecioConImpuesto(375.00m);

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}