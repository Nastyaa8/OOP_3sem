using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab8
{
    
    // Класс Пользователь
    public class User
    {
        public delegate void UserEventHandler(object sender, UserEventArgs e); // Делегат для обработчиков событий

        public event UserEventHandler Upgrade; // Событие обновления
        public event UserEventHandler Work;    // Событие работы

        // Вызываем событие Upgrade
        public void TriggerUpgrade(string newVersion)
        {
            Console.WriteLine($"Пользователь получил обновление до версии: {newVersion}");
            Upgrade?.Invoke(this, new UserEventArgs { Message = $"Обновление до версии {newVersion} установлено." });
        }

        // Вызываем событие Work
        public void TriggerWork(string task)
        {
            Console.WriteLine($"Пользователь начал работу: {task}");
            Work?.Invoke(this, new UserEventArgs { Message = $"Задача '{task}' выполняется." });
        }
    }

    // Класс для аргументов событий (необходим для передачи данных)
    public class UserEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    // Класс программного обеспечения (ПО)
    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public int TasksCompleted { get; set; }


        public Software(string name, string version)
        {
            Name = name;
            Version = version;
            TasksCompleted = 0;
        }

        // Реакция на обновление
        public void OnUpgrade(object sender, UserEventArgs e)
        {
            Console.WriteLine($"{Name}: {e.Message}");
            // Добавлен метод GetUpgradeVersion для получения версии
        }

        // Реакция на выполнение задачи
        public void OnWork(object sender, UserEventArgs e)
        {
            Console.WriteLine($"{Name}: {e.Message}");
            TasksCompleted++;
        }

        // Для вывода состояния объекта
        public override string ToString()
        {
            return $"{Name} (Версия: {Version}, Задач выполнено: {TasksCompleted})";
        }
    }
    //2222222222222222222222
    class StringEditor
    {
        public static string RemovePunctuation(string str)
        {
            str = Regex.Replace(str, "[.,;:]", string.Empty);
            return str;
        }
        public static string AddSymbol(string str)
        {
            return str += "Laba8";
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str)
        {
            return str.ToLower();
        }

        public static string RemoveSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }
    }
}
