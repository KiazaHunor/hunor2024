using System.Text.RegularExpressions;


string szoveg = File.ReadAllText("szoveg.txt");

Regex minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

var talalat = minta.Matches(szoveg);
Console.WriteLine(talalat.Count);

foreach (Match elem in talalat) 
{
    Console.WriteLine(elem);
}

Regex minta2 = new Regex(@"");


