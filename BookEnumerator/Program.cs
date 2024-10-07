using BookEnumerator;

internal class Program
{
    static void Main(string[] args)
    {
        BookCollection books = new BookCollection();
        books.Add(new Book(1235, "red"));
        books.Add(new Book(1234, "blue"));
        books.Add(new Book(1536, "green"));
        books.Add(new Book(1737, "yellow"));

        // foreach (Book book in books)
        // {
        //     Console.WriteLine($"Books with ISBN {book.ISBN} is : {book.Name}");
        //
        // }
        // books.Reset();
        while (books.MoveNext())
        {
            Book book = (Book)books.Current;
            Console.WriteLine($"Books with ISBN {book.ISBN} is : {book.Name}");
        }

        Console.ReadLine();


    }
}