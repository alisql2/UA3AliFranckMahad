using System;

class Program
{
    static void Main()
    {
        // Instruction plus claire
        Console.Write("Saisissez une valeur en Pieds : ");
        double pieds = double.Parse(Console.ReadLine());
        double metresPieds = PiedsEnMetres(pieds);
        // Expression du resultat en phrase plus claire
        Console.WriteLine("La valeur " + pieds + " équivaux à " + metresPieds + " En mètres  ");
        //Ajout de cette ligne pour demontrer que cela vient du commit1
        Console.WriteLine(" branche1");

    }

    static double PiedsEnMetres(double p)
    {
        return p * 0.3048;
    }

}
