using System.Text.RegularExpressions;


string szoveg = File.ReadAllText("szoveg.txt");

Regex minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

Regex minta2 = new Regex(@"(GET)\s(.+)HTTP/");

var talalat = minta2.Matches(szoveg);
Console.WriteLine(talalat.Count);

foreach (Match elem in talalat) 
{
    Console.WriteLine(elem);
}





