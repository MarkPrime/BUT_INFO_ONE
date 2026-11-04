using System;
using System.Text;


class Exercice_5
{
    static bool estPremier(int nombre)
    {
        for (int i = 2; i < nombre; i++)
        {
            if (nombre % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    static void Main()
    {
        int min;
        int max;
        bool res;
        
        while (true)
        {
            Console.WriteLine("Saisir un nombre min : ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir un nombre max : ");
            max = int.Parse(Console.ReadLine());

            for (min = min; min <= max; min++)
            {
                res = estPremier(min);
                if(res)
                {
                    Console.WriteLine(min);
                }
            }
            
        }
    }
}