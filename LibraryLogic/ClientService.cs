using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public class ClientService
    {
        IClientServiceUI _userInterface;
        Library Library;
        Client? currentClient;
        public ClientService(IClientServiceUI userInterface, Library library)
        {
            _userInterface = userInterface ?? throw new ArgumentNullException(nameof(userInterface));
            Library = library ?? throw new ArgumentNullException(nameof(library));
        }

        public void EnterService()
        {
            _userInterface.ShowInterfaceInformation();
            int commandId = _userInterface.GetCommand();
            if (commandId == 1)
            {
                Login(_userInterface.Name, _userInterface.Surname);
            }
            else
            {
                Register(_userInterface.Name, _userInterface.Surname);
            }
        }

        private void Register(string name, string surname)
        {
            Client client = new Client(name, surname);
            Library.AddClient(client);
            currentClient = client;
            _userInterface.ShowCurrentClient(currentClient);
        }

        private void Login(string name, string surname)
        {            
            currentClient = Library.Clients.First(x => x.Name == name && x.SurName == surname);
            _userInterface.ShowCurrentClient(currentClient);
        }


    }
}
