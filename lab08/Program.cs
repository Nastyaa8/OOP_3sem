using System;
using lab8;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Software software1 = new Software("Multisim", "1.0");
            Software software2 = new Software("Visual Studio", "0.9");
            Software software3 = new Software("Microsoft", "1.2");

            // Подписываем объекты на события
            user.Upgrade += software1.OnUpgrade;
            user.Work += software1.OnWork;
            user.Upgrade += software2.OnUpgrade;
            user.Work += software3.OnWork;

            // Проверка состояния ДО событий
            Console.WriteLine("Состояние ПО до событий:");
            Console.WriteLine(software1);
            Console.WriteLine(software2);
            Console.WriteLine(software3);
            Console.WriteLine();

            // Вызываем события
            user.TriggerUpgrade("");
            user.TriggerWork("Задача 1");
            user.TriggerWork("Задача 2");

            // Проверка состояния ПО ПОСЛЕ событий
            Console.WriteLine("\nСостояние ПО после событий:");
            Console.WriteLine(software1);
            Console.WriteLine(software2);
            Console.WriteLine(software3);


            //22222
            Func<string, string> A;
            string str = "Nastya; Solenok.: Alexandrovna,";

            Console.WriteLine($"\n\nСтрока: {str}");
            A = StringEditor.RemovePunctuation;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.AddSymbol;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.ToUpper;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.ToLower;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.RemoveSpace;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);

        }
    }

}
