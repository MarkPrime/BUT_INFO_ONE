using System;
using System.Text;



class Exercice_5
{
    static void Main()
    {
        int number;

        int[] tab;

        tab = new int[21];

        number = 0;

        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = 0;
            Console.Write(tab[i] + " ");
        }
        Console.WriteLine("\n");

        while (number != -1)
        {
            Console.WriteLine("Saisir un nombre : ");
            number = int.Parse(Console.ReadLine());

            if (number < tab.Length && number >= 0)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    if (number == i)
                    {
                        tab[i] = tab[i] + 1;
                    }
                    histogrammeHorisontal(tab[i], i);
                }
            }
            else if (number == -1)
            {
                Console.WriteLine("exit;");
            }
            else
            {
                Console.WriteLine("Numero invalide, entrer : (0 a 20) ou -1 \n");
            }

            Console.WriteLine("\n");
        }
    }

    static void histogrammeHorisontal(int num, int i)
    {
        char charact = '=';
        Console.Write(i + " : ");
        for (int n = 0; n < num; n++)
        {
            Console.Write(charact);
        }
        Console.Write("\n");
    }
}