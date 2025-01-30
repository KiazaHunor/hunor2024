using parkerdo;

List<Adatok> viragok = new List<Adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");

int agyasDB=int.Parse(sorok[0]);

for (int i = 1; i < sorok.Length; i++) 
{
    viragok.Add(new Adatok(sorok[i]));
}