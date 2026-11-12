using System;
using System.Text;

class Exercice_12
{
    static void Main()
    {
        int diviseur;
        int number;
        bool estPremiere;

        for (number = 0; number < 20; number++)
        {
            estPremiere = true; // le nombre est considere comme un nombre premiere             
            for (diviseur = 2; diviseur < number; diviseur++)
            {
                if (number % diviseur == 0)
                {
                    estPremiere = false; // le nombre est un nombre premier
                    break;
                }
            }
            if (estPremiere)
            {
                Console.WriteLine(number + " est un nombre premier");
            }
        }
    }
}