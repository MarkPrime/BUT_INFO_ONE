using System;
using System.Text;


class Exercice_14
{
    static void Main()
    {
        const int PRIME = 8;
        const int SIX = 6;
        const double CINC = 5.5;
        const int PRIMEPLACES = 5;

        decimal total = 0;
        bool isPossible = true;
        int nombrePlaces;


        while (isPossible)
        {
            Console.WriteLine("saisir combien places");
            nombrePlaces = int.Parse(Console.ReadLine());

            for (decimal i = 0; i <= nombrePlaces; i++)
            {
                if (nombrePlaces <= PRIMEPLACES)
                {
                    total = i * PRIME;
                }
                else if (nombrePlaces <= 10 && nombrePlaces > PRIMEPLACES)
                {
                    total = total + i * SIX;
                }
                else
                {
                    total = i * (decimal)CINC;
                }
            }
            
            Console.WriteLine(total + "$");
        }
    }
}