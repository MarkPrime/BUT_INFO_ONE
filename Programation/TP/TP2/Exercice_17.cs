using System;
using System.Text;


class Exercice_17
{
    static void Main()
    {
        double numberS;
        double somme;

        Console.WriteLine("Saisir un nombre: ");
        numberS = double.Parse(Console.ReadLine());

        somme = 0;

        for (int i = 1; i <= numberS; i++)
        {
            somme = somme + 1.0 / i;
            Console.WriteLine(somme);
        }
    }
}