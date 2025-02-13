using rgb;

Console.WriteLine("buzi");

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
Console.WriteLine("Sor:");
int sor = int.Parse(Console.ReadLine());
Console.WriteLine("Oszlop:");
int oszlop = int.Parse(Console.ReadLine());

var talalat = pontok.Where(pont => pont.x == oszlop && pont.y == sor).ToList()[0];

Console.WriteLine("A képpont színe {0}",talalat);
