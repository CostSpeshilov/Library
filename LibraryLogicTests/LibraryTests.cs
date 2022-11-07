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
        public void Successful_adding_of_client()
        {
            //arrange
            var sut = new Library(new List<Book>());
            var client = new Client("Иван", "Иванов");
            //act
            sut.AddClient(client);
            //assert
            Assert.Contains(client, sut.Clients);
        }

        [Fact]
        public void UnSuccessful_adding_of_client()
        {
            //arrange
            var sut = new Library(new List<Book>());
            //act
            
            //assert
            Assert.Throws<ArgumentNullException>(
                () => sut.AddClient(null)
                );
            Assert.Empty(sut.Clients);
        }
    }
}
