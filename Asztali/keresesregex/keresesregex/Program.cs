using System.Text.RegularExpressions;


string text = File.ReadAllText("szoveg.txt");

Regex minta = new Regex(@"https://www\.\S+\.\S+");

var talalat = minta.Matches(text);
Console.WriteLine(talalat.Count);
foreach (Match elem in talalat)
{
    Console.WriteLine(elem);
}
