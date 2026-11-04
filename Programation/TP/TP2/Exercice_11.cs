using System;
using System.Text;


class Exercice_11
{
    static void Main()
    {
        const char MOTIF = '*';

        char saissie;
        int calc, saissieA;
        double taux, frequance;


        calc = 0;
        saissieA = 0;
        taux = 0;
        frequance = 0;
        while (true)
        {
            Console.WriteLine("Saisir un character");
            saissie = char.Parse(Console.ReadLine());
            calc = calc+1;

            if (saissie == 'a')
            {
                saissieA = saissieA+1;
            }

            frequance = (double)saissieA / calc;
            taux = frequance * 100;
            if (saissie == MOTIF)
            {
                Console.WriteLine("Vous avez saissie *");
                Console.WriteLine("Frequence de saissie a : " + frequance);
                Console.WriteLine("Taux de a saisie : " + taux + "%");
                break;    
            } 
        }
    }
}