
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

Console.WriteLine(fakt(5));

static int fakt(int szam) 
{

    int eredmeny = 1;
    if (szam > 1) 
    {
    
        eredmeny= fakt(szam-1);
    }
    else
    {
        return 1;
    }
    return szam * eredmeny;
}

static BigInteger fakt2(int szam, BigInteger elozo) 
{
    BigInteger eredmeny = 1;
    if (szam > 1)
    {
        eredmeny = fakt2(szam - 1, elozo * szam);
    }
    else 
    {
        return 1;
    }
}