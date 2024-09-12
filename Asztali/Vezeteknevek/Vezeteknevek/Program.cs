/*vezetéknevek 100db, véletlenszerű nevek generálása, egy vagy két keresztnév, eredmények fájlba írása, ady-s példával email generálása*/



StreamReader nev = new StreamReader("vezetek.txt");

string vezetek;


while(vezetek = nev.ReadLine()) 
{
    Console.WriteLine(vezetek);
}




Random elso = new Random();

int random = elso.Next("vezetek.txt");


Console.ReadKey();




