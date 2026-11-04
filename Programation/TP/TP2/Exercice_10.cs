using System;
using System.Text;


class Exercice_10
{
    static void Main()
    {

        int number, unites, dizaine, centaine, arm, somme, numTr;

        number = 1;
        arm = 0;
        numTr = 0;
        for (number = 1; number <= 1000; number++)
        {
            unites = number % 10;
            dizaine = (number / 10) % 10;
            centaine = number / 100;
            //Console.WriteLine(number + "_" + centaine + " " + dizaine + " " + unites);
            unites = unites * unites * unites;
            dizaine = dizaine * dizaine * dizaine;
            centaine = centaine * centaine * centaine;
            //Console.WriteLine(number + "_" + centaine + " " + dizaine + " " + unites);
            somme = unites + dizaine + centaine;
            if (somme == number && somme > 2 && somme < 999)//si le numbre est Arm
            {
                arm = number;
                Console.WriteLine("nombre Arm : " + arm);
                numTr = numTr + 1;
                if (numTr == 4)
                {
                    Console.WriteLine("Trouvee tout les 4 numbres");
                }
            }
        }
    }
}