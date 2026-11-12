using System;
using System.Text;


class Exercice_8
{
    static void Main()
    {
        //Declaration des constantes
        
        //Declaration des variables
        int i, nb, fac = 1;

        //Saisie
        Console.WriteLine("Saisir nombre :");
        nb = int.Parse(Console.ReadLine());

        for (i = 1; i <= nb; i++)
        {
            //calculs
            fac = fac * i;

        }

        //Calculs

        //Affichage
        Console.WriteLine("Le nombre est : " + fac);

    }
}

