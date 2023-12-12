﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    //2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
    //Přidej třídě BankAccount čtyři proměnné - accountNumber jako číslo účtu
    //                                        - holderName jako jméno osoby, které účet patří
    //                                        - currency jako měna, ve které je účet vedený
    //                                        - balance jako zůstatek na účtu

    //Přidej třídě BankAccount čtyři funkce  - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
    //                                       - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
    //                                           (Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.)
    //                                       - Transfer, která jako vstupní parametry přijme množství peněz a číslo účtu, na které se budou peníze posílat, a převede peníze
    //                                         z jednoho účtu na druhý(opět pouze pokud je na účtu, ze kterého převod jde, dostatek peněz)

    //Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry - jméno majitele účtu a měnu, ve které bude účet vedený
    //                                                                           - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
    //vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu

    internal class BankAccount
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public float balance;

        public BankAccount(int accountNumber, string holderName, string currency, float balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }

        public void Deposit()
        {
            Console.WriteLine("Zadejte částku, kterou chcete vložit na účet");
            string a = Console.ReadLine();
            float x = float.Parse(a);
            balance = balance + x;
            Console.WriteLine($"váš nový zůstatek na účtu je: {balance}");
        }
        public void Withdraw()
        {
            Console.WriteLine("Zadejte částku, kterou chcete vybrat z účtu");
            string b = Console.ReadLine();
            float y = float.Parse(b);
            if(balance >= y) 
            {
                balance = balance - y;
                Console.WriteLine($"váš nový zůstatek na účtu je: {balance}");
            }
            else 
            {
                Console.WriteLine("Nemáte dostatečný zůstatek na váš požadovaný výběr");
            }
        }

    }
}
