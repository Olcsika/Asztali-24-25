using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

string text = File.ReadAllText("alma.txt");

Regex minta = new Regex(@"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})");

Regex referer = new Regex(@"https://(\S+)");

var talalat = minta.Matches(text);
var link = referer.Matches(text);
Console.WriteLine(text);
Console.WriteLine(talalat.Count);
Console.WriteLine(link);
Console.WriteLine();

foreach (Match match in link)
{
    Console.WriteLine(match);
    Console.WriteLine(match);
}