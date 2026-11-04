using System;
using System.Text;


class Exercice_2
{
    static void Main()
    {
        const int TABLESIZE = 10;
        double[] tab1;
        double[] tab2;
        double[] tab3;

        double val = 20;
        
        tab1 = new double[TABLESIZE];
        tab2 = new double[TABLESIZE];
        tab3 = new double[TABLESIZE];

        for (int i = 0; i < TABLESIZE; i++)
        {
            tab1[i] = 0;
            Console.Write(tab1[i] + " ");
        }
        Console.WriteLine("\n");

        for (int i = 0; i < TABLESIZE; i++)
        {
            tab2[i] = i + 1;
            Console.Write(tab2[i] + " ");
        }
        Console.WriteLine("\n");

        for (int i = 0; i < TABLESIZE; i++)
        {
            tab3[i] = val;
            val = val - 2;
            Console.Write(tab3[i]+ " ");
        }
        Console.WriteLine("\n");
    }
}