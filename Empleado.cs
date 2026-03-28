using System;

class Empleado
{
    public string Nombre;

    public virtual void Trabajar()
    {
        Console.WriteLine(Nombre + " está trabajando.");
    }
}

class Gerente : Empleado
{
    public override void Trabajar()
    {
        Console.WriteLine(Nombre + " está supervisando al equipo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "Carlos";
        empleado.Trabajar();

        Gerente gerente = new Gerente();
        gerente.Nombre = "Laura";
        gerente.Trabajar();
    }
}
