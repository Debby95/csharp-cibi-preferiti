// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;

//string[] cibiPreferiti = { "Pasta", "Pizza", "Broccoli", "Cotoletta", "Pane", "Polpette" };

////stampo la lunghezza della lista

//Console.WriteLine("I cibi preferiti sono: " + cibiPreferiti.Length);

//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    //stampo la lista dei cibi preferiti
//    Console.WriteLine("Cibo: " + cibiPreferiti[i]);
//}

////stampo il cibo top
//Console.WriteLine("Cibo Top: " + cibiPreferiti[0]);
////stampo l'ultimo cibo preferito
//Console.WriteLine("Ultimo cibo preferito: " + cibiPreferiti[cibiPreferiti.Length-1]);
////stampo il cibo preferito presente al centro
//if(cibiPreferiti.Length % 2 == 0)
//{
//    //pari
//    int medianaSuperiore = cibiPreferiti.Length / 2;
//    int medianaInferiore = medianaSuperiore -1;
//    Console.WriteLine("Cibo presente al centro: {0} e {1}", cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);
//    //***SE AVESSIMO UN ALTRO ELEMENTO NELL'ARRAY***

//} else
//{
//    //dispari
//    int mediana = cibiPreferiti.Length / 2;
//    Console.WriteLine("Cibo presente al centro: " + cibiPreferiti[mediana]);
//}

Console.WriteLine();


//ISTRUZIONI CONDIZIONALI
//Snack1 
//L'utente inserisce due numeri in successione. 
//Il software stampa il maggiore.

//Console.WriteLine("Inserisci un numero: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci un altro numero: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine(num1);
//} else
//{
//    Console.WriteLine(num2);
//}


//Snack2
//L'utente inserisce due parole in successione
//Il software stampa prima la parola più corta, poi la parola più lunga.
//Console.WriteLine("Inserisci una parola: ");
//string parola1 = Console.ReadLine();

//Console.WriteLine("Inserisci un'altra parola: ");
//string parola2 = Console.ReadLine();

//if (parola1.Length < parola2.Length)
//{
//    Console.WriteLine(parola1 + " " + parola2);

//}
//else
//{
//    Console.WriteLine(parola2 + " " + parola1);
//}


//CICLO FOR
//Snack 3
//Il software deve chiedere per 10 volte all'utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

//int somma = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Inserisci un numero: ");
//    somma += Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Somma numeri inseriti: " + somma);


//Snack 4
//Calcola la somma e la media dei numeri da 2 a 10.
//int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int media = numeri[0];
//int somma = 0;
//for (int i = 0; i < numeri.Length; i++)

//{
//    somma += numeri[i];
//}

//Console.WriteLine("La somma dei numeri è: " + somma);

//media = somma / numeri.Length;

//Console.WriteLine("La media dei numeri è: " + media);

//Snack 5 
//Il software richiede all'utente di inserire un numero.
//Se il numero inserito è pari stampa il numero, se è dispari stampa il numero successivo.

//Console.WriteLine("Inserisci un numero: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Numero inserito: " + num);
//} else
//{
//    Console.WriteLine("Numero inserito: " + num++);
//    Console.WriteLine("Stampo numero successivo al dispari inserito: " + num);
//}

//Snack 6
//In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all'utente di inserire il suo nome e comunicagli se può partecipare alla festa.

//Snack 7 
//Crea un array vuoto
//Chiedi per 6 volte all'utente di inserire un numero, se è dispari inseriscilo nell'array.


//Snack 8 

//FUNZIONI
//Snack 1
//1. Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
//Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

//Console.WriteLine("Inserisci due parole: ");
//string par1 = Console.ReadLine();
//string par2 = Console.ReadLine();

//string parolaPiuLunga = "";
//Console.WriteLine(lunghezzaParole(par1, par2));


//string lunghezzaParole(string parola1, string parola2)
//{

//    if (parola1.Length == parola2.Length)
//    {
//        parolaPiuLunga = parola1 + " " + parola2;
//        return parolaPiuLunga;
//    } else if (parola1.Length > parola2.Length)
//    {
//        return par1;
//    } else
//        return par2;

//}

//Snack 2
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.

Console.WriteLine("Scrivi un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numeroPariODispari(numero));

string numeroPariODispari(int num)
{
    if (num % 2 == 0)
    {
        return "Numero pari";
    } else
    {
        return "Numero dispari";
    }
}
