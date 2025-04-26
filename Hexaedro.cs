using System;

public class Hexaedro : Figura
{
    public double Lado { get; set; }

    public Hexaedro(double lado) : base("Hexaedro")
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return 6 * Math.Pow(Lado, 2);
    }

    public override double CalcularVolumen()
    {
        return Math.Pow(Lado, 3);
    }
}
