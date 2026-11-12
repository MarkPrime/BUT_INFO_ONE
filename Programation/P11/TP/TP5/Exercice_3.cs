using System;

class Exercice_3
{
    static void Main()
    {
        int[,] tab  = {
            {2,7,6},
            {9,5,1},
            {4,3,8}};
        bool res = false;

        res = estUnCarreMagique(tab);

        if (res == true)
        {
            Console.WriteLine("est un carré magique");
        }
        else
        {
            Console.WriteLine("n'est pas un carré magique");
        }
    }

    static bool estUnCarreMagique(int[,] tab)
    {
        const int VAL = 15;
        int sommeLC = 0;
        int sommeD1 = 0;
        int sommeD2 = 0;
        int D2 = tab.GetLength(0) - 1;
 
        for (int a = 0; a < tab.GetLength(0); a++)
        {
            sommeD1 = sommeD1 + tab[a,a];
            sommeD2 = sommeD2 + tab[a,D2];
            for (int b = 0; b < tab.GetLength(1); b++)
            {
                sommeLC = sommeLC + tab[a,b];
            }
            if (sommeD1 == VAL)
            {
                sommeLC = 0;
            }
            D2 = D2 - 1;
        }
        if (sommeLC > 0 || sommeD1 != VAL || sommeD2 != VAL)
        {
            return false;
        }
        return true;
    }
}