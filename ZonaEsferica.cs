using System;

public class ZonaEsferica : Figura
{
    public double Radio { get; set; }
    public double Altura { get; set; }

    public ZonaEsferica(double radio, double altura) : base("Zona Esférica")
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
        return (1.0 / 3) * Math.PI * Math.Pow(Radio, 2) * Altura;
    }
}
