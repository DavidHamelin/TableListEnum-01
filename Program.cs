﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }

            /*
            string[] week1 = new string[7];
            week1[0] = "Lundi";
            week1[1] = "Mardi";
            week1[2] = "Mercredi";
            week1[3] = "Jeudi";
            week1[4] = "Vendredi";
            week1[5] = "Samedi";
            week1[6] = "Dimanche";
            */
        }
    }
}
