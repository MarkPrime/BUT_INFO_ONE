using System;
using System.Text;


class Exercice_6
{
    static void Main()
    {
        int[] tab;

        tab = new int[10];

        int numero;
        int indice = 0; 
        int choix;
        int nbNumbs = 0;
        int nbIndice;
        bool exit = true;

        while (exit)
        {
            Console.Write("1 -- Afficher tableau\n2 -- Insérer un nombre\n3 -- Quiter\n");
            Console.WriteLine("Saisir une opption : ");
            choix = int.Parse(Console.ReadLine());
            if (choix == 1)
            {
                Console.WriteLine("nbNumbs" + nbNumbs);
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine(i + " : " + tab[i]); // montrer le table 
                }
            }
            else if (choix == 2)
            {
                Console.WriteLine("Saisir un nombre : ");
                numero = int.Parse(Console.ReadLine());

                if (nbNumbs == tab.Length) // verification si tableau est rempli!
                {
                    Console.WriteLine("Le tableau est rempli!!!!\n");
                }
                else if (nbNumbs >= 1) // si dans le tableau ya plus que 1 numbre
                {
                    indice = 0;
                    while (tab[indice] < numero && indice < nbNumbs) //verifie de 0 a nombre des nombres si insice inferieur du  numero
                    {
                        indice++;
                    }
                    if (indice < nbNumbs) // si le numero est mois grand que les numeros existantes
                    {
                        nbIndice = indice; // enregistrer le indice pour insertion
                        indice = nbNumbs; // mettre indise sur dernier character
                        while (indice > nbIndice) // verifie si indice est plus grand que indice de insertion
                        {
                            tab[indice] = tab[indice - 1]; // deplacer la derniere valeur sur precedent
                            indice = indice - 1; 
                        }
                        indice = nbIndice;
                        tab[indice] = numero;
                        nbNumbs++;
                    }
                    else // si numero est plus grand que les numeros existants
                    {
                        tab[indice] = numero;
                        nbNumbs++;
                    }
                }
                else if (nbNumbs == 0)
                {
                    tab[indice] = numero;
                    nbNumbs++; 
                }
            }
            else if (choix == 3)
            {
                exit = false;
            }
            else
            {
                Console.WriteLine("Saisir un numero correct!!");
            }
        }
    }
}