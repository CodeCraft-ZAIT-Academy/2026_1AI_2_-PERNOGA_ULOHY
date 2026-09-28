Console.WriteLine($"Dnešný rok je: {DateTime.Now.Year}");

Console.Write("tvoj vek: ");
string vek = Console.ReadLine();

int cislo2AkoCislo = int.Parse(vek);

int vysledok = 2026 - cislo2AkoCislo;
Console.WriteLine("rok narodenia je: " + vysledok); 
