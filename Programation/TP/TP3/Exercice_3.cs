using System;
using System.IO.Pipelines;
using System.Text;

class Exercice_3
{
    static int heureVersMin(int heure, int minutes)
    {
        const int MINUTES = 60;

        int result;

        if (minutes < 60 && heure > -1 && minutes > -1)
        {
            result = heure * MINUTES + minutes;
        }
        else
        {
            return -1;
        }

        return result;
    }
    static void Main()
    {
        int heure;
        int minute;
        int result;

        heure = 1;
        minute = 59;

        result = heureVersMin(heure,minute);
        Console.WriteLine(heure + ":" + minute + " correspondent a " + result + " minutes.");
    }
}