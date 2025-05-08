using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

string text = File.ReadAllText("szoveg.txt");

Regex doga = new Regex(@"(\S+) - - \[(.+)] ""(\S+)(/\S+) (.+)"" (\d+) (\d+) ""(https://\S+|-)"" ""(.+)""");




var matchel = doga.Matches(text);


foreach (Match m in matchel) 
{
    Console.WriteLine(m.Groups[1]);
    Console.WriteLine(m.Groups[2]);
    Console.WriteLine(m.Groups[3]);
    Console.WriteLine(m.Groups[4]);
    Console.WriteLine(m.Groups[5]);
    Console.WriteLine(m.Groups[6]);
}



