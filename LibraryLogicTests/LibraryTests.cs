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
        public void Adding_client_is_successful()
        {
            //Arrange
            Library library = new Library(new List<Book>());
            Client newClient = new Client("Иван", "Иванов");

            //Act
            library.AddClient(newClient);

            //Assert
            Assert.Contains(newClient, library.Clients);
        }

        [Fact]
        public void Adding_null_client_is_impossible()
        {
            //Arrange
            Library library = new Library(new List<Book>());

            //Act
            Assert.Throws<ArgumentNullException>(()=> library.AddClient(null));        
        }
    }
}
