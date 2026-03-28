using System;

class Vehiculo
{
    public string Marca;

    public void Encender()
    {
        Console.WriteLine("El vehículo está encendido.");
    }
}

class Carro : Vehiculo
{
    public int Puertas;

    public void MostrarInfo()
    {
        Console.WriteLine("Carro marca " + Marca + " con " + Puertas + " puertas.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Puertas = 4;

        carro.Encender();
        carro.MostrarInfo();
    }
}
