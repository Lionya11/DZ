﻿using System;

namespace BBVBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            bool Work = true;
            Console.WriteLine("--> Открыть счёт" + " \nВнести деньги" + "\nСнять деньги" + "\nПеревести деньги" + "\nВзять кредит" + "\nПомощь" + "\nАвторы");
            while (Work == true)
            {
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'w')
                {
                    m++;
                }

                if (m == 8)
                {
                    m = 1;
                }
                if (m == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--> Открыть Счёт");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Открыть Счёт");
                }
                if (m == 2)
                {
                    Console.WriteLine("--> Внести деньги");
                }
                else
                {
                    Console.WriteLine("Внести деньги");
                }
                if (m == 3)
                {
                    Console.WriteLine("--> Снять деньги");
                }
                else
                {
                    Console.WriteLine("Снять деньги");
                }
                if (m == 4)
                {
                    Console.WriteLine("--> Перевести деньги");
                }
                else
                {
                    Console.WriteLine("Перевести деньги");
                }
                if (m == 5)
                {
                    Console.WriteLine("--> Взять кредит");
                }
                else
                {
                    Console.WriteLine("Взять кредит");
                }
                if (m == 6)
                {
                    Console.WriteLine("--> Помощь");
                }
                else
                {
                    Console.WriteLine("Помощь");
                }
                if (m == 7)
                {
                    Console.WriteLine("--> Авторы");
                    if (key == 'e') {
                        Console.Clear();
                        Console.WriteLine("Главный программист - Шишков Степан" + "\nПрограммисты:" + "\nКислицин Вадим" + "\nКоннов Леонид");
                    }
                    if (key == 'q')
                    {
                        Console.Clear();
                        Console.WriteLine("--> Открыть счёт" + " \nВнести деньги" + "\nСнять деньги" + "\nПеревести деньги" + "\nВзять кредит" + "\nПомощь" + "\nАвторы");
                    }
                }
                else
                {
                    Console.WriteLine("Авторы");
                }
            }
        }
    }
}