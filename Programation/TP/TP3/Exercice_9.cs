using System;
using System.Text;


class Exercice_9
{
    static void classer(int a, int b, int c, ref int min, ref int mid, ref int max)
    {
        if (a > b && a > c && b > c)
        {
            max = a;
            mid = b;
            min = c;
        }
        else if (b > a && b > c && a > c)
        {
            max = b;
            mid = a;
            max = c;
        }
        else if (c > a && c > b && b > a)
        {
            max = c;
            mid = b;
            min = a;
        }
        else if (a > b && a > c && c > b)
        {
            max = a;
            mid = c;
            min = b;
        }
        else if (b > a && b > c && c > a)
        {
            max = b;
            mid = c;
            min = a;
        }
        else if (c > a && c > b && a > b)
        {
            max = c;
            mid = a;
            mid = b;
        }
    }
    static void Main()
    {
        int numA;
        int numB;
        int numC;
        
        Console.WriteLine("Saisir A : ");
        numA = int.Parse(Console.ReadLine());
        Console.WriteLine("Saisir B : ");
        numB = int.Parse(Console.ReadLine());
        Console.WriteLine("Saisir C : ");
        numC = int.Parse(Console.ReadLine());

        classer(numA, numB, numC, ref numA, ref numC, ref numB);
        Console.WriteLine(numA + " <= " + numC + " <= " + numB);
    }
}



