using System;
using System.IO;

class Exercice_1
{
    static void Main()
    {
        int y = 0,w = 0,f = 0,j = 0; 
        string ligne;
        string[] temp;

        temp = new string[4];

        Console.WriteLine("Numéro\tNom\tPrénom\tClasse");
        Console.WriteLine("-----------------------------");
        if(File.Exists("Passagers.csv"))
        {
            FileStream fs = new FileStream("Passagers.csv",FileMode.Open, FileAccess.Read);
            StreamReader Passagers = new StreamReader(fs);
            while (!Passagers.EndOfStream)
            {
                ligne = Passagers.ReadLine();  
                temp = ligne.Split(";");
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write(temp[i] + " ");
                }
                Console.WriteLine("\n");
                switch (temp[3])
                {
                    case "Y":
                        y++;
                        break;
                    case "W":
                        w++;
                        break;
                    case "F":
                        f++;
                        break;
                    case "J":
                        j++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Classe Y --> " + y);
            Console.WriteLine("Classe W --> " + w);
            Console.WriteLine("Classe J --> " + j);
            Console.WriteLine("Classe F --> " + f);
            Passagers.Close();
        }
        else
        {
            Console.WriteLine("Fichier n'existe pas");
        }
    }
}