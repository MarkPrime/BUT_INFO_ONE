using System;
using System.Text;

class Exercice_15
{
    static void Main()
    {
        int salaire;
        int moinsDeTravail;
        int arretDeTravail;

        float prime;
        int nombreSalarie;

        while (true)
        {
            Console.WriteLine("Saisir salaire : ");
            salaire = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le nombre des moins travallé : ");
            moinsDeTravail = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le nombre des jours d'arret : ");
            arretDeTravail = int.Parse(Console.ReadLine());

            if (moinsDeTravail > 10) // si les moins de travail sont plus que 10 moins
            {
                prime = salaire;
            }
            else 
            {
               prime = (float)salaire * moinsDeTravail / 12f;
            }
            
            if (arretDeTravail > 10) // si les jours d'arret sont plus que 10 jours 
            {
                prime = prime * 0.25f;
            }
            else if (arretDeTravail <= 10 && arretDeTravail > 3)
            {
                prime = prime * 0.50f;
            }
            else
            {
                prime = prime * 2;   
            }
            for (int i = 0; i < nombreSalarie; i++)
            {
                Console.WriteLine("S : " + salaire + " M : " + moinsDeTravail + " T : " + arretDeTravail + " Prime : " + prime);
            }
        }
    }
}