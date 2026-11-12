using System;
using System.Globalization;

class Exercice_3
{
    struct Etudiant
    {
        public string nom;
        public string prenom;
        public int groupe;
        public float[] notes;
        public float moyenne;
        public int nbNotes;
        public Etudiant(string nm, string pn, int gr)
        {
            nom = nm;
            prenom = pn;
            groupe = gr;
            notes = new float[6];
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = 0;
            }
            moyenne = 0;
            nbNotes = 0;
        }
    }
    static void afficherEtudiant(Etudiant etu)
    {
        Console.WriteLine("Etudiant(e): " + etu.nom + " " + etu.prenom + " Groupe " + etu.groupe);
        Console.Write("notes : < ");
        for (int i = 0; i < etu.notes.Length; i++)
        {
            Console.Write($"{etu.notes[i]:F2} ");
        }
        Console.Write(" > " + " moyenne " + etu.moyenne + "(" + etu.nbNotes + " notes reseignées).\n");
    }
    static void ajouterNotes(ref Etudiant etu, float note)
    {
        float somme = 0;

        if (etu.nbNotes == etu.notes.Length)
        {
            Console.WriteLine($"tableau {nameof(etu.notes)} est rempli");
        }
        else
        {
            etu.notes[etu.nbNotes] = note;
            etu.nbNotes++;
            for (int i = 0; i < etu.nbNotes; i++)
            {
                somme += etu.notes[i];
            }
            etu.moyenne = somme / etu.nbNotes;
        }
    }
    static void afficherMajor(Etudiant etu, float moy, int i)
    {
        Console.WriteLine("Major de l'UE " + i + " : " + etu.nom + etu.prenom + " (groupe " + etu.groupe + ") avec une moyenne de " + moy + "/20.");  
    }
    static void Main()
    {
        string[] temp;
        string ligne;
        float[] noteInsert;
        float moyGroupePr = 0;
        int nbEtuGrPr = 0;
        float sommeGrPr = 0;
        float moyGroupeSc = 0;
        int nbEtuGrSc = 0;
        float sommeGrSc = 0;
        float moyMajor = 0;
        int nbEtu = 0;
        float ue1 = 0;
        float ue2 = 0;
        float ue3 = 0;
        float ue4 = 0;
        float ue5 = 0;
        float ue6 = 0;
        Etudiant etudiant;
        Etudiant[] etudiantMajor;

        noteInsert = new float[6];
        etudiantMajor = new Etudiant[6];
        temp = new string[11];

        if (File.Exists("Promotion.csv"))
        {
            FileStream file = new FileStream("Promotion.csv",FileMode.Open,FileAccess.Read);
            StreamReader Etudiants = new StreamReader(file);
            while (!Etudiants.EndOfStream)
            {
                ligne = Etudiants.ReadLine();
                temp = ligne.Split(";");
                etudiant = new Etudiant(temp[0],temp[1],Convert.ToInt32(temp[2]));
                for (int a = 0; a < noteInsert.Length; a++)
                {
                    noteInsert[a] = float.Parse(temp[a + 3], CultureInfo.GetCultureInfo("fr-FR"));
                    ajouterNotes(ref etudiant, noteInsert[a]);
                }
                switch (temp[2])
                {
                    case "1":
                        nbEtuGrPr++;
                        sommeGrPr += etudiant.moyenne;
                        break;
                    case "2":
                        nbEtuGrSc++;
                        sommeGrSc += etudiant.moyenne;
                        break;
                    default:
                        break;
                }
                moyGroupePr = sommeGrPr / nbEtuGrPr;
                moyGroupeSc = sommeGrSc / nbEtuGrSc;
                
                afficherEtudiant(etudiant);
                Console.WriteLine("\n");
                nbEtu++;
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Moyenne de Groupe 1 : " + moyGroupePr);
            Console.WriteLine("Moyenne de Groupe 2 : " + moyGroupeSc);
            Console.WriteLine("------------------------------------");
            for (int f = 0; f < etudiantMajor.Length; f++)
            {
                afficherMajor(etudiantMajor[f], moyMajor, f);
            }
            Etudiants.Close();
        }
        else
        {
            Console.WriteLine("Fichier Introuvable");
        }
    }
}