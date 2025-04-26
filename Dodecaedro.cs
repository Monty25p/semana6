using System;

public class Dodecaedro : Figura
{
    public double Lado { get; set; }

    public Dodecaedro(double lado) : base("Dodecaedro")
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Math.Pow(Lado, 2);
    }

    public override double CalcularVolumen()
    {
        return (15 + 7 * Math.Sqrt(5)) / 4 * Math.Pow(Lado, 3);
    }
}
