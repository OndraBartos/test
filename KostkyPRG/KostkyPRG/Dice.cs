﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class Dice
    {
        public int diceCount;
        public Random rnd;
        public int sum;
        public Dice(int diceCount)
        {
            this.diceCount = diceCount;     //chat gtp mi poradil jak udělat správně ten Random, mně to nefungovalo,
            rnd = new Random();             //protože jsem to psal všechno dohromady do toho for cyklu a pak mi dával řadu stejnejch čísel
            sum = 0;                        //fungovalo mi určování počtu kostek ale psal mi to samý číslo dokola
            //musim nastavit sum na nulu, jinak se mi budou mezi kolama sčítat hozený čísla
        }
        public void diceThrow()
        {
            sum = 0;
            for (int i = 0; i <= diceCount - 1; i++)
            {
                int number = rnd.Next(1, 7); //7 aby tam byla zahrnutá i šestka
                //Console.Write($"{number} ");  předtím na kontrolu zda vše funguje
                sum += number;
            }
            //Console.Write('\n');              //taky jenom pro kontrolu
            //Console.WriteLine($"Calkový suočet hodnot všech kostek je: {sum}");

            //Random rnd = new Random();
            //int number = rnd.Next(1, 7);  //starší nefunkční způsob
            //Console.Write(number);
        }
        public int diceThrowValue() //tenhle int budu používat v mainu abych pak mohl počítat výsledky
        {
            return sum;
        }

    }
}
