using System;
using System.Text;


class Triangle
{
    static void Main()
    {
        //Declaration des constantes
        const string MOTIF1 = "*";
        const string MOTIF2 = " ";

        //Declaration des variables
        int hauteur, ligne, collone, nbEtoile, nbEspace;

        //Saisie
        Console.WriteLine("Saisir hauteur de triangle");
        hauteur = int.Parse(Console.ReadLine());

        //Calculs
        nbEtoile = 1;
        nbEspace = hauteur;
        for (ligne = 1; ligne <= hauteur; ligne++)
        {
            for (collone = 1; collone <= nbEspace; collone++)
            {
                Console.Write(MOTIF2);
            }
            for (collone = 1; collone <= nbEtoile; collone++)
            {
                Console.Write(MOTIF1);
            }
            Console.WriteLine("\n");
            nbEtoile = nbEtoile + 2;
            nbEspace = nbEspace - 1;
        }

        //Affichage

    }
}
