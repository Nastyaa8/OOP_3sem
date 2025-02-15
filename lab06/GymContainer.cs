using lab06;
using System;
using System.Collections.Generic;
using System.Linq;


namespace lab06
{
    /*Определить класс-Контейнер для хранения разных типов объектов (в пределах иерархии) в виде 
    списка или массива (использовать абстрактный тип данных). Класс-контейнер должен содержать методы get и set для управления 
    списком/массивом, методы для добавления и удаления объектов в список/массив, метод для вывода списка на консоль.*/
    public class GymContainer
    {
        /*Подготовить Спортзал. Снарядов должно быть фиксированное количество в пределах выделенной суммы 
        денег. Провести сортировку инвентаря в Спортзале по одному из параметров*/
        private readonly int _budget;//Инкапсуляция

        public List<Inventory> InventoryList { get; private set; }// позволяет работать с динамическими коллекциями данных
        public int NumberOfEquipment { get; private set; }
        public int CurrentBudget { get; private set; }

        public GymContainer()
        {
            _budget = CurrentBudget = 1000;
            NumberOfEquipment = 0;
            InventoryList = new List<Inventory>();//параметр типа для класса 
        }
        public GymContainer(int budget)
        {
            _budget = CurrentBudget = budget;
            NumberOfEquipment = 0;//количество инвентаря 
            InventoryList = new List<Inventory>();
        }
        public GymContainer(int budget, List<Inventory> list)
        {
            _budget = budget;
            CurrentBudget = _budget - list.Sum(item => item.Cost);// Вычисляет текущий бюджет
            NumberOfEquipment = list.Count;
            InventoryList = list;
            SortInventoryList();
        }

        public void AddItem(Inventory item)
        {
            if (item.Cost > CurrentBudget)
                throw new ArgumentException();

            InventoryList.Add(item);
            CurrentBudget -= item.Cost;
            NumberOfEquipment++;
            SortInventoryList();
        }

        public void DeleteItem(Inventory item)
        {
            if (!InventoryList.Contains(item))
                throw new ArgumentException();

            InventoryList.Remove(item);

            CurrentBudget += item.Cost;
            NumberOfEquipment--;
            SortInventoryList();
        }

        public void PrintList()//выводит на консоль информацию о спортзале
        {
            Console.WriteLine(
               $"----------------------\nСпортзал:\n" +
               $"Количество снарядов: {NumberOfEquipment}\n" +
               $"Бюджет: {_budget}\n" +
               $"Текущий бюджет: {CurrentBudget}\n");

            foreach (var item in InventoryList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------------------");
        }
        private void SortInventoryList()
        {
            InventoryList = InventoryList.OrderBy(x => x.Cost).ToList();//лямбда-выражение, которое указывает, что нужно отсортировать по значению свойства
        }
    }
}
