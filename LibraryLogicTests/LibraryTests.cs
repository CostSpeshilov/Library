using LibraryLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicTests
{
    public class LibraryTests
    {
        [Fact]
        public void Add_Client_is_succesfull()
        {
            //arrange

            Library library = new Library(new List<Book>());
            //act
            Client client = new Client("Иван", "Иванов");
            library.AddClient(client);

            //assert

            Assert.Contains(client, library.Clients);
        }

        [Fact]
        public void Add_null_Client_is_impossible()
        {
            //arrange
            Library library = new Library(new List<Book>());
            //act
            //assert

            Assert.Throws<ArgumentNullException>(
                () => library.AddClient(null)
                );
        }
    }
}
