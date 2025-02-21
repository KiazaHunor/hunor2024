using System;
using System.Collections.Generic;
using System.IO;

namespace tanciskola
{
    class Program
    {
        static void Main()
        {
            List<tancok> tancLista = new List<tancok>();

            string fajl = "tancrend.txt";
            
            if (File.Exists(fajl))
            {
                string[] sorok = File.ReadAllLines(fajl);
               

                for (int i = 0; i < sorok.Length; i += 3)
                {
                    string tancnev = sorok[i];
                    string lany = sorok[i + 1];
                    string fiu = sorok[i + 2];

                    tancLista.Add(new tancok(fiu, lany, tancnev));
                }

                
                if (tancLista.Count > 0)
                {
                    Console.WriteLine("2. feladat:");
                    Console.WriteLine($"Az első bemutatott tánc: {tancLista[0].tancnev}");
                    Console.WriteLine($"Az utolsó bemutatott tánc: {tancLista[^1].tancnev}");
                }
                int sambaParok = tancLista.Count(t => t.tancnev == "samba");
                Console.WriteLine("\n3. feladat:");
                Console.WriteLine($"A sambát {sambaParok} pár mutatta be.");
            }
        }
    }
}
