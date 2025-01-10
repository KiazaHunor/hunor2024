using belepteto;

List<adatok> esemenyek = new List<adatok>();
string[] sorok = File.ReadAllLines("bedat.txt");

for (int i = 0; i < sorok.Length; i++) 
{
    esemenyek.Add(new adatok(sorok[i]));
}
Console.WriteLine("2.feladat");
Console.WriteLine("Az elso tanulo {0}-kor lépett be a főkapuban.", esemenyek[0].ido);
Console.WriteLine("Az utolsó tanulo {0}-kor lépett ki a főkapuban.", esemenyek[-1].ido);

Console.WriteLine("3.feladat");

StreamWriter ir = new StreamWriter("kesok.txt");
for (int i = 0; i < esemenyek.Count; i++) 
{
    if (
        (
        (esemenyek[i].ora == 7 && esemenyek[i].perc >= 50)
        || (esemenyek[i].ora == 7 && esemenyek[i].perc <= 15)
        )
        && esemenyek[i].esemeny == 1) 
    {
        ir.WriteLine(esemenyek[i].ido + " " + esemenyek[i].kod);
    }
}

ir.Close();
Console.WriteLine("4.feladat");
int darab =0;
for (int i = 0; i < esemenyek.Count; i++)
{
    if (esemenyek[i].esemeny == 3) 
    {
        darab++;
    }    
}
Console.WriteLine($"A menzán aznap {darab} tanuló ebédelt.");

Console.WriteLine("5.feladat");



