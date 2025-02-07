using BeléptetRendszer;
using System.Threading.Channels;

List<adatok> esemenyek = new List<adatok>();
string[] sorok = File.ReadAllLines("bedat.txt");

for (int i = 0; i < sorok.Length; i++)
{
    esemenyek.Add(new adatok(sorok[i]));
}

Console.WriteLine("2.feladat");
Console.WriteLine("Az első tanuló {0}-kor lépett be a főkapun.", esemenyek[0].ido);
Console.WriteLine("Az utolsó tanuló {0}-kor lépett ki a főkapu.", esemenyek[esemenyek.Count-1].ido);
//Console.WriteLine("3. feladat");
StreamWriter ir = new StreamWriter("keso.txt");
for (int i = 0; i < esemenyek.Count; i++)
{
    if (((esemenyek[i].ora == 7 && esemenyek[i].perc >= 50) || 
        (esemenyek[i].ora == 8 && esemenyek[i].perc <= 15))&& esemenyek[i].esemeny==1)
    {
        ir.WriteLine(esemenyek[i].ido + " " + esemenyek[i].kod);
    }

}
ir.Close();
Console.WriteLine("4. feladat");
int darab = 0;
for (int i = 0;i<esemenyek.Count ; i++)
{
    if (esemenyek[i].esemeny ==3)
    {
        darab++;
    }
}
Console.WriteLine(darab);
Console.WriteLine("5. feladat");
HashSet<string> konyv = new HashSet<string>();
for (int i = 0;i<esemenyek.Count; i++)
{
    if (esemenyek[i].esemeny == 4)
    {
        konyv.Add(esemenyek[i].kod);
    }
    
}
if (konyv.Count > darab)
{
    Console.WriteLine("Többen voltak mint a menzan");
}
else 
{
    Console.WriteLine("Nem voltak többen mint a menzan");
}
HashSet<string> kodok = new HashSet<string>();
for(int i = 0; i<esemenyek.Count;i++)
{
    kodok.Add(esemenyek[i].kod);
}
Console.WriteLine("6. feladat");
foreach (string s in kodok)
{
    bool bentVan=false;
    for(int i = 0;i<esemenyek.Count;i++)
    {
        if (esemenyek[i].kod == s)
        {
            if (esemenyek[i].esemeny == 1)
            {
                if (bentVan)
                {
                    //hiba
                    Console.Write(s+" ");
                }
                else
                {
                    bentVan=true;
                }
            }
            else if (esemenyek[i].esemeny == 2)
            {

            }
           

            
        }
      
    }
}
Console.WriteLine("7. feladat");
Console.WriteLine("Egy tanuló azonosítója=");
string tanuloKo = Console.ReadLine();
adatok elso;
adatok utolso;
for (int i = 0; i < esemenyek.Count; i++)
{

}
