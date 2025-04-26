using System;

public class Tetraedro : Figura
{
    public double Lado { get; set; }

    public Tetraedro(double lado) : base("Tetraedro")
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Math.Sqrt(3) * Math.Pow(Lado, 2);
    }

    public override double CalcularVolumen()
    {
        return Math.Pow(Lado, 3) / (6 * Math.Sqrt(2));
    }
}
