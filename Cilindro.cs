using System;

public class Cilindro : Figura
{
    public double Radio { get; set; }
    public double Altura { get; set; }

    public Cilindro(double radio, double altura) : base("Cilindro")
    {
        Radio = radio;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return 2 * Math.PI * Radio * (Radio + Altura);
    }

    public override double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio, 2) * Altura;
    }
}
