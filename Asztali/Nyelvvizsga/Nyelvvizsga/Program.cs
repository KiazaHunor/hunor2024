using Nyelvvizsga;



static void Main(string[] args)
{
    List<NyelvAdat> sikeresek = new List<NyelvAdat>();
    List<NyelvAdat> sikertelenek = new List<NyelvAdat>();

    sikeresek = fileBetolt("sikeres.csv");
    sikertelenek = fileBetolt("sikertelen.csv");

    List<NyelvAdat> kozos = new List<NyelvAdat>();
    for (int i = 0; i < sikeresek.Count; i++) 
    {
        sikeresek[i].osszesVizsgazo
    }
}

    static List<NyelvAdat> fileBetolt(string filename) 
    {
        List<NyelvAdat> adatok = new List<NyelvAdat>();

        StreamReader olvas = new StreamReader(filename);

        string elsoSor=olvas.ReadLine();
        string[] vag = elsoSor.Split(";");

        int[] evSzamok = new int[vag.Length - 1];

        for (int i = 0; i < vag.Length; i++) 
        {
            evSzamok[i - 1] = int.Parse(vag[i]);
        }


        while (!olvas.EndOfStream) 
        {
            adatok.Add(new NyelvAdat(olvas.ReadLine(), evSzamok));
        }



        olvas.Close();
    }
