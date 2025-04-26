using System;

public class Cono : Figura
{
    public double Radio { get; set; }
    public double Altura { get; set; }

    public Cono(double radio, double altura) : base("Cono")
    {
        Radio = radio;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * (Radio + Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Radio, 2)));
    }

    public override double CalcularVolumen()
    {
        return (1.0 / 3) * Math.PI * Math.Pow(Radio, 2) * Altura;
    }
}
