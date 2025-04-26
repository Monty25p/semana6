using System;

public class HusoEsferico : Figura
{
    public double Radio { get; set; }
    public double Altura { get; set; }

    public HusoEsferico(double radio, double altura) : base("Huso Esférico")
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
        return Math.PI * Math.Pow(Radio, 2) * Altura;
    }
}
