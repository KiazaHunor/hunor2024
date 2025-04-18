﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Romaisorszam
    {
        class RomaiSorszam
        {
            public string RomaiSsz { get; private set; }

            private static Dictionary<char, int> RomaiMap = new Dictionary<char, int>()
    {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };

            public string ArabSsz
            {
                get
                {
                    int ertek = 0;
                    string romaiSzam = RomaiSsz.TrimEnd('.');
                    for (int i = 0; i < romaiSzam.Length; i++)
                    {
                        if (i + 1 < romaiSzam.Length &&
                            RomaiMap[romaiSzam[i]] < RomaiMap[romaiSzam[i + 1]])
                        {
                            ertek -= RomaiMap[romaiSzam[i]];
                        }
                        else
                        {
                            ertek += RomaiMap[romaiSzam[i]];
                        }
                    }
                    return $"{ertek}.";
                }
            }

            public RomaiSorszam(string romaiSsz)
            {
                RomaiSsz = romaiSsz.ToUpper();
            }
        }

    }
}
