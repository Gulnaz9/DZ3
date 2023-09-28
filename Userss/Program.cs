using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userss
{   enum DaysOfWeek
    {
       Понедельник = 1,
       Вторник,
       Среда,
       Четверг,
       Пятница,
       Суббота,
       Воскресенье,
    }
    enum Cards
    {
        Шестёрка = 6,
        Семёрка,
        Восьмёрка,
        Девятка,
        Десятка,
        Валет,
        Дама,
        Король,
        Туз,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 2\nИгральным картам присвоены порядковые номера: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.\nОпределить достоинство соответствующей карты.");
            try
            {
                Console.WriteLine("Введите номер карты");
                Cards k = (Cards)int.Parse(Console.ReadLine());
                switch (k)
                {
                 case (Cards)6: Console.WriteLine((Cards)6); break;
                 case (Cards)7: Console.WriteLine((Cards)7); break;
                 case (Cards)8: Console.WriteLine((Cards)8); break;
                 case (Cards)9: Console.WriteLine((Cards)9); break;
                 case (Cards)10: Console.WriteLine((Cards)10); break;
                 case (Cards)11: Console.WriteLine((Cards)11); break;
                 case (Cards)12: Console.WriteLine((Cards)12); break;
                 case (Cards)13: Console.WriteLine((Cards)13); break;
                 case (Cards)14: Console.WriteLine((Cards)14); break;
                 default: Console.WriteLine("Вы ввели несуществующее значение карты"); break;
                }
            }
            catch (FormatException)
            { Console.WriteLine("Вы ввели не число"); }
            finally { Console.WriteLine("Программа запущена успешно)"); }


            Console.WriteLine("Упр 3\nПринимает на входе строку и производит выходные данные");
            Console.WriteLine("Введите данные в соответствии с таблицей");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "jabroni": Console.WriteLine("Patron Tequila");break;
                case "school counselor":Console.WriteLine("Anything wint Alcohol");break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;
            }



            Console.WriteLine("Упр 4\nВыводит на экран название дня недели");
            try
            { Console.WriteLine("Введите номeр дня недели");
              DaysOfWeek Day = (DaysOfWeek)int.Parse(Console.ReadLine());
              switch (Day)
              {
                case (DaysOfWeek)1: Console.WriteLine((DaysOfWeek)1); break;
                case (DaysOfWeek)2: Console.WriteLine((DaysOfWeek)2); break;
                case (DaysOfWeek)3: Console.WriteLine((DaysOfWeek)3); break;
                case (DaysOfWeek)4: Console.WriteLine((DaysOfWeek)4); break;
                case (DaysOfWeek)5: Console.WriteLine((DaysOfWeek)5); break;
                case (DaysOfWeek)6: Console.WriteLine((DaysOfWeek)6); break;
                case (DaysOfWeek)7: Console.WriteLine((DaysOfWeek)7); break;
                default: Console.WriteLine("Вы ввели несуществующий номер дня"); break;

              }
            }
            catch (FormatException)
            { Console.WriteLine("Вы ввели не число"); }
        }
    }
}
