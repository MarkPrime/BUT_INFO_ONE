using System;
using System.Text;


class Boutelle
{
    static void Main()
    {
        //Declaration des constantes
        const double PRIX_UNTAIRE = 0.57;
        const double TAUX_LIVRAISON = 0.15;
        
        //Declaration des variables
        string nomClient;
        int nbBouteilles;
        double montant, livraison, total;

        //Saisie
        Console.Write("Saisir le nom du client : ");
        nomClient = Console.ReadLine();
        Console.Write("Saisir le nombre de bouteilles : ");
        nbBouteilles = int.Parse(Console.ReadLine());

        //Calculs
        montant = nbBouteilles * PRIX_UNTAIRE;
        livraison = montant * TAUX_LIVRAISON;
        total = montant + livraison;

        //Affichage
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Client : " + nomClient);
        Console.WriteLine("Prix unitaire : " + PRIX_UNTAIRE + " €\n");
        Console.WriteLine("Montant : " + montant + " €");
        Console.WriteLine("Livraison (" + TAUX_LIVRAISON * 100 + "%) : " + livraison + " €\n");
        Console.WriteLine("Total : " + total + " €");
    }
}

