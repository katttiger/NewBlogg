using NewBlogg.Common.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Common.Interfaces
{
    public interface IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IAuthor Author { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
