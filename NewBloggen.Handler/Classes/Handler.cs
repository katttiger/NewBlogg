using NewBlogg.Data.Interfaces;
using NewBlogg.Common.Interfaces;
using NewBlogg.Common.Classes;

namespace NewBlogg.Handler.Classes
{
    public class Handler
    {
        public string error = string.Empty;
        public bool showError;

        public Author Author = new();
        public Post Post = new();

        private readonly IData _db;

        public Handler(IData db) => _db = db;

        //Get posts
        public IEnumerable<IPost> GetPosts() => _db.Get<IPost>(null);

        public IEnumerable<IAuthor> GetAuthors() => _db.Get<Author>(null);

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

        public void AddPost(string title, string content, int authorId)
        {
            try
            {
                Post = new();
                if (_db.nextAuthorId != null && title != null && content != null && authorId != null && authorId != 0)
                {
                    Author = _db.Single<Author>(a => a.Id.Equals(authorId));
                    Post = new(_db.nextAuthorId, title, Author, content);
                    _db.Add<IPost>(Post);
                }
                else
                {
                    showError = true;
                    error = "Please fill all fields";
                }
                Post = new();
                Author = new();
            }
            catch (Exception)
            {
                throw new ArgumentNullException(error);
            }
        }
        public void AddAuthor(string fName, string lName)
        {
            try
            {
                Author = new();
                if (fName != null && lName != null)
                {
                    Author = new(_db.nextAuthorId, fName, lName);
                    _db.Add(Author);
                }
                else
                {
                    showError = true;
                    error = "Please fill all fields";
                }
                Author = new();
            }
            catch (Exception)
            {
                throw new ArgumentNullException(error);
            }

        }
        public void RemovePost(int postId)
        {
            var list = _db.Get<IPost>(null);
            if (list.Count.Equals(1))
                postId = 1;
            list.RemoveAt(postId);
            postId = 0;
        }

        //TODO: Fix delete function.
        public void RemoveAuthor(int authorId)
        {
            var list = _db.Get<Author>(null);
            try
            {
                if (list.Count.Equals(1))
                    authorId = 1;
                list.RemoveAt(authorId);
                authorId = 0;
            }
            catch (Exception)
            {
                error = "Could not remove author";
                throw new Exception();
            }
        }
        //Remove post

        //Sort posts

    }
}