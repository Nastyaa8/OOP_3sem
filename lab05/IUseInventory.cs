using System;
using System.Runtime.InteropServices;

namespace lab_05
{
    interface IUseInventory
    {
        void UseInventory();
        void GetInventoryType();
    }
    public class GymContainerController
    {
        private GymContainer gymContainer;

        public GymContainerController(int budget)
        {
            gymContainer = new GymContainer(budget);
        }
        public void AddInventory(Inventory item)
        {
            try
            {
                gymContainer.AddItem(item);
                Console.WriteLine($"Инвентарь '{item.Name}' успешно добавлен.");
            }
            catch (CostException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
