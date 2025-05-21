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
}

