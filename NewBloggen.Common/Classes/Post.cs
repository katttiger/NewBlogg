using NewBlogg.Common.Interfaces;

namespace NewBlogg.Common.Classes
{
    public class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
   
        public Post()
        {

        }
        public Post(int id, string title, Author author, string context) =>
            (Id, Title, Author, Content) = (id, title, author, context);
    }
}