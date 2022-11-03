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
                    new Work("Евгений Онегин", "Пушкин", "Роман")
                },
                100
                ),
            new Book(
                new List<Work>()
                {
                    new Work("Мёртвые души", "Гоголь", "Поэма")
                },
                400
                ),
            new Book(
                new List<Work>()
                {
                    new Work("12 стульев", "Ильф, Петров", "Роман"),
                    new Work("Золотой телёнок", "Ильф, Петров", "Роман"),
                },
                350
                )

        };
    }
}