public class Pirámide : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Pirámide(double basePirámide, double altura) : base("Pirámide")
    {
        Base = basePirámide;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura / 2;
    }

    public override double CalcularVolumen()
    {
        return (1.0 / 3) * Base * Altura;
    }
}
