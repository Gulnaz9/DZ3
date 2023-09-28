using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Упражнение 4.1; преобразовать число в день и месяц");
            try
            {
                Console.WriteLine("Введите число от 1 до 365:");
                uint num = Convert.ToUInt32(Console.ReadLine());
                DateTime Date = new DateTime().AddDays(num - 1);
                string d = Date.ToString("M");
                Console.WriteLine(d);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: счёт дней начинается с 1");
            }



            Console.WriteLine("Упражнение 4.2; упр 1 с учётом исключений");
            try
            {
                Console.WriteLine("Введите число от 1 до 365:");
                uint num = Convert.ToUInt32(Console.ReadLine());
                if (num > 365)
                {
                    Console.WriteLine("В году 365 дней");
                }
                else
                {
                    DateTime Date = new DateTime().AddDays(num - 1);
                    string d = Date.ToString("M");
                    Console.WriteLine(d);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: счёт дней начинается с 1");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число не из диапазона [1;365]");
            }*/



            Console.WriteLine("Дз 4.1; предыдущие задания с учетом високосного года");
            try
            {
                Console.WriteLine("Введите число от 1 до 365/366:");
                int Num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год:");
                uint year = Convert.ToUInt32(Console.ReadLine());
                double ost1 = (double)year % 4;
                double ost2 = (double)year % 100;
                double ost3 = (double)year % 400;

                if ((ost1 == 0 && ost2 != 0) || ost3 == 0)
                {
                    //високосный год
                    int[] monthsLength = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    int sum = 0;
                    int i = 0;
                    while (sum < Num) sum = sum + monthsLength[i++];
                    sum = sum - monthsLength[--i];
                    sum = Num - sum;
                    Console.WriteLine($"{sum}.{i + 1}.{year}");
                }
                else
                {
                    //не високосный
                    int[] monthsLength = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    int sum = 0;
                    int i = 0;
                    while (sum < Num) sum = sum + monthsLength[i++];
                    sum = sum - monthsLength[--i];
                    sum = Num - sum;
                    Console.WriteLine($"{sum}.{i + 1}.{year}");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Год или число дня введены неверно");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Год или число дня введены неверно");

            }
        }
    }
}
