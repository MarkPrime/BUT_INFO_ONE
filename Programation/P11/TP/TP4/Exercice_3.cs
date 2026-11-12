using System;
using System.Text;


class Exercice_3
{
    static void Main()
    {

        double[] suiteFib;

        suiteFib = new double[20];
        suiteFib[0] = 0;
        suiteFib[1] = 1;
        Console.WriteLine(0);
        Console.WriteLine(1);
        
        for (int i = 2; i < suiteFib.Length; i++)
        {
            
            suiteFib[i] = suiteFib[i-1] + suiteFib[i-2];

            Console.Write(suiteFib[i] + " ");
            Console.WriteLine(i + " ");
        }
        
    }
}