
using operatorok;


Pont p1 = new Pont(1, 1);
Pont p2 = new Pont(2, 3);
Console.WriteLine(p1 + p2);
Console.WriteLine(p1 + 10);
Console.WriteLine(10 + p2);

Console.WriteLine(p1 - p2);
Console.WriteLine(p1 - 10);
Console.WriteLine(10 - p2);

Console.WriteLine(p1 * p2);
Console.WriteLine(p1 * 10);
Console.WriteLine(10 * p2);

Console.WriteLine(p1 / p2);
Console.WriteLine(p1 / 10);
Console.WriteLine(10 / p2);

Console.WriteLine(p2++);
Console.WriteLine(++p2);

//Console.WriteLine(p2--);
//Console.WriteLine(--p2);

Console.WriteLine(p1.Equals(1));
Console.WriteLine(p1.Equals(" "));
Console.WriteLine(p1.Equals(new Random()));
Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.Equals(p1));
Console.WriteLine(p1.Equals(new Pont(1,1)));

Console.WriteLine(p1 == p2);
Console.WriteLine(p1 != p2);