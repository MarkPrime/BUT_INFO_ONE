using System;
using System.Text;

class Exercice_2
{
    static void afficherTableMult(int number)
    {
        int result;

        for (int i = 0; i < 11; i++)
        {
            result = i * number;
            Console.WriteLine(i + "X" + number + "=" + result);
        }
    }
    static void Main()
    {
        int numbre;

        Console.WriteLine("Saisir un nombre : ");
        numbre = int.Parse(Console.ReadLine());

        afficherTableMult(numbre);
    }
}