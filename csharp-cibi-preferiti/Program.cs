// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

string[] cibiPreferiti = { "Pasta", "Pizza", "Broccoli", "Cotoletta", "Pane", "Polpette" };

//stampo la lunghezza della lista

Console.WriteLine("I cibi preferiti sono: " + cibiPreferiti.Length);

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    //stampo la lista dei cibi preferiti
    Console.WriteLine("Cibo: " + cibiPreferiti[i]);
}

//stampo il cibo top
Console.WriteLine("Cibo Top: " + cibiPreferiti[0]);
//stampo l'ultimo cibo preferito
Console.WriteLine("Ultimo cibo preferito: " + cibiPreferiti[cibiPreferiti.Length-1]);
//stampo il cibo preferito presente al centro
if(cibiPreferiti.Length % 2 == 0)
{
    //pari
    int medianaSuperiore = cibiPreferiti.Length / 2;
    int medianaInferiore = medianaSuperiore -1;
    Console.WriteLine("Cibo presente al centro: {0} e {1}", cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);
    //***SE AVESSIMO UN ALTRO ELEMENTO NELL'ARRAY***

} else
{
    //dispari
    int mediana = cibiPreferiti.Length / 2;
    Console.WriteLine("Cibo presente al centro: " + cibiPreferiti[mediana]);
}


