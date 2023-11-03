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
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
