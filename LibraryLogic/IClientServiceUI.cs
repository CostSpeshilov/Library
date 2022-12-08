using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic
{
    public interface IClientServiceUI
    {
        string Name { get; }
        string Surname { get; }

        int GetCommand();
        void ShowCurrentClient(Client currentClient);
        void ShowInterfaceInformation();
    }
}
