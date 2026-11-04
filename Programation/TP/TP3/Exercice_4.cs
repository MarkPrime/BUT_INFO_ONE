using System;
using System.Text;


class Exercice_4
{
    static int compare(float a, float b)
    {
        if (a == b)
        {
            return 0;   
        }
        else if (a > b)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
    static void Main()
    {
        float numA;
        float numB;
        int res;

        Console.WriteLine("Saisir a : ");
        numA = float.Parse(Console.ReadLine());
        Console.WriteLine("Saisir b : ");
        numB = float.Parse(Console.ReadLine());

        res = compare(numA,numB);

        Console.WriteLine("resultat : " + res);
    }
}