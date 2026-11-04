using System;

class Exercice_1
{
    static void Main()
    {
        int[,] tab = {{52,17,54,5,99,81,79,90,39,46},
        {91,77,90,76,72,31,38,10,82,62},
        {48,18,13,38,2,85,67,18,67,28},
        {14,65,9,76,56,86,84,10,75,16},
        {18,87,17,65,98,88,45,31,14,21},
        {38,55,76,75,10,33,3,16,3,14},
        {14,61,23,11,31,25,68,14,19,85},
        {47,27,35,66,43,61,1,48,39,13},
        {40,36,3,46,89,59,89,33,65,22},
        {83,67,6,61,2,57,64,5,34,73}};

        int min = tab[0,0];
        int max = tab[0,0];
        int moy;
        int nbNumbs = 0;
        int somme = 0;
        int nbNumbsL = 0;
        int sommeL = 0;
        int moyL;
        /*for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int a = 0; a < tab.GetLength(1); a++)
            {
                Console.Write(tab[i,a] + ",");
            }
            Console.WriteLine("\n");
        }*/


        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int a = 0; a < tab.GetLength(1); a++)
            {
                if (tab[i,a] < min)
                {
                    min = tab[i,a];
                }
                else if(tab[i,a] > max)
                {
                    max = tab[i,a];
                }
                somme = somme + tab[i,a];
                nbNumbs++;
                sommeL = sommeL + tab[i,a];
                nbNumbsL++;
                
            }
            
            moyL = sommeL/nbNumbsL;
            sommeL = 0;
            Console.WriteLine("moyenneL : " + moyL);
            nbNumbsL=0;
        }
        moy = somme/nbNumbs;
        Console.WriteLine("min : " + min);
        Console.WriteLine("max : " + max);
        Console.WriteLine("moyenne : " + moy);
    }
}