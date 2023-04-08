
Producto producto = new Producto();
producto.Nombre = "Producto 1";
producto.Precio = 30.0;
producto.FechaVencimiento = new DateTime(2023, 04, 10);
producto.Descripcion = "Descripción del producto 1";

producto.EstaVencido();
Console.WriteLine("Precio de venta: " + producto.GetPrecioVenta());
