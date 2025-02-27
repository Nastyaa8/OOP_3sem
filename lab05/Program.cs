﻿using System;

namespace lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory bench = new Bench("Скамейка №1", 134);
            Inventory bars = new Bars("Брусья №1", 158);
            Inventory mat = new Mats("Мат №1", 120);
            Inventory mat1 = new Mats("Maт №2", 130);
            Ball ball = new Ball("Футбольный мяч");
            BasketballBall basketballBall = new BasketballBall("Баскетбольный мяч", 7, 50);
            GymContainer gym = new GymContainer(900);
            gym.AddItem(bench);
            gym.AddItem(bars);
            gym.AddItem(mat);
            gym.AddItem(mat1);
            gym.AddItem(ball);
            gym.AddItem(basketballBall);
            gym.PrintList();
            gym.DeleteItem(mat1);
            gym.PrintList();


        }
    }
}
