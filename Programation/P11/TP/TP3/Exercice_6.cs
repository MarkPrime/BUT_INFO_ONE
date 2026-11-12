using System;
using System.Text;

class Exercice_6
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
    static void Main()
    {
        int num;
        int result;

        Console.WriteLine("Saisir un nombre : ");
        num = int.Parse(Console.ReadLine());

        result = factorielle(num);
        Console.WriteLine(num+"!="+result);
    }
}