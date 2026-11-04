using System;


class Exercice_4
{
    static void Main()
    {
        int[,] tab;
        int nb;
        int indiceLigne = 0;
        int indiceColonne = 0;
        bool estRempli = true;


        tab = new int[5,5];
        while (estRempli)
        {
            Console.WriteLine("Saisir une valeur");
            nb = int.Parse(Console.ReadLine());

            for (int a = 0; a < tab.GetLength(0); a++)
            {
                for (int b = 0; b < tab.GetLength(1); b++)
                {
                    tab[a,b] = nb;
                    Console.Write(tab[a,b] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}