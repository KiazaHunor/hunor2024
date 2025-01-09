int napok_szama = 12;
int[] homersekletek = [-12, -9, -5, -2, 0, 2, 4, 6];

int fagyosnap = 0;

int nap = 0;

for (int i = 0; i < napok_szama; i++) 
{
    if (homersekletek[i] < 0) 
    {
        fagyosnap++;
        
    }
}
Console.WriteLine(fagyosnap);