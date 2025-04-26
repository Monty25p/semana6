using System;

public class Icosaedro : Figura
{
    public double Lado { get; set; }

    public Icosaedro(double lado) : base("Icosaedro")
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return 5 * Math.Sqrt(3) * Math.Pow(Lado, 2);
    }

    public override double CalcularVolumen()
    {
        return (5 * (3 + Math.Sqrt(5))) / 12 * Math.Pow(Lado, 3);
    }
}
