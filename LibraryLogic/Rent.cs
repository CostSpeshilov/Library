namespace LibraryLogic
{
    public struct Rent
    {
        public Rent(Client client, Book book, DateTime dateOfRent, TimeSpan duration)
        {
            Client = client;
            Book = book;
            DateOfRent = dateOfRent;
            Duration = duration;
        }

        public DateTime DateOfRent { get; }
        public TimeSpan Duration { get; }
        public Client Client { get; }
        public Book Book { get; }
    }
}