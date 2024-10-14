

List<string> kordik = new List<string>();

StreamReader olvas = new StreamReader("Korok.txt");
while (!olvas.EndOfStream)
{
    kordik.Add(olvas.ReadLine());    
    
}
olvas.Close();
foreach (string k in kordik)
{
    //Console.WriteLine(k);
}


Console.WriteLine("2. feladat");
Console.WriteLine("1. negyed");
Console.WriteLine("2. negyed");
Console.WriteLine("3. negyed");
Console.WriteLine("4. negyed");

