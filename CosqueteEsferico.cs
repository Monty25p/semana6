using System;

public class CasqueteEsferico : Figura
{
    public double Radio { get; set; }
    public double Altura { get; set; }

    public CasqueteEsferico(double radio, double altura) : base("Casquete Esférico")
    {
        Radio = radio;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return 2 * Math.PI * Radio * Altura;
    }

    public override double CalcularVolumen()
    {
        return (Math.PI * Math.Pow(Altura, 2) * (3 * Radio - Altura)) / 3;
    }
}
