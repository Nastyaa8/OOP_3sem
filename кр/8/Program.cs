using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    enum months
    { jan=1, feb, mar, apr, may, jun, jul, aug, sept, oct, nov, dec }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(months.jan);
            Console.WriteLine((int)months.feb);
            Console.WriteLine((int)months.mar);
            Console.WriteLine((int)months.apr);
            Console.WriteLine((int)months.may);
            Console.WriteLine((int)months.jun);
            Console.WriteLine((int)months.jul);
            Console.WriteLine((int)months.aug);
            Console.WriteLine((int)months.sept);
            Console.WriteLine((int)months.may);

            Console.WriteLine((int)months.nov);
            Console.WriteLine((int)months.dec);

            string str = "123.345.678";
            string[] words = str.Split(new char[] { '.' });        
            foreach (string s in words) Console.WriteLine(s);

           Computer c1 = new Computer();
            Computer c2 = new Computer();
            c1.number = 3;
            c2.number = 4;
            IComparable cc1 = c1;
            int i=cc1.CompareTo(c2);

            
            

            Console.ReadLine();
        }
        class Computer : IComparable
        {
            public static readonly int op = 512;
            public static int freq = 4;
            public int number;

            int IComparable.CompareTo(Object other)
            {
                Computer c = other as Computer;
                if (c.number == this.number)
                {
                    Console.WriteLine("Объекты равны");
                    return 0;
                }
                if (c.number > this.number)
                {
                    Console.WriteLine($"{c.number} больше чем {this.number}");
                    return 1;
                }
                else
                {
                    Console.WriteLine($"{c.number} меньше чем {this.number}");
                    return -1;
                }
            }
               int IGood.Fine(Something other)
            { 
                Something som=other as Something;
                if (other == null) {return 1;}
                
            } 
                public interface IGood
            {
                void Fine();
            }
            abstract class Something
            {
                



            }

            abstract void ItsOk()
            {





            }



                }
            }
            }
        
        
    
