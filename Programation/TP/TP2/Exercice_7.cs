using System;
using System.Text;


class Exercice_7
{
    static void Main()
    {
        //Declaration des constantes
        
        //Declaration des variables
        int i, nb, somme = 0;

        //Saisie
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("Saisir 10 nombres :");
            nb = int.Parse(Console.ReadLine());
            //calculs
            somme = somme + nb;

        }

        //Calculs

        //Affichage
        Console.WriteLine("Le nombre est : " + somme);

    }
}

