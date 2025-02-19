using park;

List<adatok> viragok = new List<adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");


foreach (string s in sorok.Skip(1))
{
    viragok.Add(new adatok(s));
}
for (int i = 0; i < sorok.Length; i++)
{
    
}

viragok = sorok.Skip(1).Select(sor => new adatok(sor)).ToList();
//2.feladat
Console.WriteLine(viragok.Count);
//3.feladat
Console.WriteLine();

foreach (adatok s in viragok)
{
    if (s.kapuBentVan)
    {
        Console.WriteLine(
    }
}