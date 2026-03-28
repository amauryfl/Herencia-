using System;

class Persona
{
    public string Nombre;

    public void Saludar()
    {
        Console.WriteLine("Hola, mi nombre es " + Nombre);
    }
}

class Estudiante : Persona
{
    public string Carrera;

    public void MostrarCarrera()
    {
        Console.WriteLine("Estudio la carrera de " + Carrera);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();
        estudiante.Nombre = "Amaury";
        estudiante.Carrera = "Ingeniería en Software";

        estudiante.Saludar();
        estudiante.MostrarCarrera();
    }
}
