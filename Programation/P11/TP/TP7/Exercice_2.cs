using System;

class Exercice_2
{
    static void Main()
    {
        int saisie;
        int element;
        int indice;
        List<int> list;
        list = new List<int>();

        Console.WriteLine("Saisir un nombre :");
        saisie = int.Parse(Console.ReadLine());

        for (int i = 2; i <= saisie; i++)
        {
            list.Add(i);
        }
        for (int m = 0; m < list.Count(); m++)
        {
            element = list[m];
            indice = list[list.Count() - 1];
            for (int o = indice; o > element; o--)
            {
                if (o % element == 0)
                {
                    list.Remove(o);
                }
            }
        }
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
    }
}