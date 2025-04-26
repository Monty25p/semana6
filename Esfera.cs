using System;

public class Esfera : Figura
{
    public double Radio { get; set; }

    public Esfera(double radio) : base("Esfera")
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return 4 * Math.PI * Math.Pow(Radio, 2);
    }

    public override double CalcularVolumen()
    {
        return (4.0 / 3) * Math.PI * Math.Pow(Radio, 3);
    }
}
