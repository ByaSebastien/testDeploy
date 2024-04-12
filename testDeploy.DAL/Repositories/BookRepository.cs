using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDeploy.DAL.Datas;
using testDeploy.DAL.Repositories.Interfaces;
using testDeploy.Domain.Models;
using static testDeploy.DAL.Datas.FakeDB;

namespace testDeploy.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public Book? GetByISBN(string isbn)
        {
            return books.SingleOrDefault(b => b.ISBN == isbn);
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Update(string isbn, Book book)
        {
            Book? existingBook = books.SingleOrDefault(book => book.ISBN == isbn);
            if(existingBook == null)
            {
                throw new KeyNotFoundException($"Book with isbn {isbn} doesn't exist.");
            }
            existingBook.Title = book.Title;
            existingBook.Description = book.Description;
        }
        public void Delete(string isbn)
        {
            Book? existingBook = books.SingleOrDefault(book => book.ISBN == isbn);
            if (existingBook == null)
            {
                throw new KeyNotFoundException($"Book with isbn {isbn} doesn't exist.");
            }
            books.Remove(existingBook);
        }
    }
}
