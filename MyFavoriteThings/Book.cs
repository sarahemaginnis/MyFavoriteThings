using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    internal enum BookGenre
    {
        Fantasy,
        ScienceFiction,
        Romance,
        Historical,
        FanFiction
    }
    internal class Book
    {
        public Book(string title, string author, string publisher, int pageCount, BookGenre genre)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            PageCount = pageCount;
            Genre = genre;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public BookGenre Genre { get; set; }
        public int CalculateProgress(int currentPageNumber)
        {
            return (currentPageNumber / PageCount);
        }
    }
}
