using System;

public class Corso
{
    public string nomeCorso;
    public int durataOre;
    public string docente;
    protected List<string> studenti;

    public Corso(string n, int du, string doc, List<String> s)
    {
        nomeCorso = n;
        durataOre = du;
        docente = doc;
        studenti = s;
    }
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
}

public class CorsoMusica : Corso
{
    public string strumento;

    public CorsoMusica(string nomeCorso, int durataOre, string docente, List<string> studenti, string str) : base(nomeCorso, durataOre, docente, studenti)
    {
        strumento = str;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Strumento: {strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {strumento}");
    }
}


