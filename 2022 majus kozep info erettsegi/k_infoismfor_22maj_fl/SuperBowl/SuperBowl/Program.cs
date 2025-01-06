using System.Reflection;

StreamReader reader = new StreamReader("SuperBowl.txt");

List<string> Ssz = new List<string>();
List<string> Dátum = new List<string>();
List<string> Győztes = new List<string>();
List<string> Eredmény = new List<string>();
List<string> Vesztes = new List<string>();
List<string> Helyszín = new List<string>();
List<string> VárosÁllam = new List<string>();
List<string> Nézőszám = new List<string>();

while (!reader.EndOfStream){
    string sor = reader.ReadLine();
    string[] vag = sor.Split(";");
    Ssz.Add(vag[0]);
    Dátum.Add(vag[1]);
    Győztes.Add(vag[2]);
    Eredmény.Add(vag[3]);
    Vesztes.Add(vag[4]);
    Helyszín.Add(vag[5]);
    VárosÁllam.Add(vag[6]);
    Nézőszám.Add(vag[7]);
    }
foreach(string i in Ssz)
{
    //Console.WriteLine(i);
}

Console.WriteLine("1. feladat: {0}",Ssz.Count);
reader.Close();
