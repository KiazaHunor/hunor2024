using StreamReader reader = new("100 név.txt");

string text = reader.ReadToEnd();

Console.WriteLine(text);