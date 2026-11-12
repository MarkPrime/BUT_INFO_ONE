using System;
using System.Text;

class Exercice_18
{
    static void Main()
    {   
        const string MOTIF1 = "1";
        const string MOTIFE = " ";
        const string MOTIF2 = "0";

        int hauteur, ligne, collone, nbZero, nbUn;

        Console.WriteLine("Saisir hauteur: ");
        hauteur = int.Parse(Console.ReadLine());
        nbZero = 1;
        nbUn = hauteur;


        for (ligne = 1; ligne <= hauteur; ligne++)
        {
            for (collone = 1; collone < nbZero; collone++)
            {
                Console.Write(MOTIF2);
                Console.Write(MOTIFE);
            }
            for (collone = 1; collone <= nbUn; collone++)
            {
                Console.Write(MOTIF1);
                Console.Write(MOTIFE);
            }
            Console.Write("\n");
            nbUn = nbUn - 1;
            nbZero = nbZero + 1;
        }
    }
}
