using System;

class Exercice_2
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
            Console.WriteLine("note Inseré");
        }
    }
    static void Main()
    {
        Etudiant etu1;
        float noteInsert;

        etu1 = new Etudiant("Einstein", "Albert", 3);
        afficherEtudiant(etu1);
        for (int i = 0; i < etu1.notes.Length; i++)
        {
            Console.Write("Inserer une note : ");
            noteInsert = float.Parse(Console.ReadLine());
            ajouterNotes(ref etu1,noteInsert);
            afficherEtudiant(etu1);
        }
    }
}