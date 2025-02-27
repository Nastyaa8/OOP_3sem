﻿using System;

namespace lab07
{
    /*4) Определить пользовательский класс, который будет использоваться в 
    качестве параметра обобщения. Для пользовательского типа взять класс из 
    лабораторной №4 «Наследование». */
    public class Bars
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Bars()
        {
            Name = "Брусья";
            Cost = 100;
        }
        public Bars(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public void TakeItem()
        {
            Console.WriteLine("Взяты брусья");
        }

        public void UseInventory()
        {
            Console.WriteLine("Вы использовали брусья");
        }
        public void GetInventoryType()
        {
            Console.WriteLine("Это брусья");
        }

        public override string ToString()
        {
            return $"название: {this.Name}, цена: {this.Cost}\n";
        }
    }

}