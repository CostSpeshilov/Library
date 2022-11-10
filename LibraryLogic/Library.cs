﻿namespace LibraryLogic
{
    public class Library
    {
        List<Book> books;

        public Library(List<Book> books)
        {
            this.books = books ?? throw new ArgumentNullException(nameof(books));
        }

        List<Client> clients = new List<Client>();
        List<Rent> rents  = new List<Rent>();

        public List<Book> Books { get => books.ToList(); }
        public List<Client> Clients { get => clients.ToList(); }
        internal List<Rent> Rents { get => rents.ToList(); }


        public void AddClient(Client client)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            clients.Add(client);
        }

        public Rent Rent(Book book, Client client, TimeSpan zero, DateTime dateOfRent)
        {
            if (books.Contains(book))
            {
                return new Rent(client, book, dateOfRent, zero);
            }
            throw new Exception();            
        }
    }
}
