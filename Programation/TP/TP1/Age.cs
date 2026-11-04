using System;
using System.Text;

class Age
{
    static void Main()
    {
        //Declaration des constantes

        //Declaration des variables
        double age;
        
        
        while (true)
        {
            //Saisir
            Console.Write("Saisir l'âge : "); // Demander à l'utilisateur de saisir son âge
            age = double.Parse(Console.ReadLine());
            if (age < 0 || age > 122) // Vérifier si l'âge est valide
            {
                Console.WriteLine("Veuillez saisir un âge valide (0-122)."); // Afficher un message d'erreur si l'âge est invalide
                continue; // Recommencer la saisie
            }
            else
            {   
                if (age > 122) // L'âge maximum enregistré est de 122 ans
                {
                    Console.WriteLine("L'âge ne peut pas dépasser 122 ans.");
                    return;
                }
                else if (age < 0) // Vérifier si l'âge est négatif
                {
                    Console.WriteLine("L'âge ne peut pas être négatif.");
                    return;
                }
                else if (age < 18) // Vérifier si l'âge est inférieur à 18 ans
                {
                    Console.WriteLine("Vous êtes mineur.");
                }
                else if (age >= 18 && age < 65) // Vérifier si l'âge est compris entre 18 et 65 ans
                {
                    Console.WriteLine("Vous êtes majeur.");
                }
                else
                {
                    Console.WriteLine("Vous êtes senior.");
                }
                break; // Sortir de la boucle si l'âge est valide
            }
        }

        //Affichage
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Âge : " + age + " ans"); // Afficher l'âge saisi par l'utilisateur
    }
}
