using System;
using System.Text;



class Exercice_8
{
    static void permuter(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void Main()
    {
        int a; 
        int b;

        Console.WriteLine("Saisir nombre a : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Saisir nombre b : ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine(a + " " + b);
        permuter(ref a, ref b);
        Console.WriteLine(a + " " + b);
    }
}