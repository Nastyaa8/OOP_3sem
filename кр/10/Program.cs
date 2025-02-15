using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public enum Day
    {
        Пн,Вт,Ср,Чт,Пт,Сб,Вс,
    }
    public class Program
    {

        static void Main(string[] args)
        {
            foreach (Day day in Enum.GetValues(typeof(Day)))
            {
                Console.WriteLine(day);
            }
            int[] array = new int[] { 1, 2, 4 };
            string s = String.Join("", array);
            Console.WriteLine(s);
        }
            public class Computer : IComparable<Computer>
        {
            public string Processor { get; set; }
            public int Ram { get; set; }  
            public double Price { get; set; }  

            
            public Computer(string processor, int ram, double price)
            {
                Processor = processor;
                Ram = ram;
                Price = price;
            }

            
            public int CompareTo(Computer other)
            {
                if (other == null) return 1;

                
                if (this.Price < other.Price)
                {
                    return -1;  
                }
                else if (this.Price > other.Price)
                {
                    return 1;   
                }
                else
                {
                    return 0;   
                }
            }

            
            public override string ToString()
            {
                return $"Computer {{ Processor = {Processor}, RAM = {Ram} GB, Price = {Price} USD }}";
            }

            
            public static void Main()
            {
                
                Computer comp1 = new Computer("Intel Core i7", 16, 1200.0);
                Computer comp2 = new Computer("AMD Ryzen 7", 16, 1000.0);

                
                Console.WriteLine("Компьютер 1: " + comp1);
                Console.WriteLine("Компьютер 2: " + comp2);

                int comparison = comp1.CompareTo(comp2);
                if (comparison < 0)
                {
                    Console.WriteLine("Компьютер 1 дешевле Компьютера 2");
                }
                else if (comparison > 0)
                {
                    Console.WriteLine("Компьютер 1 дороже Компьютера 2");
                }
                else
                {
                    Console.WriteLine("Компьютеры равны по цене");
                }
            }
        }
    }
    }

