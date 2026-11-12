using System;
using System.Text;

class Exercice_1
{
    static void afficherHeure(int minutes)
    {
        const int HEURE = 60;
        int heureA;
        int minuteA;

        heureA = (int)(minutes/HEURE);
        minuteA = minutes % HEURE;
        Console.WriteLine(heureA + ":" + minuteA);
    }
    static void Main()
    {
        int number;

        number = 130;
        
        afficherHeure(number);
        
    }
}