//1. Feladat
string trafi = "jeladas.txt";
string[] trafipax = File.ReadAllLines(trafi);
Console.WriteLine(trafipax);

foreach (string kapcsolas in trafipax)
{
    Console.WriteLine(kapcsolas);
}


//2.Feladat
Console.WriteLine("2.Feladat");
for (int i = 0; i < trafipax.Length; i++) 
{
    if (trafipax[2])
}