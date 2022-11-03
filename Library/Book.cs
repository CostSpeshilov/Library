namespace LibraryConsole
{
    internal class Book
    {
        private readonly List<Work> works;

        public Book(List<Work> works, int pageCount, DateTime publishYear)
        {
            this.works = works ?? throw new ArgumentNullException(nameof(works));

            if (pageCount > 0)
            {
                PageCount = pageCount;
            }
            PublishYear = publishYear;
        }

        public int PageCount { get; }
        public DateTime PublishYear { get;  }
        internal List<Work> Works => works.ToList();
    }
}