using System;
using System.Text;


class Triangle
{
    static void Main()
    {
        //Declaration des constantes
        const string MOTIF = "*";

        //Declaration des variables
        int hauteur, ligne, collone, nbEtoile;

        //Saisie
        Console.WriteLine("Saisir hauteur de triangle");
        hauteur = int.Parse(Console.ReadLine());

        //Calculs
        nbEtoile = 1;

        for (ligne = 1; ligne <= hauteur; ligne++)
        {
            for (collone = 1; collone <= nbEtoile; collone++)
            {
                Console.Write(MOTIF);
            }
            Console.WriteLine("\n");
            nbEtoile = nbEtoile + 2;
        }

        //Affichage

    }
}
