namespace BookEnumerator;

internal class Book
{
    public Book(int isbn, string name)
    {
        ISBN = isbn;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public int ISBN {get; set;}
    public string Name {get; set;}
}