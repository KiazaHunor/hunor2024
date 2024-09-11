static List<string> fuggveny()
{



    List<string> lista = new List<string>();
    StreamReader beker = new StreamReader("forras.txt");

    while (!beker.EndOfStream)
    {
        string sor = beker.ReadLine();
        lista.Add(sor);
    }
    Console.WriteLine(lista.Count);
    beker.Close();
    return lista;
}
static List<string> szavak(List<string> lista3)
{
    return lista3;
}

List <string> lista2 = fuggveny();

Console.WriteLine(lista2.Count);   



/*
for(int i = 0; i < lista.Count; i++) 
{
    if(lista.Count) 
    {
        Console.WriteLine(lista[i]);
    }
    
    
}*/