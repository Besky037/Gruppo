<<<<<<< Updated upstream
﻿public class Corso
=======
﻿using System;
using System.Globalization;

public class Corso
>>>>>>> Stashed changes
{
    public string nomeCorso;
    public int durataOre;
    public string docente;
    protected List<string> studenti;

    public override string ToString()
    {
        return $"Nome Corso:{nomeCorso} Durata Ore:{durataOre} Docente: {docente}";
    }

    public void AggiungiStudente(string nomeStudente)
    {
        studenti.Add(nomeStudente);
    }

    public virtual void MetodoSpeciale()
    {

    }

    public Corso(string n, int du, string doc, List<string> s)
    {
<<<<<<< Updated upstream
        
=======
        nomeCorso = n;
        durataOre = du;
        docente = doc;
        studenti = s;
>>>>>>> Stashed changes
    }
}

public class CorsoPittura : Corso
{
    public string tecnica;

    public CorsoPittura(string n, int du, string doc, List<string> s, string t) : base(n, du, doc, s)
    {
        tecnica = t;
    }

    public override string ToString()
    {
        return $"Nome Corso:{nomeCorso} Durata Ore:{durataOre} Docente: {docente}, Tecnica: {tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su tela con tecnica: {tecnica}");
    }
}
<<<<<<< Updated upstream
=======


class Program
{
    static void Main(string[] args)
    {
        bool x = true;
        do
        {
            int scelta = 0;

            switch (scelta)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;
            }
        }
        while (x);

    }
}


>>>>>>> Stashed changes
