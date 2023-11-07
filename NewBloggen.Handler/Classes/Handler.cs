using NewBlogg.Data.Interfaces;
using NewBlogg.Common.Interfaces;
using NewBlogg.Common.Classes;

namespace NewBlogg.Handler.Classes
{
    public class Handler
    {
        string error = string.Empty;
        public Author Author { get; set; }

        private readonly IData _db;

        public Handler(IData db) => _db = db;

        //Get posts
        public IEnumerable<IPost> GetPosts() => _db.Get<IPost>(null);

        public Author GetAuthor(int authorId)
        {
            try
            {
                if (authorId != null && authorId != 0)
                {
                    var author = _db.Get<Author>(null);
                    Author = (Author)author;
                }
                else
                    throw new Exception();
                return Author;
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        }
        //Get post
        public IPost GetPost(int postId)
        {
            var post = _db.Single<IPost>(p => p.Id.Equals(postId));
            try
            {
                if (post is null)
                    throw new ArgumentException();
                return post;
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        }

        public void AddPost(string title, string content, Author author)
        {
            Post post = new(_db.nextPostId, title, author, content);
            _db.Add<IPost>(post);
        }

        //Remove post

        //Sort posts

    }
}