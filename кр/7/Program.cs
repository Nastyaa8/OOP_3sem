using System;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1a
            string str1 = "123456789101112";
            string str2 = str1.Substring(3, 5);
            Console.WriteLine(str2);

            //1б
            List<string> people = new List<string>() { "Tom", "Bob", "Sam" };
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
            partial class Date
        {
            
            public int Number { get; }

            private int month;
            
            public int Month
            {
                set
                {
                    if (value < 1 || value > 12)
                        Console.WriteLine("Месяц задан неверно");
                    else
                        month = value;
                }
                get { return month; }

            }
            
            public int Year { get; set; }

            private int balance;

            public int Balance
            {
                get { return balance; }
                set { balance = value; }
            }

        }
    }
}