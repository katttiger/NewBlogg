using NewBlogg.Common.Extensionmethods;
using NewBlogg.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Common.Classes
{
    public class Author : IAuthor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PostsPublished { get; set; }        
        public Author(int id, string fName, string lName) =>
            (Id, FirstName, LastName) = (id, fName, lName);
        public Author() { }
    }
}
