using System;
using System.Text;


class Exercice_4
{
    static void Main()
    {
        const int TALLE = 8;
        int mod;
        int[] code;
        int number;

        code = new int[TALLE];

        Console.WriteLine("Saisir un nombre :");
        number = int.Parse(Console.ReadLine());

        if (number > 0 && number < 256)
        {
            for (int i = TALLE - 1; i >= 0; i = i - 1)
            {
                mod = number % 2;
                number = number / 2;
                code[i] = mod;
                Console.Write(code[i] + " ");
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("Numero doit etre entre 0 et 255");
        }
    }
}