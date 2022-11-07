using LibraryLogic;

namespace LibraryDataSource
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
        {
            new Book(
                new List<Work>()
                {
                    new Work("Евгений Онегин", "Пушкин", "Роман", 0)
                },
                100,
                new DateTime(2005,1,1)
                ),
            new Book(
                new List<Work>()
                {
                    new Work("Мёртвые души", "Гоголь", "Поэма", 0)
                },
                400,
                new DateTime(2004,1,1)
                ),
            new Book(
                new List<Work>()
                {
                    new Work("12 стульев", "Ильф, Петров", "Роман", 0),
                    new Work("Золотой телёнок", "Ильф, Петров", "Роман", 0),
                },
                350,
                new DateTime(2003,1,1)
                )

        };
        }
    }
}