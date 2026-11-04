using System;
using System.Text;


class Exercice_6
{
    static void Main()
    {
        //Declaration des constantes
        
        //Declaration des variables
        int nombre = 1000, minimum = 1000;

        //Saisie
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Saisir 10 nombres :");
            nombre = int.Parse(Console.ReadLine());
            //calculs
            if (nombre < minimum)
            {
                minimum = nombre;
            }

        }

        //Calculs

        //Affichage
        Console.WriteLine("Le nombre minimum est : " + minimum);

    }
}

