using System;
using System.ComponentModel;

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


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Benvenuto nel Menu");
        Console.WriteLine("1. Aggiungi un Corso di Musica\n2Aggiungi un corso di Pittura\n3.Aggiungi un corso di Danza\n4.Aggiungi studente a un corso\n5.Visualizza tutti i corsi\n6.Cerca Corsi per nome docente\n7.Esegui Metodo Speciale di un corso\n0.Esci");
        int scelta = int.Parse(Console.ReadLine());

        bool x = true;
        do
        {

            switch (scelta)
            {
                case 1:
                    AggiungiCorso(1)
                    break;
                case 2:
                    AggiungiCorso(2)
                    break;
                case 3:
                    AggiungiCorso(3)
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

    public static Corso AggiungiCorso(int scelta)
    {
        List<string> studenti = new List<string>();
        Console.Write("Inserisci il nome del corso: ");
        string nome = Console.ReadLine();
        Console.Write("Inserisci il durata ore: ");
        int ore = int.Parse(Console.ReadLine());
        Console.Write("Inserisci il nome del corso: ");
        string docente = Console.ReadLine();

        if (scelta == 1)
        {
            Console.WriteLine("Inserisci lo strumento del corso: ");
            string strumento = Console.ReadLine();

            return new CorsoMusica(nome, ore, docente, studenti, strumento);
        }
        else if (scelta == 2)
        {
            Console.WriteLine("Inserisci la tecnica del corso: ");
            string tecnica = Console.ReadLine();

            return new CorsoPittura(nome, ore, docente, studenti, tecnica);
        }
        else if (scelta == 3)
        {
            Console.WriteLine("Inserisci lo stile del corso: ");
            string danza = Console.ReadLine();

            return new CorsoDanza(nome, ore, docente, studenti, danza);
        }
    }


}

