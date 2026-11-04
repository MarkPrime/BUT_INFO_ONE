using System;
using System.Text;

class Exercice_19
{
    static void Main()
    {
        const decimal CENTIME10 = 0.1m;
        const decimal CENTIME20 = 0.2m;
        const decimal CENTIME50 = 0.5m;
        const decimal EURO1 = 1m;
        const decimal EURO2 = 2m;
        const decimal PRIX = 0.4m;
        const char O = 'O';
        const char N = 'N';

        decimal montant;
        decimal montantTotal = 0m;
        decimal rest;
        
        bool isPossible = true;
        bool isPossible3 = true;
        char reponse;

        while (isPossible)
        {
            Console.WriteLine("Insérer le montant de la pièce: ");
            montant = decimal.Parse(Console.ReadLine());
            if (montant == CENTIME10 || montant == CENTIME20 || montant == CENTIME50 || montant == EURO1 || montant == EURO2)
            {
                montantTotal = montantTotal + montant;
            }
            else
            {
                Console.WriteLine("Cette pièce n'est pas acceptée !");
            }
            Console.WriteLine("Insérer une aute pièce ? ");
            reponse = char.Parse(Console.ReadLine());
            if (reponse == N)
            {
                if (PRIX == montantTotal)
                {
                    Console.WriteLine("Distribution en cours...");
                    isPossible = false;
                }
                else if (montantTotal < PRIX)
                {
                    Console.WriteLine("Le montant insufisant AJOUTER");
                }
                else
                {
                    Console.WriteLine("Distribution en cours... Je rends : ");
                    
                    rest = montantTotal - PRIX;
                    while(isPossible3)
                    {
                        if (rest > EURO2)
                        {
                            rest = rest - EURO2;
                            Console.WriteLine("1 Pièce(s) de 2 euro");
                        }
                        else if (rest > EURO1)
                        {
                            rest = rest - EURO1;
                            Console.WriteLine("1 Pièce(s) de 1 euro");
                        }
                        else if (rest > CENTIME50)
                        {
                            rest = rest - CENTIME50;
                            Console.WriteLine("1 Pièce(s) de 50 centimes");
                        }
                        else if (rest > CENTIME20)
                        {
                            rest = rest - CENTIME20;
                            Console.WriteLine("1 Pièce(s) de 20 centimes");

                        }
                        else if (rest >= CENTIME10)
                        {
                            rest = rest - CENTIME10;
                            Console.WriteLine("1 Pièce(s) de 10 centimes");
                        }
                        else
                        {
                            isPossible3 = false;
                        }
                    }
                    isPossible = false;
                }
            }
            else if(reponse == O)
            {
                isPossible = true;
            }
            else
            {
                Console.WriteLine("[O]Oui ou [N]Non");
            }
        }
    }
}