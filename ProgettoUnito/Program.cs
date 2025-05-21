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
    //Definizione della proprietà tecnica
    public string tecnica;

    /// <summary>
    ///  Costruttore per la classe figlia CorsoPittura
    /// </summary>
    /// <param name="n"></param>
    /// <param name="du"></param>
    /// <param name="doc"></param>
    /// <param name="s"></param>
    /// <param name="t"></param>
    public CorsoPittura(string n, int du, string doc, List<string> s, string t) 
    :base(n, du, doc, s)
    {
        tecnica = t;
    }

    /// <summary>
    /// Override funzione ToString per la classe CorsoPittura
    /// </summary>
    /// <returns>La descrizione base del corso + la tecnica del corso seguente</returns>
    public override string ToString()
    {
        return $"{base.ToString()} Tecnica: {tecnica}";
    }

    /// <summary>
    /// Metodo che stampa la tecnica che viene utilizzata
    /// </summary>
    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su tela con tecnica: {tecnica}");
    }
}

public class CorsoDanza : Corso
{
    //definizione della proprietà stile
    public string stile;

    /// <summary>
    /// Costruttore della classe figlia CorsoDanza
    /// </summary>
    /// <param name="nomeCorso"></param>
    /// <param name="durataOre"></param>
    /// <param name="docente"></param>
    /// <param name="studenti"></param>
    /// <param name="stil"></param>
    public CorsoDanza(string nomeCorso, int durataOre, string docente, List<string> studenti, string stil)
    : base(nomeCorso, durataOre, docente, studenti)
    {
        stile = stil;
    }

    /// <summary>
    /// Stampa la descrizione completa
    /// </summary>
    /// <returns>Descrizione base del corso + stile </returns>
    public override string ToString()
    {
        return $"{base.ToString()} Stile: {stile}";
    }

    /// <summary>
    /// Stampa lo stile della coreografia che verrà svolta
    /// </summary>
    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografica nello stile: {stile}");
    }
}


public class Program
{
    public static void Main()
    {
        //Definizione lista vuota per contenere i corsi inseriti;
        List<Corso> corsiPresenti = new List<Corso>();
        bool x = true; // definizione della variabile che controlla il do while imposta a true fino a che l'utente non sceglie exit

        do
        {
            //Visualizzazione del Menu
            Console.WriteLine("Benvenuto nel Menu");
            Console.WriteLine("1.Aggiungi un Corso di Musica\n2.Aggiungi un corso di Pittura\n3.Aggiungi un corso di Danza\n4.Aggiungi studente a un corso\n5.Visualizza tutti i corsi\n6.Cerca Corsi per nome docente\n7.Esegui Metodo Speciale di un corso\n0.Esci");
            int scelta = int.Parse(Console.ReadLine());

            //switch in base alla scelta definita esegue le funzioni scelte
            switch (scelta)
            {
                case 1:
                    corsiPresenti.Add(AggiungiCorso(1));//aggiunge il corso di musica alla liste
                    break;
                case 2:
                    corsiPresenti.Add(AggiungiCorso(2));//aggiunge il corso di pittura alla liste
                    break;
                case 3:
                    corsiPresenti.Add(AggiungiCorso(3));//aggiunge il corso di danza alla liste
                    break;
                case 4:
                    SelezionaCorso(corsiPresenti, 4);//Aggiunge uno studente
                    break;
                case 5:
                    StampaCorsi(corsiPresenti);// Visualizza tutti i corsi presenti
                    break;
                case 6:
                    Ricerca(corsiPresenti);//Effettua una ricerca in base al nome del docente
                    break;
                case 7:
                    SelezionaCorso(corsiPresenti, 7);//Effettua il metodo speciale del corso scelto
                    break;
                case 0:
                    x = false;//imponiamo la x false per uscire dal ciclo
                    break;
                default:
                    Console.WriteLine("Scelta non valida");//Messaggio di errore per una scelta non valida
                    break;
            }
        }
        while (x);
    }

    /// <summary>
    /// Riceve in input un numero da 1 a 3 e a seconda di questo riconosce il tipo di corso che sta per essere aggiunto
    /// e richiede in input tutte le proprietà necessarie per definirlo, inizializza gli studenti a 0 fino a che non verranno aggiunti
    /// </summary>
    /// <param name="scelta"></param>
    /// <returns>Genera un oggetto corso grazie agli input</returns>
    public static Corso AggiungiCorso(int scelta)
    {
        List<string> studenti = new List<string>();//lista vuota per contenere gli studenti

        Console.Write("Inserisci il nome del corso: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci il durata ore: ");
        int ore = int.Parse(Console.ReadLine());

        Console.Write("Inserisci il nome del docente del corso: ");
        string docente = Console.ReadLine();

        if (scelta == 1) // Scelta uguale a 1 vuol dire che il corso che verrà inserito sarà di Musica
        {
            Console.Write("Inserisci lo strumento del corso: ");
            string strumento = Console.ReadLine();

            return new CorsoMusica(nome, ore, docente, studenti, strumento);
        }
        else if (scelta == 2) // Scelta uguale a 2 vuol dire che il corso che verrà inserito sarà di Pittura
        {
            Console.Write("Inserisci la tecnica del corso: ");
            string tecnica = Console.ReadLine();

            return new CorsoPittura(nome, ore, docente, studenti, tecnica);
        }
        else if (scelta == 3) // Scelta uguale a 3 vuol dire che il corso che verrà inserito è di Danza
        {
            Console.Write("Inserisci lo stile del corso: ");
            string danza = Console.ReadLine();

            return new CorsoDanza(nome, ore, docente, studenti, danza);
        }
        return null;// ritorna nullo anche se non entra mai è solo per evitare errori
    }

    /// <summary>
    /// Funzione stampa che scorre tutti i corsi inseriti nella lista per stampare tutte le informazioni presenti nel Tostring delle varie classi
    /// </summary>
    /// <param name="corsiPresenti"></param>
    public static void StampaCorsi(List<Corso> corsiPresenti)
    {
        int count = 0;
        foreach (Corso c in corsiPresenti)
        {
            Console.WriteLine($"[{count}] {c}");
            count++;
        }
    }

    /// <summary>
    /// Riceve in input la lista dei corsi e una variabile intera che è stata utilizzata perchè a seconda di quella verrà permesso di scegliere
    /// il corso e poi a seconda del int nel caso 4 permette di aggiungere uno studente al corso
    /// , mentre il 7 stampa il metodo speciale del corso scelto
    /// </summary>
    /// <param name="corsiPresenti"></param>
    /// <param name="daje"></param>
    public static void SelezionaCorso(List<Corso> corsiPresenti, int daje)
    {
        StampaCorsi(corsiPresenti);//Sfruttiamo StampaCorsi per ottenere la lista dei corsi presenti
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
            corsiPresenti[scelta].AggiungiStudente(nome);//aggiunge al corso definito dalla scelta un nuovo studente con il nome preso in input
        }
        else if (daje == 7)
        {
            corsiPresenti[scelta].MetodoSpeciale();//richiama metodo speciale per il corso definito da scelta
        }
    }

    /// <summary>
    /// Funzione di Ricerca che riceve in input la lista dei corsi e richiede il nome del docente, scorre tutti i corsi presenti e se trova 
    /// un corso dove il nome del docente coincide a quello inserito, ne stampa la descrizione
    /// </summary>
    /// <param name="corsiPresenti"></param>
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
        if (conto == 0)//Controllo nel caso in cui non ci siano corsi con quel docente
        {
            Console.WriteLine("Non abbiamo corsi con questo professore, riprovare o aggiungerne uno");
        }
    }
}

