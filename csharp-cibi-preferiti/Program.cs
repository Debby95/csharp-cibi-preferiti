﻿// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

string[] cibiPreferiti = { "Pasta", "Pizza", "Broccoli", "Cotoletta", "Pane" };

Console.WriteLine("I cibi preferiti sono: " + cibiPreferiti.Length);

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine("Cibo: " + cibiPreferiti[i]);
}


Console.WriteLine("Cibo Top: " + cibiPreferiti[0]);
Console.WriteLine("Ultimo cibo preferito: " + cibiPreferiti[3]);
Console.WriteLine("Cibo presente al centro: " + cibiPreferiti[2]);

