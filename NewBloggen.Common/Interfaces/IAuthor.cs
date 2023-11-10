using NewBlogg.Common.Extensionmethods;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Common.Interfaces
{
    public interface IAuthor
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int PostsPublished { get; set; }
    }
}
