// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

string[] cibiPreferiti = { "Pasta", "Pizza", "Broccoli", "Cotoletta" };

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine("Cibo: " + cibiPreferiti[i]);
}

Console.WriteLine("I cibi preferiti sono: " + cibiPreferiti.Length);
Console.WriteLine("Cibo Top: " + cibiPreferiti[0]);
Console.WriteLine("Ultimo cibo preferito: " + cibiPreferiti[3]);

