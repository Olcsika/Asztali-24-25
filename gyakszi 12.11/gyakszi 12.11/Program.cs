using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

string text = File.ReadAllText("alma.txt");

Regex minta = new Regex(@"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})");

Regex referer = new Regex(@"https://(\S+)");

Regex egesz = new Regex(@"(\S+) - - \[(.+)] ""(\S+) (/\S+) (.+)"" (\d+) (\d+) ""(https://\S+|-)"" ""(.+)""");

var egy = egesz.Matches(text);

Regex zarjel = new Regex(@"\[(.+)] ");

Regex harmadik = new Regex(@"""(\w+) ");

Regex harmadika = new Regex(@"(\d{1,2}\:\d{1,2}\:\d{1,2})");

var tal3 = harmadik.Matches(text);
var tal4 = harmadika.Matches(text);
var tal2 = zarjel.Matches(text);
var talalat = minta.Matches(text);
var link = referer.Matches(text);


foreach (Match match in tal4)
{
    Console.WriteLine(match);
}



//Console.WriteLine(text);
//Console.WriteLine(talalat.Count);
//Console.WriteLine(link);
//Console.WriteLine();
Dictionary<string, int> kigyujt2 = new Dictionary<string, int>();


foreach (Match elem in link)
{
    if (kigyujt2.ContainsKey(elem.Value))
    {
        kigyujt2[elem.Value]++;
    }
    else
    {
        kigyujt2.Add(elem.Value, 1);
    }
}

foreach (KeyValuePair<string, int> elem in kigyujt2)
{
    //Console.WriteLine(elem);
}

foreach (Match match in egy)
{
    //Console.WriteLine(match.Groups[2]);
    //Console.WriteLine(match);
}