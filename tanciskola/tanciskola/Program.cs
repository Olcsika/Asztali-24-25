using tanciskola;


StreamReader olvas = new StreamReader("tancrend.txt");
List<Class1> tancok = new List<Class1>();
StreamWriter ir = new StreamWriter("szereplők.txt");


while(!olvas.EndOfStream)
{
    tancok.Add(new Class1( olvas.ReadLine(),olvas.ReadLine(),olvas.ReadLine()));   
}


Console.WriteLine("2.feladat");
var elso = tancok.First().tancNeve;
var utolso = tancok.Last().tancNeve;
Console.WriteLine("Az elsőként bemutatott tánc {0} volt, az utolsóként bemutatott tánc {1} volt.",elso,utolso);
Console.WriteLine("------------------------");
Console.WriteLine("3.feladat");
var sambaDb = tancok.Where(tanc => tanc.tancNeve == "samba").ToList().Count;
Console.WriteLine("{0}-en táncoltak sambát",sambaDb);
Console.WriteLine("------------------------");
Console.WriteLine("4. feladat");
var vilmaTancok = tancok.Where(tanc => tanc.lany == "Vilma").Select(tanc => tanc.tancNeve).ToList();
Console.WriteLine("Vilma ezekben a táncokban táncolt: {0}", String.Join(", ",vilmaTancok));
Console.WriteLine("------------------------");
Console.WriteLine("5. feladat");
Console.WriteLine("Kérek egy táncnevet: ");
string tancNevBeker =  Console.ReadLine();
/*
for (int i = 0;tancok.Count > 0;i++)
{
    if(tancNevBeker == tancok.Where(tanc=>tanc.tancNeve=="Vilma"))
}
*/

Console.WriteLine("------------------------");
Console.WriteLine("6. feladat");
//var fiuk =  tancok.Where(tanc=>tanc.fiu);
//var lanyok = tancok.Where(tanc => tanc.lany);

olvas.Close();
ir.Close();