using parkerdo;

List<Adatok> viragok = new List<Adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");

int agyasDB=int.Parse(sorok[0]);

for (int i = 1; i < sorok.Length; i++) 
{
    viragok.Add(new Adatok(sorok[i]));
}


//LinQ
viragok = sorok.Skip(1).Select(sor => new Adatok(sor)).ToList();


for (int i = 0; i < viragok.Count; i++) 
{
    viragok[i].sorszam = i + 1;
}

//2. feladat
Console.WriteLine("2. feladat \n A felajánlások száma: {0}", viragok.Count);

//3. feladat
Console.WriteLine("3. feladat \n A bejárat mindkét oldalán ültetők:");

//hagyományos

foreach (Adatok v in viragok) 
{
    if (v.kapuBentVan)
    {
        Console.WriteLine(v.sorszam + " ");
    }
}

for (int i = 0; i < viragok.Count; i++) 
{
    if (viragok[i].kapuBentVan) 
    {
        Console.Write("{0}", i + 1);
    }
}

// 4. feladat
Console.WriteLine("4. feladat \n Adja meg az ágyás sorszámát:");
int be =int.Parse(Console.ReadLine());

int darab = 0;
string szin = "";
HashSet<string> szinek = new HashSet<string>();
for (int i = 0; i < viragok.Count; i++) 
{
    if (viragok[i].BenneVanEz(be))
    {
        darab++;
        if (szin == "") 
        {
            szin = viragok[i].szin;
        }
        szinek.Add(szin);
        
    }
    Console.WriteLine("A felajánlások száma {0}", darab);
}
if (darab == 0) 
{
    Console.WriteLine("Ezt az ágyást nem ültetik be");
}
else
{
    Console.WriteLine("Viragagyas csak ha az első ültet", szin);
    Console.WriteLine("A virágágyás színei: {0}", String.Join(", ", szinek));
}

List<Adatok> szurt = viragok.Where((elem) => elem.BenneVanEz(be)).ToList();
Console.WriteLine("a felajánlók száma: {0}",szurt.Count);

if (szurt.Count==0)
{
    Console.WriteLine("Ezt az ágyást nem ültetik be");
}
else
{
    Console.WriteLine("Viragagyas csak ha az első ültet : {0}",szurt.First().szin);
    Console.WriteLine("A virágágyás színei: {0}", String.Join(" ",szurt.Select(elem => elem.szin).Distinct()));
}


List<Adatok>[] agyasok2 =new List<Adatok>[agyasDB+1];
for (int i = 1; i < agyasDB + 1; i++) 
{
    for (int k = 0; k < viragok.Count; k++) 
    {
        if (viragok[k].BenneVanEz(i)) 
        {
            agyasok2[i].Add(viragok[k]);
        }
    }
}