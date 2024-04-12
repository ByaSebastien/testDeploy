using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDeploy.Domain.Models;

namespace testDeploy.DAL.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAll();
        public Book? GetByISBN(string isbn);
        public void Add(Book book);
        public void Update(string isbn, Book book);
        public void Delete(string isbn);
    }
}
