using System;

public class TroncoDeCono : Figura
{
    public double RadioMayor { get; set; }
    public double RadioMenor { get; set; }
    public double Altura { get; set; }

    public TroncoDeCono(double radioMayor, double radioMenor, double altura) : base("Tronco de Cono")
    {
        RadioMayor = radioMayor;
        RadioMenor = radioMenor;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        double generatriz = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(RadioMayor - RadioMenor, 2));
        return Math.PI * (RadioMayor + RadioMenor) * generatriz + Math.PI * Math.Pow(RadioMayor, 2) + Math.PI * Math.Pow(RadioMenor, 2);
    }

    public override double CalcularVolumen()
    {
        return (1.0 / 3) * Math.PI * Altura * (Math.Pow(RadioMayor, 2) + RadioMayor * RadioMenor + Math.Pow(RadioMenor, 2));
    }
}
