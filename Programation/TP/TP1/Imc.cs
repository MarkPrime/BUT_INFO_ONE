using System;
using System.Text;

class Imc
{
    static void Main()
    {
        //Declaration des constantes

        //Declaration des variables
        int niveauImc;
        double imc, poids, taille;

        //Saisir
        while (true)
        {
            Console.Write("Saisir le poids (kg) : "); // Demander à l'utilisateur de saisir son poids
            poids = double.Parse(Console.ReadLine());
            Console.Write("Saisir la taille (cm) : "); // Demander à l'utilisateur de saisir sa taille
            taille = double.Parse(Console.ReadLine());
            if (poids <= 0 || taille <= 150 || taille > 210) // Vérifier si le poids et la taille sont valides
            {
                Console.WriteLine("Veuillez saisir un poids et une taille valides"); // Afficher un message d'erreur si le poids ou la taille est invalide
                continue; // Recommencer la saisie
            }
            else
            {
                break; // Sortir de la boucle si le poids et la taille sont valides
            }
        }

        //Calculs
        imc = poids / (taille / 100 * taille / 100);


        //Affichage
        if (imc < 16.5) // Vérifier si l'IMC est inférieur à 16.5
        {
            niveauImc = -2;
        }
        else if (imc >= 16.5 && imc < 18.5)
        {
            niveauImc = -1;
        }
        else if (imc >= 18.5 && imc < 25)
        {
            niveauImc = 0;
        }
        else if (imc >= 25 && imc < 30)
        {
            niveauImc = 1;
        }
        else if (imc >= 30 && imc < 35)
        {
            niveauImc = 2;
        }
        else if (imc >= 35 && imc < 40)
        {
            niveauImc = 3;
        }
        else
        {
            niveauImc = 4;
        }

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("IMC : " + imc);
        Console.WriteLine("Niveau : " + niveauImc);
    }
}
