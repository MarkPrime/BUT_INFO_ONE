using System;

class Exercice_7
{
    static void Main()
    {
        int[] tab = {5, 11, 19, 38, 54, 55, 78, 87, 100, 105};
        int val;
        int res;

        Console.WriteLine("Saisir une valeur à chercher : ");
        val = int.Parse(Console.ReadLine());

        res = dicho(val, tab);

        if (res == -1)
        {
            Console.WriteLine("Valeur pas trouvée");
        }
        else
        {
            Console.WriteLine("Valeur trouvée");
        }
    }

    static int dicho(int valeur, int[] tableau)
    {
        tableau[0] = valeur;
        return -1;
    }
}