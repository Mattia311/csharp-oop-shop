using csharp_oop_shop;


//Esercizio di oggi: C# Shop nome repo: csharp-oop-shop Nel progetto csharp-oop-shop,
//creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da: - codice
//(numero intero) - nome - descrizione - prezzo - iva Usate opportunamente i livelli di accesso (public, private),
//i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che: alla creazione
//di un nuovo prodotto il codice sia valorizzato con un numero random Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura Il prodotto esponga sia un metodo per avere il
//prezzo base che uno per avere il prezzo comprensivo di iva Il prodotto esponga un metodo per avere il nome esteso,
//ottenuto concatenando codice + nome Nella vostro programma principale, testate tutte le funzionalità della classe
//Prodotto. BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri
//(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)


        
Prodotto pr1 = new Prodotto("Lampada", "lampada antica, due luci", 100, 0.22);
Prodotto pr2 = new Prodotto("Sedia", "sedia per sedute", 2000, 0.22);


Console.WriteLine("PR1: {0}, {1},{2}", pr1.NomeEsteso(), pr1.Codice, pr1.GetCodiceFormatted());



        
