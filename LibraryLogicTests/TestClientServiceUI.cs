using LibraryLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicTests
{
    internal class TestClientServiceUI : IClientServiceUI
    {
        public string Name => "Иван";

        public string Surname => "Иванов";

        public int GetCommand()
        {
            return 1;
        }

        public Client CurrentClient = new Client("default", "default");
        public bool IsInformationShown = false;


        public void ShowCurrentClient(Client currentClient)
        {
            CurrentClient = currentClient;
        }

        public void ShowInterfaceInformation()
        {
            IsInformationShown = true;
        }
    }
}
