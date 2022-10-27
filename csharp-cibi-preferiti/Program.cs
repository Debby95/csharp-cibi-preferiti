// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

string[] cibiPreferiti = { "Pasta", "Pizza", "Broccoli", "Cotoletta", "Pane" };

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
Console.WriteLine("Ultimo cibo preferito: " + cibiPreferiti[4]);
//stampo il cibo preferito presente al centro
Console.WriteLine("Cibo presente al centro: " + cibiPreferiti[2]);

