﻿using rgb;

//Console.WriteLine("buzi");

List<Pixel> pontok = new List<Pixel>();
StreamReader olvas = new StreamReader("kep.txt");

int x = 1;
int y = 1;

while (!olvas.EndOfStream) 
{
    string line = olvas.ReadLine();
    string[] vag = line.Split(" ");
    x = 1;

    for (int i = 0; i < vag.Length; i+=3) 
    {
        int r=int.Parse(vag[i]);
        int g=int.Parse(vag[i+1]);
        int b=int.Parse(vag[i+2]);
        pontok.Add(new Pixel(x,y,new szin(r,g,b)));
        x++;
    }
    y++;
}
olvas.Close();

Console.WriteLine("2.feladat");
Console.WriteLine("Kérem egy képpont adatait");
Console.Write("Sor:");
int sor = int.Parse(Console.ReadLine());
Console.Write("Oszlop:");
int oszlop = int.Parse(Console.ReadLine());

var talalat = pontok.Where(pont => pont.x == oszlop && pont.y == sor).ToList().First();

Console.WriteLine("A képpont színe ({0})",talalat.rgb);


var vilagosok = pontok.Where(pont => pont.rgb.vilagos()).ToList();
int vilagosok2 = pontok.Where(pont => pont.rgb.vilagos()).ToList().Count;

Console.WriteLine("3. feladat: \r\n A világos képpontok száma: {0}",vilagosok.Count);

int minSzin=pontok.Min(pont => pont.rgb.osszeg());
Console.WriteLine("4.feladat: a legsötétebb szín {0}",minSzin);

List<string> sotetek = pontok //összes képpont
                       .Where(pont => pont.rgb.osszeg() == minSzin) //legsötétebb képpontok
                       .Select(pont => pont.rgb.ToString()) //csak a színek legyenek
                       .ToList(); //legyen lista a halmazból

Console.WriteLine("A legsötétebb pixelek színe {0}");
Console.WriteLine(String.Join("\n",sotetek));

//linkkel az aktualis elem rgb tulajdonsaganak a B értéke és a következő elem mezőjének B komponense között  a különbség nagyobb e mint az elteres parameter.
static bool hatar(int sor,int elteres) 
{
    return true;
}