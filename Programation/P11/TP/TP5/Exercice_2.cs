using System;

class Exercice_2
{
    static void Main()
    {
        int[,] tab;
        char SP = ' ';
        tab = new int[10,10];

        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int a = 0; a < tab.GetLength(1); a++)
            {
                tab[i,a] = 0;
                tab[i,0] = 1;
                tab[i,i] = 1;
            }
        }
        for (int f = 1; f < tab.GetLength(0); f++)
        {
            for (int g = 1; g < tab.GetLength(1); g++)
            {
                tab[f,g] = tab[f-1,g] + tab[f-1, g-1];
            }
        }


        for (int b = 0; b < tab.GetLength(0); b++)
        {
            for (int c = 0; c < tab.GetLength(1); c++)
            {
                if (tab[b,c] == 0)
                {
                    
                }
                else
                {
                    Console.Write(tab[b,c] + " ");
                }
            }
            Console.Write("\n");
        }
    }
}