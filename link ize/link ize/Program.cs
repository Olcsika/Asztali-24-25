﻿using link1;
using System.Collections.Concurrent;

string[] text = File.ReadAllLines("felajanlas.txt");

List<Adatok> viragok = new List<Adatok>();

/*
foreach (string line in text.Skip(1))
{
    viragok.Add(new Adatok(line));
}
int agyasdb = int.Parse(text[0]);
*/

viragok = text.Skip(1).Select(sor => new Adatok(sor)).ToList();

for (int i = 0; i < viragok.Count; i++)
{
    viragok[i].sorszam = i + 1;
}

Console.WriteLine("2.: A felajánlások száma: {0}", viragok.Count);

/*
List<int> kapudb = new List<int>();
foreach (Adatok e in viragok)
{
    if (e.kapubentvan) {  kapudb.Add(e.sorszam); }
}
Console.WriteLine("3.: A bejárat mindkét oldalán ültetők: {0}", string.Join(" ", kapudb));
*/
Console.WriteLine("3.: A bejárat mindkét oldalán ültetők: {0}", string.Join(" ", viragok.Where(e => e.kapubentvan).Select(e => e.sorszam)));

Console.Write("Adja meg az ágyások sorszámát: ");
int be = int.Parse(Console.ReadLine());
int darab = 0;
string szin = "";
HashSet<string>szinek = new HashSet<string>();
for (int i = 0;i < viragok.Count; i++)
{
    if (viragok[i].benneVanEz(be))
    {
        darab++;
        
        if (szin == "")
        {
            szin = viragok[i].szin;
        }
        szinek.Add(szin);
        
    }
}

Console.WriteLine(darab);
if (darab == 0)
{
    Console.WriteLine("Nincs felajánlás");
}
else
{
    Console.WriteLine(szin);
    Console.WriteLine(String.Join(" ", szinek));
}
List<Adatok> szurt =viragok.Where((elem)=>elem.benneVanEz(be)).ToList();
Console.WriteLine(szurt.First().szin);
Console.WriteLine(szurt.Count);
Console.WriteLine("osszszin",String.Join(" ",szurt.Select(elem=>elem.szin).Distinct() ));


