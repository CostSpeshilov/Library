namespace LibraryLogic
{
    public class Work
    {
        public Work(string name, string author, string genre, int ageRestriction)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                throw new ArgumentException($"\"{nameof(genre)}\" не может быть пустым или содержать только пробел.", nameof(genre));
            }

            Name = name;
            Author = author;
            Genre = genre;
            AgeRestriction = ageRestriction;
        }

        public string Name { get; }
        public string Author { get; }
        public string Genre { get; }
        public int AgeRestriction { get; }
    }
}