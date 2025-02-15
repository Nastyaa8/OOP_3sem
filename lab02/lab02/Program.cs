using System;
using System.Collections.Generic;//List<T>, Dictionary<TKey, TValue>
using System.Linq;
using System.Text;
using System.Threading.Tasks;//асинхронные классы
using System.Globalization;//для работы с региональными классами
using Cars;

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus(712, 23, 1990, 74, "Соленок", "А.А.");//Фамилия и инициалы водителя, Номер автобуса, Номер маршрута, Марка, Год начала эксплуатации, Пробег
            Bus[] busPark = new Bus[4];
            busPark[0] = bus1;
            busPark[1] = new Bus(7, 5, 2001, 199, "Сахаревич", "К.Д.", "Mercedes");
            busPark[2] = new Bus(102, 34, 2022, 10, "Кирпичеко", "V.A.");
            busPark[3] = new Bus(87, 5, 2010, 530);

            foreach (Bus bus in busPark)
            {
                Console.WriteLine(bus.ToString());
                Console.WriteLine('\n');
            }
            //фильтрация
            int currentRoute = 5;
            Console.WriteLine("Автобусы с номером маршрута " + currentRoute);
            Console.WriteLine();
            foreach (Bus bus in busPark)
            {
                if (bus.RouteNumber == currentRoute)
                {
                    Console.WriteLine(bus.ToString());
                    Console.WriteLine('\n');
                }
            }

            int currentAge = 20;
            Console.WriteLine("Автобусы возрастом более " + currentAge + " лет\n");

            foreach (Bus bus in busPark)
            {
                if (bus.GetAgeOfBus() > currentAge)
                {
                    Console.WriteLine(bus.ToString());
                    Console.WriteLine('\n');
                }
            }



        }
    }
}