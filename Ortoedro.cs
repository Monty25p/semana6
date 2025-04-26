public class Ortoedro : Figura
{
    public double Largo { get; set; }
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Ortoedro(double largo, double ancho, double alto) : base("Ortoedro")
    {
        Largo = largo;
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalcularArea()
    {
        return 2 * (Largo * Ancho + Largo * Alto + Ancho * Alto);
    }

    public override double CalcularVolumen()
    {
        return Largo * Ancho * Alto;
    }
}
