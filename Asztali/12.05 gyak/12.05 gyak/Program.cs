using System.Text.RegularExpressions;

class Program
{
    const string emailPattern = @"[^@]+\@[^\.]+\..+";

    static IEnumerable<string> TestCases
    {
        get
        {
            yield return "user@test.com";
            yield return "test.com";
            yield return "user@.com";
            yield return "user@1234.com";
            yield return "12elemer@server.be";
            yield return "valaki@mymail.hu";
        }
    }

    static void Main(string[] args)
    {
        var expression = new Regex(emailPattern, RegexOptions.Compiled);

        foreach (var testcase in TestCases)
        {
            bool match = expression.IsMatch(testcase);
            Console.WriteLine("{0} match status: {1}", testcase, match);
        }

        Console.ReadKey();
    }
}