namespace LibraryConsole
{
    internal class Rent
    {
        internal Rent(Client client, Book book, DateTime dateOfRent, TimeSpan duration)
        {
            Client = client;
            Book = book;
            DateOfRent = dateOfRent;
            Duration = duration;
        }

        internal DateTime DateOfRent { get; }
        internal TimeSpan Duration { get; }
        internal Client Client { get; }
        internal Book Book { get; }

    }
}