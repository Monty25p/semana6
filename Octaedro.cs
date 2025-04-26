using System;

public class Octaedro : Figura
{
    public double Lado { get; set; }

    public Octaedro(double lado) : base("Octaedro")
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return 2 * Math.Sqrt(3) * Math.Pow(Lado, 2);
    }

    public override double CalcularVolumen()
    {
        return Math.Pow(Lado, 3) / (3 * Math.Sqrt(2));
    }
}
