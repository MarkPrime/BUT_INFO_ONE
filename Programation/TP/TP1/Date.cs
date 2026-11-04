using System;
using System.Text;

class Date
{
    static void Main()
    {
        //Declaration des constantes

        //Declaration des variables
        int jour, mois, annee;

        //Saisir
        while (true)
        {   
            Console.Write("Saisir le jour : "); // Demander à l'utilisateur de saisir le jour
            jour = int.Parse(Console.ReadLine());
            Console.Write("Saisir le mois : "); // Demander à l'utilisateur de saisir le mois
            mois = int.Parse(Console.ReadLine());
            Console.Write("Saisir l'année : "); // Demander à l'utilisateur de saisir l'année
            annee = int.Parse(Console.ReadLine());
            if (jour < 1 || jour > 31 || mois < 1 || mois > 12 || annee < 1901 || annee > 2038) // Vérifier si la date est valide
            {
                Console.WriteLine("Veuillez saisir une date valide"); // Afficher un message d'erreur si la date est invalide
                continue; // Recommencer la saisie
            }
            else
            {
                break; // Sortir de la boucle si la date est valide
            }
        }


        //Calculs

        //Affichage
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Date : " + jour + "/" + mois + "/" + annee); // Afficher la date saisie par l'utilisateur
        Console.WriteLine("Annee bissextile : " + (annee % 4 == 0 && (annee % 100 != 0 || annee % 400 == 0) ? "Oui" : "Non")); // Vérifier si l'année est bissextile
    }
}
