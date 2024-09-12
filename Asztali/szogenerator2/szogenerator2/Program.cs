
using System.Diagnostics.Tracing;

internal class Program 
    {
        static int szamBekeres(int minimum=3,int maximum = 15) 
        {
        if(minimum > maximum) 
        {
            throw new ArgumentException("A minimum nem lehet nagyobb mint a maximum!");

        }   
        int szam = 0;
        while (szam == 0) 
        {
            try
            {
                Console.Write("Kérek egy egész számot {0} és {1} között: ", minimum, maximum);
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam < minimum || szam > maximum)
                {
                    throw new Exception();
                }
            }
            catch
            {
                szam = 0;
            }
        }
        
            
            return szam;
        }
        static string szoGeneralas(int hossz) 
        {
        string[] betuk = { "euioőúóüöaéáűí","qwrtzplkjhgfdsyxcvbnm" };
         Random random = new Random();
        int melyikJon = random.Next(2);


        string vissza = "";
        for (int i = 0; i < hossz; i++) 
        {

            vissza += betuk[melyikJon][random.Next(betuk[melyikJon].Length)];
        }

        return vissza;
        }

        static List<string> sokSzo(int hossz, int darab=200) 
        {
            List<string> vissza = new List<string>();
            for (int i = 0; i < darab; i++)
            {

            vissza.Add(szoGeneralas(hossz));

            }
            return vissza;
        }

        static void filebaIr(List<string> szavak) 
        {
            StreamWriter ir =new StreamWriter("sok-sok-szo.txt");        
            for(int i = 0;i < szavak.Count; i++) 
            {
                ir.WriteLine(szavak[i]);
            }
            ir.Close();
        }
        static void Main(string[] args) 
        {
            int betuSzam = szamBekeres(5, 10);
            //Console.WriteLine(szoGeneralas(6));
            List<string> szavak = sokSzo(betuSzam);
            filebaIr(szavak);
            //Console.WriteLine(szavak[45]);

        }

        static string mondatIr() 
        {
        
            
        
        }
    }