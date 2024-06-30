using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay_4_part_2
{
    public class LibraryService
    {
        List<Book> books = new List<Book>();
        public void Create(int title, string author, string genre)
        {
            Book book = new Book();
            book.Title = title;
            book.Author = author;
            book.Genre = genre;
            books.Add(book);
        }
        public void Delete(int title)
        {
            var book = books.FirstOrDefault(x => x.Title == title);
            if (book != null)
            {
                books.Remove(book);
            }

        }
        public Book GetBook(int title)
        {
            return books.FirstOrDefault(x => x.Title == title);
        }
    }
}
