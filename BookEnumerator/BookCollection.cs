//using System.Collections;

namespace BookEnumerator;

internal class BookCollection : IEnumerable<Book>, IEnumerator<Book>
{
    private List<Book> books= new List<Book>() ;
    private int pointer = -1;

    public void Add(Book book)
    {
        books.Add(book);
    }

    public object Current
    {
        get { return books[pointer]; }
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if (pointer < books.Count - 1)
        {
            pointer++;
            return true;
        }
        
        return false;
        
    }

    public void Reset()
    {
        pointer = -1;
    }

    public void Dispose()
    {
    }
    


}