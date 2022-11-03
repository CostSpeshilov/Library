using LibraryConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Library f = new Library(GetBooks());

        foreach (var book in f.Books)
        {
            Console.WriteLine($"{book.PageCount}-страничная книга, содержащая следующие произведения");
            foreach (var work in book.Works)
            {
                Console.WriteLine($"    {work.Name} автор: {work.Author}, жанр:{work.Genre}");
            }
        }

        Console.ReadLine();
    }

    private static List<Book> GetBooks()
    {
        return new List<Book>()
        {
            new Book(
                new List<Work>()
                {
                    new Work("Евгений Онегин", "Пушкин", "Роман", 0)
                },
                100,
                new DateTime(2005,0,0)
                ),
            new Book(
                new List<Work>()
                {
                    new Work("Мёртвые души", "Гоголь", "Поэма", 0)
                },
                400,
                new DateTime(2004,0,0)
                ),
            new Book(
                new List<Work>()
                {
                    new Work("12 стульев", "Ильф, Петров", "Роман", 0),
                    new Work("Золотой телёнок", "Ильф, Петров", "Роман", 0),
                },
                350,
                new DateTime(2003,0,0)
                )

        };
    }
}