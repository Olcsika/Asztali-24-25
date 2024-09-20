//nap 24 orajaban random c fok, +/- 5 fok, este ejszaka csak csokkenhet,
//nappal csak nőhet, min 10, max 40
Console.WriteLine("Hello, World!");

var nap = 0;

Random rnd = new Random();
for (int i = 0; i < 25; i++)
{
    Console.WriteLine(i +" "+rnd.Next(10,40));
}

