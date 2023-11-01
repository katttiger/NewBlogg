namespace NewBlogg.Common.Classes
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Author { get; set; } 
        public string Context{ get; set; }
        public Post(int id, string name, string author, string context)=>
            (Id, Name, Author, Context)=(id, name, author, context);
    }
}