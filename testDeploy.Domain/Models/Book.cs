using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDeploy.Domain.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Book() {}

        public Book(string iSBN, string title, string description) : this()
        {
            ISBN = iSBN;
            Title = title;
            Description = description;
        }
    }
}
