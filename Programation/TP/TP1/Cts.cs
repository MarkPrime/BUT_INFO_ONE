using System;
using System.Text;

class Cts
{
    static void Main()
    {
        //Declaration des constantes
        const int CANTITER_TICKETS = 10;
        const double PRIX_SUPPORT = 0.20;
        const double TAUX_TVA = 0.10;

        //Declaration des variables
        double prixTicketHt, supportHt, MontantOne, MontantTva, prixTotal;

        //Saisir
        Console.Write("Saisir le prix du ticket TTC (€) : ");
        prixTotal = double.Parse(Console.ReadLine());

        //Calculs
        supportHt =  PRIX_SUPPORT - (PRIX_SUPPORT * TAUX_TVA);
        MontantTva = prixTotal - (prixTotal * TAUX_TVA);
        MontantOne = MontantTva / CANTITER_TICKETS;
        //Affichage
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Support : " + supportHt + " € HT");
        Console.WriteLine("Ticets : " + CANTITER_TICKETS + "x" + MontantOne + " € = " + MontantTva + " €");
        Console.WriteLine("Montant : TVA (" + TAUX_TVA * 100 + "%) :" + MontantTva  + " €");
        Console.WriteLine("Prix total : " + prixTotal + " €"); 

    }
}
