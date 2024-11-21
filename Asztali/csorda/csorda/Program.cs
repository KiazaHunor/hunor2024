//class tenyesz allatokrol, az allatnak legyen neve es sulya, meg ara.
//Legyen egy masik osztaly ami a farmon nevre hallgat amiben tobb allat vehet reszt
//Legyen olyan fuggvenye ami kiszamolja azt ossz erteket es az ossz sulyat.
//Es ennek az osztalynak meg kell csinalnu a + es- operatorokat ,
//ugy hogy ha egy masik csordat afdunk hozza akko a kettot egyesitse,
//ha egy allatot akkor azt az egyet adja hozzza a listahoz.
//Kivonaskor ha van az az allat akkor vonja csak ki,
//ha csordat vonunk akkor az osszes elemet vonja ki.


namespace csorda
{

     internal class Program 
    {
        static void Main(string[] args) 
        {
            Allat a1 = new Allat("Bimbó", 300, 2000);
            Console.WriteLine(a1);


            Csorda cs1 = new Csorda();
            Csorda cs2 = new Csorda(a1);
            Csorda cs3 = new Csorda(cs2);
            Console.WriteLine(cs3.tagok.Count);

            Csorda cs4 = cs2 + a1;
            Console.WriteLine(cs4.tagok);
            cs4.kiir();
        }
    }   
    
}