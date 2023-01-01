using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCollection
{
    public class Collection
    {
        public List<Book> AllBooks { get; }
        public IEnumerable<Book> CompletedBooks => AllBooks.Where(p => p.Coins.All(m => m.Have));
        public IEnumerable<Book> IncompleteBooks => AllBooks.Where(p => !p.Coins.All(m => m.Have));
    
        public Collection()
        {
            AllBooks = new List<Book>();
        }

        public void AddBook(Book book)
        {
            AllBooks.Add(book);
        }
    }
}
