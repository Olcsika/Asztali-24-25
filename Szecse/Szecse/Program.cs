StreamReader olvas = new StreamReader("atvaltoztatastan.txt");
List<string> listaaa = new List<string>();
while (!olvas.EndOfStream)
{
    listaaa.Add(olvas.ReadLine());
}
foreach (string line in listaaa)
{
    Console.WriteLine(line);
}
olvas.Close();
