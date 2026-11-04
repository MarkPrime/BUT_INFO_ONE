using System;
using System.Text;


class Table
{
    static void Main()
    {
        //Declaration des constantes
        const int TABLE_LIMIT = 10;

        //Declaration des variables
        int nombre, nbTable, res;

        //Saisie
        Console.WriteLine("Saisir nombre");
        nombre = int.Parse(Console.ReadLine());

        //Calculs
        for (nbTable = 0; nbTable <= TABLE_LIMIT; nbTable++)
        {
            res = nbTable * nombre;
            Console.WriteLine(nbTable + "X" + nombre + "=" + res);
        }
        //Affichage

    }
}