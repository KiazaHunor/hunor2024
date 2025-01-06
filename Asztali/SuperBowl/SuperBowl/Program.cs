StreamReader olvas = new StreamReader("SuperBowl.txt");

List<string> ssz = new List<string>();
List<string> datum = new List<string>();
List<string> gyoztes = new List<string>();
List<string> eredmeny = new List<string>();
List<string> vesztes = new List<string>();
List<string> helyszin = new List<string>();
List<string> varosallam = new List<string>();
List<string> nezoszam = new List<string>();



while (!olvas.EndOfStream) 
{
    string line = olvas.ReadLine();
    string[] vag = line.Split(",");
}
olvas.Close();
