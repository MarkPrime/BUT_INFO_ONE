using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

class Exercice_3
{
    static List<int> fusionner(List<int> lst1, List<int> lst2)
    {
        List<int> listFinal;
        listFinal = new List<int>();
        int counter = 0;

        for (int i = 0; i < lst1.Count; i++)
        {
            for (int j = 0; j < lst2.Count; j++)
            {
                if (lst1[i] < lst2[j] && listFinal.Contains(lst1[i]) == false)
                {
                    listFinal.Add(lst1[i]);
                    counter++;
                }
                else if (lst1[i] > lst2[j] && listFinal.Contains(lst2[j]) == false)
                {
                    listFinal.Add(lst2[j]);
                    counter++;
                }
            }
            if (!listFinal.Contains(lst1[i]))
            {
                listFinal.Add(lst1[i]);
            }
        }
        return listFinal;
    }

    static void Main()
    {
        List<int> lst1;
        lst1 = new List<int>();
        List<int> lst2;
        lst2 = new List<int>();
        List<int> lstF;
        lstF = new List<int>();

        lst1.Add(2);
        lst1.Add(3);
        lst1.Add(4);
        lst1.Add(9);
        lst2.Add(1);
        lst2.Add(5);
        lst2.Add(6);
        lst2.Add(7);
        lst2.Add(8);

        lstF = fusionner(lst1, lst2);

        foreach (int item in lstF)
        {
            Console.Write(item + " ");   
        }
    }
}