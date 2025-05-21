using System;

public class Corso
{
    //Definizione delle proprietà fondamentali dei corsi
    public string nomeCorso;
    public int durataOre;
    public string docente;
    protected List<string> studenti;

    /// <summary>
    /// Costruttore della classe corso per generare tutti gli oggetti della classe
    /// </summary>
    /// <param name="n"></param>
    /// <param name="du"></param>
    /// <param name="doc"></param>
    /// <param name="s"></param>
    public Corso(string n, int du, string doc, List<String> s)
    {
        nomeCorso = n;
        durataOre = du;
        docente = doc;
        studenti = s;
    }

    /// <summary>
    /// Override del metodo della classe object toString() per la classe corsi
    /// </summary>
    /// <returns>Restituisce la descrizione del corso</returns>
    public override string ToString()
    {
        return $"Nome Corso:{nomeCorso} Durata Ore:{durataOre} Docente: {docente}";
    }

    /// <summary>
    /// Metodo della classe Corso per aggiungere il nome degli studenti del corso nella lista studenti
    /// </summary>
    /// <param name="nomeStudente"></param>
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
    //Definizione della proprietà aggiuntiva strumento
    public string strumento;

    /// <summary>
    /// Costruttore della classe figlia CorsoMusica che prende si basa sulle proprietà della classe padre Corso
    /// + lo strumento
    /// </summary>
    /// <param name="nomeCorso"></param>
    /// <param name="durataOre"></param>
    /// <param name="docente"></param>
    /// <param name="studenti"></param>
    /// <param name="str"></param>
    public CorsoMusica(string nomeCorso, int durataOre, string docente, List<string> studenti, string str)
    : base(nomeCorso, durataOre, docente, studenti)
    {
        strumento = str;
    }

    /// <summary>
    /// Override del metodo ToString() per stampare oltre al ToString Base della classe padre anche lo strumento
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{base.ToString()} Strumento: {strumento}";
    }

    /// <summary>
    /// Metodo che stampa un testo speciale per ogni classe figlia in questo caso stampa che 
    /// si terrà una prova pratica dello strumento del corso
    /// </summary>
    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {strumento}");
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
        return $"{base.ToString()} Tecnica: {tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su tela con tecnica: {tecnica}");
    }
}

public class CorsoDanza : Corso
{
    public string stile;

    public CorsoDanza(string nomeCorso, int durataOre, string docente, List<string> studenti, string stil)
    : base(nomeCorso, durataOre, docente, studenti)
    {
        stile = stil;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Stile: {stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografica nello stile: {stile}");
    }
}


public class Program
{
    public static void Main()
    {
        List<Corso> corsiPresenti = new List<Corso>();
        bool x = true;

        do
        {
            Console.WriteLine("Benvenuto nel Menu");
            Console.WriteLine("1.Aggiungi un Corso di Musica\n2.Aggiungi un corso di Pittura\n3.Aggiungi un corso di Danza\n4.Aggiungi studente a un corso\n5.Visualizza tutti i corsi\n6.Cerca Corsi per nome docente\n7.Esegui Metodo Speciale di un corso\n0.Esci");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    corsiPresenti.Add(AggiungiCorso(1));
                    break;
                case 2:
                    corsiPresenti.Add(AggiungiCorso(2));
                    break;
                case 3:
                    corsiPresenti.Add(AggiungiCorso(3));
                    break;
                case 4:
                    SelezionaCorso(corsiPresenti, 4);
                    break;
                case 5:
                    StampaCorsi(corsiPresenti);
                    break;
                case 6:
                    Ricerca(corsiPresenti);
                    break;
                case 7:
                    SelezionaCorso(corsiPresenti, 7);
                    break;
                case 0:
                    x = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
        while (x);
    }

    public static Corso AggiungiCorso(int scelta)
    {
        List<string> studenti = new List<string>();

        Console.Write("Inserisci il nome del corso: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci il durata ore: ");
        int ore = int.Parse(Console.ReadLine());

        Console.Write("Inserisci il nome del docente del corso: ");
        string docente = Console.ReadLine();

        if (scelta == 1)
        {
            Console.Write("Inserisci lo strumento del corso: ");
            string strumento = Console.ReadLine();

            return new CorsoMusica(nome, ore, docente, studenti, strumento);
        }
        else if (scelta == 2)
        {
            Console.Write("Inserisci la tecnica del corso: ");
            string tecnica = Console.ReadLine();

            return new CorsoPittura(nome, ore, docente, studenti, tecnica);
        }
        else if (scelta == 3)
        {
            Console.Write("Inserisci lo stile del corso: ");
            string danza = Console.ReadLine();

            return new CorsoDanza(nome, ore, docente, studenti, danza);
        }
        return null;
    }

    public static void StampaCorsi(List<Corso> corsiPresenti)
    {
        int count = 0;
        foreach (Corso c in corsiPresenti)
        {
            Console.WriteLine($"[{count}] {c}");
            count++;
        }
    }

    public static void SelezionaCorso(List<Corso> corsiPresenti, int daje)
    {
        StampaCorsi(corsiPresenti);
        Console.Write("Scegli il corso: ");
        int scelta = int.Parse(Console.ReadLine());
        if (scelta < 0 && scelta > corsiPresenti.Count())
        {
            Console.WriteLine("Scelta non valida non esiste questo corso");
            return;
        }
        if (daje == 4)
        {
            Console.Write("Inserisci il nome dello studente da inserire: ");
            string nome = Console.ReadLine();
            corsiPresenti[scelta].AggiungiStudente(nome);
        }
        else if (daje == 7)
        {
            corsiPresenti[scelta].MetodoSpeciale();
        }
    }

    public static void Ricerca(List<Corso> corsiPresenti)
    { 
        int conto = 0;
        Console.Write("Inserisci il nome del docente per effettuare la ricerca: ");
        string prof = Console.ReadLine();

        foreach (Corso c in corsiPresenti)
        {
            if (c.docente.ToLower() == prof.ToLower())
            {
                Console.WriteLine(c);
                conto++;
            }
        }
        if (conto == 00)
        {
            Console.WriteLine("Non abbiamo corsi con questo professore, riprovare o aggiungerne uno");
        }
    }
}

