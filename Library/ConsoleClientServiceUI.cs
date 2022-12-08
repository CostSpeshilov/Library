using LibraryLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole
{
    internal class ConsoleClientServiceUI : IClientServiceUI
    {
        private string name = string.Empty;
        private string surname = string.Empty;

        public string Name => name;

        public string Surname => surname;

        string selectedCommand = string.Empty;
        public int GetCommand()
        {
            return Int32.Parse(selectedCommand);
        }

        public void ShowInterfaceInformation()
        {
            Console.WriteLine("Войдите или зарегистрируйтесь");
            Console.WriteLine("1. Войти");
            Console.WriteLine("2. Зарегистрироваться");
            selectedCommand = Console.ReadLine() ?? string.Empty; 
            Console.WriteLine("Введите Ваше имя:");
            name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Введите Вашу фамилию:");
            surname = Console.ReadLine() ?? string.Empty;
        }

        public void ShowCurrentClient(Client currentClient)
        {
            Console.WriteLine($"Вы зашли как {currentClient.Name} {currentClient.SurName}");
        }
    }
}
