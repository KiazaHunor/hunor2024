//1. Feladat
string trafi = "jeladas.txt";

string[] trafipax = File.ReadAllLines(trafi);

string tabulator1 = "jeladas_tabulator.txt";
Console.WriteLine(trafipax);

foreach (string kapcsolas in trafipax)
{
    Console.WriteLine(kapcsolas);
}
    try
    {
        string tartalom = File.ReadAllText(trafi);
        string tartalom2 = tartalom.Replace(" ", "\t");
        File.WriteAllText(tabulator1, tartalom2);
    }
    catch (Exception elkapas)
    {
        Console.WriteLine($"Hiba történt: {elkapas.Message}");
    }



//2.Feladat
Console.WriteLine("2.Feladat");
string utolso = string.Empty;
int utolsoido = -1;

foreach (string line in trafipax)
{
    string[] vagas = line.Split('\t');
    string rendszam =vagas[0];
    int ora = int.Parse(vagas[1]);
    int perc = int.Parse(vagas[2]);

    int aktualis = ora * 60 + perc;
    if (aktualis > utolsoido)
    {
        utolsoido = aktualis;
        utolso = rendszam;
    }
}

int utolsoora = utolsoido / 60;
int utolsoperc = utolsoido % 60;

Console.WriteLine($"Legutolsó jeladás időpontja: {utolsoora}:{utolsoperc}");
Console.WriteLine($"Utoljára jelet adó autó rendszáma: {utolso}");




Console.WriteLine("3. Feladat");


string elsoauto = trafipax[0].Split('\t')[0]; 

List<string> ido = new List<string>(); 

    foreach (string sor in trafipax)
    {
        string[]vagas1 = sor.Split('\t');
        string rendszam = vagas1[0];
        int ora = int.Parse(vagas1[1]);
        int perc = int.Parse(vagas1[2]);

    
        if (rendszam == elsoauto)
        {
            ido.Add($"{ora}:{perc:00}");
        }
}

Console.WriteLine($"Első jármű rendszáma: {elsoauto}");
Console.WriteLine("Időpontok: " + string.Join(" ", ido));
