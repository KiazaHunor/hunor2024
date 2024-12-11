using System.Text.RegularExpressions;

class Program
{


    /*
    static IEnumerable<string> TestCases
    {
        get
        {
            yield return "192.168.0.1";
            yield return "255.255.255.255";
            yield return "265.265.265.267";


        }
    }
    */


    static void Main(string[] args)
    {

        const string ipv4Pattern = @"^(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])(\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])){3}$";

        var expression = new Regex(ipv4Pattern, RegexOptions.Compiled);

        string forras = "szoveg.txt";

        var sorok = File.ReadAllLines(forras);

        bool ip = expression.IsMatch(forras);
        Console.WriteLine(sorok);


        Console.WriteLine($"{forras} - IPv4: {expression}");

    }
}


