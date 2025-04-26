using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\nSelecciona una figura para calcular su área y volumen:\n");
            Console.WriteLine("1. Prisma");
            Console.WriteLine("2. Cilindro");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Esfera");
            Console.WriteLine("5. Pirámide");
            Console.WriteLine("6. Zona Esférica");
            Console.WriteLine("7. Casquete Esférico");
            Console.WriteLine("8. Huso Esférico");
            Console.WriteLine("9. Ortoedro");
            Console.WriteLine("10. Tetraedro");
            Console.WriteLine("11. Hexaedro");
            Console.WriteLine("12. Octaedro");
            Console.WriteLine("13. Dodecaedro");
            Console.WriteLine("14. Icosaedro");
            Console.WriteLine("15. Tronco de Cono");
            Console.WriteLine("16. Tronco de Pirámide");
            Console.Write("\nSelecciona una opción: \n");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularPrisma();
                    break;
                case 2:
                    CalcularCilindro();
                    break;
                case 3:
                    CalcularCono();
                    break;
                case 4:
                    CalcularEsfera();
                    break;
                case 5:
                    CalcularPiramide();
                    break;
                case 6:
                    CalcularZonaEsferica();
                    break;
                case 7:
                    CalcularCasqueteEsferico();
                    break;
                case 8:
                    CalcularHusoEsferico();
                    break;
                case 9:
                    CalcularOrtoedro();
                    break;
                case 10:
                    CalcularTetraedro();
                    break;
                case 11:
                    CalcularHexaedro();
                    break;
                case 12:
                    CalcularOctaedro();
                    break;
                case 13:
                    CalcularDodecaedro();
                    break;
                case 14:
                    CalcularIcosaedro();
                    break;
                case 15:
                    CalcularTroncoCono();
                    break;
                case 16:
                    CalcularTroncoPiramide();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
        while (opcion != 0);
    }

    static void Menu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\nSelecciona una figura para calcular su área y volumen:\n");
            Console.WriteLine("1. Prisma");
            Console.WriteLine("2. Cilindro");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Esfera");
            Console.WriteLine("5. Pirámide");
            Console.WriteLine("6. Zona Esférica");
            Console.WriteLine("7. Casquete Esférico");
            Console.WriteLine("8. Huso Esférico");
            Console.WriteLine("9. Ortoedro");
            Console.WriteLine("10. Tetraedro");
            Console.WriteLine("11. Hexaedro");
            Console.WriteLine("12. Octaedro");
            Console.WriteLine("13. Dodecaedro");
            Console.WriteLine("14. Icosaedro");
            Console.WriteLine("15. Tronco de Cono");
            Console.WriteLine("16. Tronco de Pirámide");
            Console.WriteLine("0. Salir");
            Console.Write("\nSelecciona una opción: \n");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularPrisma();
                    break;
                case 2:
                    CalcularCilindro();
                    break;
                case 3:
                    CalcularCono();
                    break;
                case 4:
                    CalcularEsfera();
                    break;
                case 5:
                    CalcularPiramide();
                    break;
                case 6:
                    CalcularZonaEsferica();
                    break;
                case 7:
                    CalcularCasqueteEsferico();
                    break;
                case 8:
                    CalcularHusoEsferico();
                    break;
                case 9:
                    CalcularOrtoedro();
                    break;
                case 10:
                    CalcularTetraedro();
                    break;
                case 11:
                    CalcularHexaedro();
                    break;
                case 12:
                    CalcularOctaedro();
                    break;
                case 13:
                    CalcularDodecaedro();
                    break;
                case 14:
                    CalcularIcosaedro();
                    break;
                case 15:
                    CalcularTroncoCono();
                    break;
                case 16:
                    CalcularTroncoPiramide();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
        while (opcion != 0);
    }

    static void Volver()
    {
        string op;
        Console.WriteLine("\n¿Desea volver al menu?");

        do
        {
            Console.WriteLine("Debe de ser (si) o (no)");
            op = Console.ReadLine();

            if (op == "si")
                Menu();

            if(op == "no")
            {
                Console.WriteLine("Saliendo...");
                Environment.Exit(0);
            }


        }
        while (op != "si" && op != "no");
        

    }

    static void CalcularPrisma()
    {
        Console.WriteLine("\nIngrese la base del prisma (cm):");
        double basePrisma = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del prisma (cm):");
        double alturaPrisma = Convert.ToDouble(Console.ReadLine());
        Figura prisma = new Prisma(basePrisma, alturaPrisma);
        prisma.MostrarInfo();
        Volver();
    }

    static void CalcularCilindro()
    {
        Console.WriteLine("\nIngrese el radio del cilindro (cm):");
        double radioCilindro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del cilindro (cm):");
        double alturaCilindro = Convert.ToDouble(Console.ReadLine());
        Figura cilindro = new Cilindro(radioCilindro, alturaCilindro);
        cilindro.MostrarInfo();
        Volver();
    }

    static void CalcularCono()
    {
        Console.WriteLine("\nIngrese el radio del cono (cm):");
        double radioCono = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del cono (cm):");
        double alturaCono = Convert.ToDouble(Console.ReadLine());
        Figura cono = new Cono(radioCono, alturaCono);
        cono.MostrarInfo();
        Volver();
    }

    static void CalcularEsfera()
    {
        Console.WriteLine("\nIngrese el radio de la esfera (cm):");
        double radioEsfera = Convert.ToDouble(Console.ReadLine());
        Figura esfera = new Esfera(radioEsfera);
        esfera.MostrarInfo();
        Volver();
    }

    static void CalcularPiramide()
    {
        Console.WriteLine("\nIngrese la base de la pirámide (cm):");
        double basePiramide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura de la pirámide (cm):");
        double alturaPiramide = Convert.ToDouble(Console.ReadLine());
        Figura piramide = new Pirámide(basePiramide, alturaPiramide);
        piramide.MostrarInfo();
        Volver();
    }

    static void CalcularZonaEsferica()
    {
        Console.WriteLine("\nIngrese el radio de la zona esférica (cm):");
        double radioZonaEsferica = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura de la zona esférica (cm):");
        double alturaZonaEsferica = Convert.ToDouble(Console.ReadLine());
        Figura zonaEsferica = new ZonaEsferica(radioZonaEsferica, alturaZonaEsferica);
        zonaEsferica.MostrarInfo();
        Volver();
    }

    static void CalcularCasqueteEsferico()
    {
        Console.WriteLine("\nIngrese el radio del casquete esférico (cm):");
        double radioCasquete = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del casquete esférico (cm):");
        double alturaCasquete = Convert.ToDouble(Console.ReadLine());
        Figura casqueteEsferico = new CasqueteEsferico(radioCasquete, alturaCasquete);
        casqueteEsferico.MostrarInfo();
        Volver();
    }

    static void CalcularHusoEsferico()
    {
        Console.WriteLine("\nIngrese el radio del huso esférico (cm):");
        double radioHuso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del huso esférico (cm):");
        double alturaHuso = Convert.ToDouble(Console.ReadLine());
        Figura husoEsferico = new HusoEsferico(radioHuso, alturaHuso);
        husoEsferico.MostrarInfo();
        Volver();
    }

    static void CalcularOrtoedro()
    {
        Console.WriteLine("\nIngrese el largo del ortoedro (cm):");
        double largoOrtoedro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el ancho del ortoedro (cm):");
        double anchoOrtoedro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del ortoedro (cm):");
        double altoOrtoedro = Convert.ToDouble(Console.ReadLine());
        Figura ortoedro = new Ortoedro(largoOrtoedro, anchoOrtoedro, altoOrtoedro);
        ortoedro.MostrarInfo();
        Volver();
    }

    static void CalcularTetraedro()
    {
        Console.WriteLine("\nIngrese el lado del tetraedro (cm):");
        double ladoTetraedro = Convert.ToDouble(Console.ReadLine());
        Figura tetraedro = new Tetraedro(ladoTetraedro);
        tetraedro.MostrarInfo();
        Volver();
    }

    static void CalcularHexaedro()
    {
        Console.WriteLine("\nIngrese el lado del hexaedro (cm):");
        double ladoHexaedro = Convert.ToDouble(Console.ReadLine());
        Figura hexaedro = new Hexaedro(ladoHexaedro);
        hexaedro.MostrarInfo();
        Volver();
    }

    static void CalcularOctaedro()
    {
        Console.WriteLine("\nIngrese el lado del octaedro (cm):");
        double ladoOctaedro = Convert.ToDouble(Console.ReadLine());
        Figura octaedro = new Octaedro(ladoOctaedro);
        octaedro.MostrarInfo();
        Volver();
    }

    static void CalcularDodecaedro()
    {
        Console.WriteLine("\nIngrese el lado del dodecaedro (cm):");
        double ladoDodecaedro = Convert.ToDouble(Console.ReadLine());
        Figura dodecaedro = new Dodecaedro(ladoDodecaedro);
        dodecaedro.MostrarInfo();
        Volver();
    }

    static void CalcularIcosaedro()
    {
        Console.WriteLine("\nIngrese el lado del icosaedro (cm):");
        double ladoIcosaedro = Convert.ToDouble(Console.ReadLine());
        Figura icosaedro = new Icosaedro(ladoIcosaedro);
        icosaedro.MostrarInfo();
        Volver();
    }

    static void CalcularTroncoCono()
    {
        Console.WriteLine("\nIngrese el radio mayor del tronco de cono (cm):");
        double radioMayorTroncoCono = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el radio menor del tronco de cono (cm):");
        double radioMenorTroncoCono = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del tronco de cono (cm):");
        double alturaTroncoCono = Convert.ToDouble(Console.ReadLine());
        Figura troncoDeCono = new TroncoDeCono(radioMayorTroncoCono, radioMenorTroncoCono, alturaTroncoCono);
        troncoDeCono.MostrarInfo();
        Volver();
    }

    static void CalcularTroncoPiramide()
    {
        Console.WriteLine("\nIngrese la base mayor del tronco de pirámide (cm):");
        double baseMayorTroncoPiramide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la base menor del tronco de pirámide (cm):");
        double baseMenorTroncoPiramide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del tronco de pirámide (cm):");
        double alturaTroncoPiramide = Convert.ToDouble(Console.ReadLine());
        Figura troncoDePiramide = new TroncoDePiramide(baseMayorTroncoPiramide, baseMenorTroncoPiramide, alturaTroncoPiramide);
        troncoDePiramide.MostrarInfo();
        Volver();
    }
}
