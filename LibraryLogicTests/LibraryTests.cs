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

        [Fact]
        public void Rent_is_possible()
        {
            //Arrange
            Work work = new Work("Каштанка", "Чехов", "Рассказ", 0);
            Book book = new Book(new List<Work>() { work}, 50, new DateTime(2022,1,1));
            Client client = new Client("Пётр", "Петров");
            DateTime dateOfRent = new DateTime(2022, 1, 2);
            Rent expected = new Rent(client, book, dateOfRent, TimeSpan.Zero);

            Library sut = new Library(new List<Book>() { book});
            //Act

            Rent actual = sut.Rent(book, client, TimeSpan.Zero, dateOfRent);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Rent_of_unknown_book_is_impossible()
        {
            //Arrange
            Work work = new Work("Каштанка", "Чехов", "Рассказ", 0);
            Book book = new Book(new List<Work>() { work }, 50, new DateTime(2022, 1, 1));

            Book toRent = new Book(new List<Work>() { work }, 100, new DateTime(2002, 1, 1));

            Client client = new Client("Пётр", "Петров");
            DateTime dateOfRent = new DateTime(2022, 1, 2);
            Rent expected = new Rent(client, toRent, dateOfRent, TimeSpan.Zero);

            Library sut = new Library(new List<Book>() { book });
            //Act


            //Assert
            Assert.Throws<Exception>(() => sut.Rent(toRent, client, TimeSpan.Zero, dateOfRent));

        }

    }
}
