using System;

class Exercice_1()
{
    static void Main()
    {
        List<int> list;
        Random rdm;
        int num;

        list = new List<int>();

        for (int i = 0; i <= 50; i++)
        {
            rdm = new Random();
            num = rdm.Next(0,101);
            list.Add(num);
        }
        list.Sort();
        
        foreach (int element in list)
        {
            Console.WriteLine(element);
        }

    }
}