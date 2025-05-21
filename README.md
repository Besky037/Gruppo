# Gruppo Lopardo Macrì Betti

# 🎨 Gestione Corsi Artistici Multidisciplinari (C#)

Questo progetto è un esercizio avanzato sull'**ereditarietà in C#**, che permette di gestire i corsi di una scuola artistica multidisciplinare. Ogni corso può appartenere a una delle seguenti categorie:

- Corso di Musica  
- Corso di Pittura  
- Corso di Danza  

## 📚 Struttura OOP

### 🔹 Classe base: `Corso`

**Attributi**:
- `string NomeCorso`
- `int DurataOre`
- `string Docente`
- `List<string> Studenti`

**Metodi**:
- `void AggiungiStudente(string nomeStudente)`
- `override string ToString()`
- `virtual void MetodoSpeciale()` (vuoto o stampa generica)

---

### 🔸 Classi derivate

#### `CorsoMusica` 🎼  
- **Attributo aggiuntivo**: `string Strumento`  
- `MetodoSpeciale()` stampa:  
  ```
  Si tiene una prova pratica dello strumento: [strumento]
  ```

#### `CorsoPittura` 🎨  
- **Attributo aggiuntivo**: `string Tecnica`  
- `MetodoSpeciale()` stampa:  
  ```
  Si lavora su una tela con la tecnica: [tecnica]
  ```

#### `CorsoDanza` 💃  
- **Attributo aggiuntivo**: `string Stile`  
- `MetodoSpeciale()` stampa:  
  ```
  Esecuzione coreografica nello stile: [stile]
  ```

---

## 📋 Funzionalità (menù interattivo)

Il programma consente di:

1. Aggiungere un corso di Musica  
2. Aggiungere un corso di Pittura  
3. Aggiungere un corso di Danza  
4. Aggiungere studenti a un corso esistente (tramite selezione da lista)  
5. Visualizzare tutti i corsi  
6. Cambiare docente di un corso  
7. Eseguire il metodo speciale su un corso  

---

## 🛠 Tecnologie

- Linguaggio: **C#**
- Paradigma: **Programmazione orientata agli oggetti**
- IDE consigliato: **Visual Studio** o **Rider**

---

## 🚀 Avvio del Progetto

1. Clona il repository:
   ```bash
   git clone https://github.com/tuo-username/nome-progetto.git
   ```
2. Apri la soluzione in Visual Studio  
3. Avvia il file `Program.cs`  
4. Usa il menù per interagire con i corsi

---

## 📌 Obiettivi Didattici

- Comprendere l'uso dell'ereditarietà in C#  
- Utilizzare il polimorfismo con metodi virtuali e override  
- Gestire una lista di oggetti tramite interfaccia testuale

---

## 🧑‍💻 Autore
Alessandro Lopardo, Alessio Macrì e Leo Betti

*Creato come esercizio avanzato per corsi di programmazione ad oggetti in C#.*
