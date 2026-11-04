using System;
using System.Text;

class Terrain
{
    static void Main()
    {
        //Declaration des constantes

        //Declaration des variables
        double surface, largeur, longueur;

        //Saisir
        Console.Write("Saisir la largeur (m) : ");
        largeur = double.Parse(Console.ReadLine());
        Console.Write("Saisir la longueur (m) : ");
        longueur = double.Parse(Console.ReadLine());

        //Calculs
        surface = largeur * longueur;

        //Affichage
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Surface : " + surface);
    }
}
