using System;

class Program
{
    static void Main()
    {
        Console.Write("Pieds : ");
        double pieds = double.Parse(Console.ReadLine());
        double metresPieds = PiedsEnMetres(pieds);
        Console.WriteLine("En mètres = " + metresPieds);

    }

    static double PiedsEnMetres(double p)
    {
        return p * 0.3048;
    }

}
