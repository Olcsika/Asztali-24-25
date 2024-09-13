// See https://aka.ms/new-console-template for more information
using oop_gyak;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");
kutya k = new kutya("Papucs");
k.ugat();
k.suly= -12;
Console.WriteLine(k.suly);
Console.WriteLine(k);

Console.WriteLine(kutya.ezMiEz());