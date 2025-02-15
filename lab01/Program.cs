using System;
using System.Linq;
using System.Text;


namespace lab01
{
     class Program
    {
        static void Main(string[] args)
        {
            int _int = 100;
            float f1 = 128.74F;
            double d1 = 12.32;
            char c1 = '$';
            bool b1 = true;
            Console.WriteLine($"Число типа int = {_int}");
            Console.WriteLine($"Число типа float = {f1}");
            Console.WriteLine($"Число типа double = {d1}");
            Console.WriteLine($"Число типа char = {c1}");
            Console.WriteLine($"Число типа bool = {b1}");
            Console.WriteLine("------------Явные приведения---------------");
            double d2 = 128.4;
            int i2= (int)d2;//1
            Console.WriteLine(i2);
            Console.WriteLine(d2);
            byte b2= (byte)i2;//2
            Console.WriteLine(b2);
            bool b3 = Convert.ToBoolean(d2);//3
            Console.WriteLine(b3);
            float f2=(float)d2;//4
            Console.WriteLine(f2);
            char c2=(char)d2;//5
            Console.WriteLine(c2);
            Console.WriteLine("------------Неявные приведения---------------");
            byte bt1 = 12;
            Console.WriteLine(bt1);
            short s1=bt1;//1
            Console.WriteLine(s1);
            int i1=bt1;//2
            Console.WriteLine(i1);
            decimal dec1 = s1;//3
            Console.WriteLine(dec1);
            double db1 = i1;//4
            Console.WriteLine(db1);
            float f3=i1;//5
            Console.WriteLine(f3);
            Console.WriteLine("-------------Упаковка и распаковка--------------");
            double db2 = 33.33;
            object o1 = db2;//упаковка
            Console.WriteLine(o1);
            int i4= Convert.ToInt32(o1);//распаковка
            Console.WriteLine(i4);
            Console.WriteLine("--------------Неявно типизированная переменная-------------");
            var i = "Hello";
            Console.WriteLine(i);
            Console.WriteLine("--------------Nullable-------------");
            int? u = null;
            u = 99;
            Console.WriteLine(u.GetValueOrDefault());
            u= null;
            Console.WriteLine(u.GetValueOrDefault(33));
            Console.WriteLine("--------------Строки-------------");
            string str1 = "Mrrr";
            string str2 = "Gav-Gav";
            string str3 = "Kva-Kva";
            Console.WriteLine(String.Equals(str1,str2));
            Console.WriteLine(str1+" "+str2);
            string str4=string.Concat(str1," ",str2," ",str3,"!");
            Console.WriteLine(str4);
            string str5 = "Всем привет!";

        }

    }
}
