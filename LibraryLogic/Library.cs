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

        internal void AddRent(Client client, Book book, TimeSpan duration)
        {
            Rent rent = new Rent(client, book, DateTime.Now, duration);
            rents.Add(rent);
        }
    }
}
