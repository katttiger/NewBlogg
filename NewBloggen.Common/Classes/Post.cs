using NewBlogg.Common.Interfaces;

namespace NewBlogg.Common.Classes
{
    public class Post:IPost
    {
        public int Id { get; set; }
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }
        public DateTime DatePosted { get; set; }
        public Post(int id, Title title, Author author, Content context) =>
            (Id, Title, Author, Content) = (id, title, author, context);
    }
}