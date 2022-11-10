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
        public void Client_adding_is_successful()
        {
            //Arrange
            Client client = new Client("Иван", "Иванов");
            Library sut = new Library(new List<Book>());
            //Act
            sut.AddClient(client);
            //Assert
            Assert.Contains(client, sut.Clients);
        }

        [Fact]
        public void Client_adding_is_impossible()
        {
            //Arrange
            //Client client = new Client("Иван", "Иванов");
            Library sut = new Library(new List<Book>());
            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => sut.AddClient(null));
            Assert.Empty(sut.Clients);
        }
    }
}
