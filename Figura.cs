using System;

public abstract class Figura
{
    public string Nombre { get; set; }

    public Figura(string nombre)
    {
        Nombre = nombre;
    }

    public abstract double CalcularArea();
    public abstract double CalcularVolumen();

    public void MostrarInfo()
    {
        Console.WriteLine($"Figura: {Nombre}");
        Console.WriteLine($"Área: {Math.Round(CalcularArea(), 2)} cm^2");
        Console.WriteLine($"Volumen: {Math.Round(CalcularVolumen(), 2)} cm^3");
    }

}
