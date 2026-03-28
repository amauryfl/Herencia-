using System;

class Producto
{
    public string Nombre;
    public double Precio;

    public void MostrarProducto()
    {
        Console.WriteLine("Producto: " + Nombre + " - Precio: " + Precio);
    }
}

class Bebida : Producto
{
    public double Litros;

    public void MostrarBebida()
    {
        Console.WriteLine("Bebida: " + Nombre + " - Precio: " + Precio + " - Litros: " + Litros);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bebida bebida = new Bebida();
        bebida.Nombre = "Jugo";
        bebida.Precio = 75;
        bebida.Litros = 1.5;

        bebida.MostrarProducto();
        bebida.MostrarBebida();
    }
}
