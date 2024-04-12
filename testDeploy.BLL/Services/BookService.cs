using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDeploy.DAL.Repositories.Interfaces;
using testDeploy.Domain.Models;

namespace testDeploy.BLL.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll() 
        { 
            return _bookRepository.GetAll(); 
        }

        public Book GetByISBN(string isbn) 
        { 
            Book? book = _bookRepository.GetByISBN(isbn); 
            if(book == null)
            {
                throw new KeyNotFoundException($"Book with isbn {isbn} doesn't exist.");
            }
            return book;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Update(string isbn, Book book)
        {
            _bookRepository.Update(isbn, book);
        }

        public void Delete(string isbn)
        {
            _bookRepository.Delete(isbn);
        }
    }
}
