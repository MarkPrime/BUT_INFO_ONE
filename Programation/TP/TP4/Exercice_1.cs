using System;
using System.Text;


class Exercice_1
{
    static void Main()
    {
        const double RECHERCHE = 6.5;
        double plusPetit;
        int calc;
        int calc2;
        int calc3;
        int nbNombres;
        double exsist;
        double somme;
        double moyenne;    
        double[] lesNotes = {11, 12.5, 11, 10, 6.5, 9.5, 15, 10, 15, 14, 17, 2};
        plusPetit = lesNotes[0];
        
        for (int i = 0; i < lesNotes.Length; i++)
        {
            Console.WriteLine(lesNotes[i]);//b1
        }
        calc = 0;

        while (calc < lesNotes.Length)
        {
            if (lesNotes[calc] <= plusPetit)
            {
                plusPetit = lesNotes[calc];
            }
            calc++;
        }
        //Console.WriteLine(plusPetit); // b2
        calc2 = 0;
        nbNombres = 0;
        somme = 0;
        moyenne = 0;

        while (calc2 < lesNotes.Length)
        {
            if (lesNotes[calc2] > 10)
            {
                nbNombres++;
                somme = somme + lesNotes[calc2];
                moyenne = somme / nbNombres;
            }
            calc2++;
        }
        //Console.WriteLine(moyenne);// b3
        exsist = 0;
        calc3 = 0;

        while (calc3 < lesNotes.Length)
        {
            if (lesNotes[calc3] == RECHERCHE)
            {
                exsist = lesNotes[calc3];
            }
            calc3++;
        }
        if (exsist != 0)
        {
            Console.WriteLine("Il exite le numero : " + exsist);
        }
        else
        {
            Console.WriteLine("Le nombre n'existe pas");
        }
    }
}