

Console.WriteLine("Hello, World!");

StreamReader vers = new StreamReader("janos.txt");


string line;

while ((line = vers.ReadLine()) != null)
{
    Console.WriteLine(line);
}


Dictionary<string, string> openWith =
    new Dictionary<string, string>();
    openWith.Add("txt", "notepad.exe");


