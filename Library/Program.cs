using LibraryDataSource;
using LibraryLogic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BookRepository bookRepository = new BookRepository();
        Library f = new Library(bookRepository.GetBooks());

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

    
}