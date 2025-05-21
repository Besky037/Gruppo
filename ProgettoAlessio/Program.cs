
using System;

public class Corso

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

        nomeCorso = n;
        durataOre = du;
        docente = doc;
        studenti = s;
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

