using System;

public class TroncoDePiramide : Figura
{
    public double BaseMayor { get; set; }
    public double BaseMenor { get; set; }
    public double Altura { get; set; }

    public TroncoDePiramide(double baseMayor, double baseMenor, double altura) : base("Tronco de Pirámide")
    {
        BaseMayor = baseMayor;
        BaseMenor = baseMenor;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        double areaBaseMayor = BaseMayor * BaseMayor;
        double areaBaseMenor = BaseMenor * BaseMenor;
        return areaBaseMayor + areaBaseMenor + (BaseMayor + BaseMenor) * Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow((BaseMayor - BaseMenor) / 2, 2));
    }

    public override double CalcularVolumen()
    {
        return (1.0 / 3) * Altura * (BaseMayor * BaseMayor + BaseMayor * BaseMenor + BaseMenor * BaseMenor);
    }
}
