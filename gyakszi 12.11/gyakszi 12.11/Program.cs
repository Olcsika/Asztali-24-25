using System.Text.RegularExpressions;

string text = File.ReadAllText("alma.txt");

Regex minta = new Regex(@"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})");
var talalat = minta.Matches(text);
Console.WriteLine(talalat.Count);