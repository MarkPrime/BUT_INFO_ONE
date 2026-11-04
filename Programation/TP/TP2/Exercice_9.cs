using System;
using System.Text;


class Exercice_9
{
    static void Main()
    {   
        const int ESAYS = 10; //Constant numero d'essays

        int num, nbAl;

        System.Random random = new System.Random();
        nbAl = random.Next(101);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Saisir un nombre :");
            num = int.Parse(Console.ReadLine());
            
            
            if (num < nbAl)
            {
                Console.WriteLine("Trop petit");
            }
            else if (num > nbAl)
            {
                Console.WriteLine("Trop grand");
            }
            else
            {
                Console.WriteLine("Bravo, trouvé en " + i + " coups");
                break;
            }
            if (i == 10)
            {
                Console.WriteLine("Dommage le nombre à trouver était "+ nbAl);
            }
        }
    }
}