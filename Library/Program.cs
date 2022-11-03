using LibraryDataSource;
using LibraryLogic;
internal class Program
{
    private static void Main(string[] args)
    {
        BookRepository bookRepository = new BookRepository();

        Library library = new Library(bookRepository.GetBooks());

        foreach (var book in library.Books)
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