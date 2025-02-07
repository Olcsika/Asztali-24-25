using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;
//Chrome / 91.0.4472.124 Safari / 537.36"

string text = File.ReadAllText("adatok.txt");

Regex meret = new Regex(@"POST (/\s*)");
Regex torles = new Regex(@"(\""\w+) ");
Regex oldal = new Regex(@"( \/\S+ )");
Regex norefere = new Regex(@"(\- )");
Regex useragent = new Regex(@"(""\.+"")");

var useragentes = useragent.Matches(text);
var meretes = meret.Matches(text);
var oldalas = oldal.Matches(text);
var torleses = torles.Matches(text);
var norefereres = norefere.Matches(text);

foreach (Match match in useragentes)
{
    Console.WriteLine(match);
}
foreach (Match match in norefereres)
{
    //Console.WriteLine(match);
}
foreach (Match match in torleses)
{
    //Console.WriteLine(match);
}
foreach (Match match in oldalas)
{
    //Console.WriteLine(match);
}
foreach (Match match in meretes)
{
    //Console.WriteLine(match);
}
Console.WriteLine("1. feladat");
Console.WriteLine("Postra érkezett adatmennyiség: "+meretes.Count);



Dictionary<string,int> methodLista =  new Dictionary<string,int>();

foreach (Match match in torleses)
{
    if (methodLista.ContainsKey(match.Value))
    {
        methodLista[match.Value]++;
    }
    else
    {
        methodLista.Add(match.Value, 1);
    }
    
}
Console.WriteLine("2. feladat");
Console.WriteLine("Az összes törlés: ");
foreach (KeyValuePair<string, int> elem in methodLista)
{
    
    Console.Write(elem);
}

Console.WriteLine();
Dictionary<string, int> oldalLista = new Dictionary<string, int>();

foreach (Match match in oldalas)
{
    if (oldalLista.ContainsKey(match.Value))
    {
        oldalLista[match.Value]++;
    }
    else
    {
        oldalLista.Add(match.Value, 1);
    }

}

Console.WriteLine("3. feladat");


var legnagy = oldalLista.Values.Max();
foreach (KeyValuePair<string, int> elem in oldalLista)
{

    //Console.Write(elem);
}
Console.WriteLine(legnagy);
Console.WriteLine();

Console.WriteLine("4. feladat");
StreamWriter iras = new StreamWriter("noreferer.log");


iras.Close();
Console.WriteLine("5. feladat");


