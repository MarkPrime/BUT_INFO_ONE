using System;
using System.Text;

class Exercie_7
{
    static int factorielle(int number) 
    {
        int factor = 1;

        if (number <= 0)
        {
            return -1;
        }

        for (int i = 1; i <= number; i++)
        {
            factor = factor * i;

        }
        return factor;
    }
    static float gagnerOrdreF(int n, int p) 
    {
        float chance;

        chance = factorielle(n)/factorielle(n-p);

        return chance;
    }
    static float gagnerDesordreF(int n, int p)
    {
        float chance;

        chance = factorielle(n)/factorielle(p)*factorielle(n-p);

        return chance;
    }

    static void Main()
    {
        int cheveauxPart=0;
        int cheveauxPod=0;
        float gagnerOrdre;
        float gagnerDesordre;
        bool saisir = true;
        int choix;

        while (saisir)
        {
            Console.WriteLine("Saisir nombre des chevaux partant : ");
            cheveauxPart = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir nombre de chevaux sur le podium : "); 
            cheveauxPod = int.Parse(Console.ReadLine());
            while (saisir)
            {
                Console.Write("\n\n\nNombre des chevaux : " + cheveauxPart + "\nNombre de chevaux sur le podium : " + cheveauxPod + "\n1 -- Probabilités de gagner dans l'ordre\n2 -- Probabilités de gagner dans le désordre\n3 -- Quitter\nChoix --> ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 1)
                {
                    gagnerOrdre = gagnerOrdreF(cheveauxPart, cheveauxPod);
                    Console.WriteLine("Probabilités de gagner dans l'ordre : 1/" + gagnerOrdre);
                }
                else if (choix == 2)
                {
                    gagnerDesordre = gagnerDesordreF(cheveauxPart, cheveauxPod);
                    Console.WriteLine("Probabilités de gagner dans le désordre : 1/" + gagnerDesordre);
                }
                else if (choix == 3)
                {
                    saisir = false;
                }
                else
                {
                    Console.WriteLine("Le nombre non valide");
                }
            }
        }
    }
}





