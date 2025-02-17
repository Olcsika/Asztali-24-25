using rgb_szinej;

List<Pixel> pontok = new List<Pixel>();

StreamReader olvas = new StreamReader("kep.txt");
int x = 0;
int y = 0;

while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    string[] vag = line.Split(" ");
    x = 0;
    for (int i = 0; i < vag.Length; i += 3)
    {
        int r = int.Parse(vag[i]);
        int g = int.Parse(vag[i] + 1);
        int b = int.Parse(vag[i + 2]);

        pontok.Add(new Pixel(0, 0, new Szin(r, g, b)));
        x++;
    }
    y++;
}

olvas.Close();


Console.WriteLine("2. feladat:");
Console.WriteLine("Kérek egy képpont adatait: ");
Console.WriteLine("Sor: ")s;
int sor = int.Parse(Console.ReadLine());
Console.WriteLine("Oszlop: ");
int oszlop = int.Parse(Console.ReadLine());

var talalat = pontok.Where(pont => pont.    x == oszlop && pont.y == sor).First();


Console.WriteLine("A keppont szine {0}", talalat.rgb);

var vilagosok = pontok.Where(vilagos => vilagos.rgb.vilagos()).ToList();
Console.WriteLine($"3. Feladat: A vilagosok keppontok szama {vilagosok.Count}");

int legsetettebb = pontok.Min(sotet => sotet.rgb.osszeg());
int minSzin = pontok.Min(pont => pont.rgb.osszeg());
Console.WriteLine(minSzin);

List<string> sotetek = pontok //össszes keppont
    .Where(pont=>pont.rgb.osszeg()==minSzin) //legsoeteteb kepontok
    .Select(pont=>pont.rgb.ToString()) //csak a szinek legyenek
    .ToList(); //legyen lista a halmazbol
Console.WriteLine("Legsötétebb pontok összege");
Console.WriteLine(String.Join("\n",sotetek);

static bool hatar(int sor, int elteres)
{
    return true;

}
// aktualis elem rgb tulajdonsaganak mezojnnek a b erteke es a övi eelem rgb mezojenbek b komponense között a kulonbseg nagyob e mint az elteres