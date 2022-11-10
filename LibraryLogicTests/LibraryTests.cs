﻿using LibraryLogic;
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

        [Fact]

        public void Rent_available_book()
        {
            //arrange
            Work work = new Work("Му-му", "Тургенев", "Рассказ", 0);
            Book book = new Book(new List<Work>() { work},100, new DateTime(2022,1,1));
            Client client = new Client("Иван", "Иванов");
            DateTime dateOfRent = new DateTime(2022, 1, 1, 13, 00, 00);

            Library sut = new Library(new List<Book>() { book});

            Rent expected = new Rent(client, book, dateOfRent, TimeSpan.Zero );
            //act

            Rent actual = sut.Rent(book, client, dateOfRent);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
