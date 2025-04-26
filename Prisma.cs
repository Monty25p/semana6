public class Prisma : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Prisma(double basePrisma, double altura) : base("Prisma")
    {
        Base = basePrisma;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return 2 * Base * Altura;
    }

    public override double CalcularVolumen()
    {
        return Base * Altura;
    }
}
