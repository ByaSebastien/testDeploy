using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDeploy.Domain.Models;

namespace testDeploy.DAL.Datas
{
    public class FakeDB
    {
        public static List<Book> books = new List<Book>()
        {
            new Book("9780345538376", "1984", "Nineteen Eighty-Four, often published as 1984, is a dystopian novel by English writer George Orwell."),
            new Book("9780061120084", "To Kill a Mockingbird", "To Kill a Mockingbird is a novel by Harper Lee."),
            new Book("9780141187761", "Animal Farm", "Animal Farm is an allegorical novella by George Orwell."),
            new Book("9780060256654", "Where the Wild Things Are", "Where the Wild Things Are is a children's picture book by American writer and illustrator Maurice Sendak."),
            new Book("9780590353427", "Harry Potter and the Philosopher's Stone", "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J.K. Rowling."),
            new Book("9780062315007", "The Catcher in the Rye", "The Catcher in the Rye is a novel by J. D. Salinger."),
            new Book("9780141439563", "Pride and Prejudice", "Pride and Prejudice is a romantic novel of manners written by Jane Austen."),
            new Book("9780679720201", "One Hundred Years of Solitude", "One Hundred Years of Solitude is a landmark 1967 novel by Colombian author Gabriel García Márquez."),
            new Book("9781451673319", "The Great Gatsby", "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald."),
            new Book("9780062073488", "The Hobbit", "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien.")
        };
    }
}
