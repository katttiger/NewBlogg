using NewBlogg.Common.Classes;
using NewBlogg.Common.Interfaces;
using NewBlogg.Data.Interfaces;
using System.Linq.Expressions;
using System.Reflection;

namespace NewBlogg.Data.Classes
{
    public class Data : IData
    //TODO: Implement interface
    //Add methods (generic and non-generic)
    //Add SeedData
    {
        readonly List<IPost> _posts = new List<IPost>();
        readonly List<Author> _authors = new List<Author>();
        public int nextPostId => _posts.Count.Equals(0) ? 1 : _posts.Max(b => b.Id) + 1;
        public int nextAuthorId => _authors.Count.Equals(0) ? 1 : _authors.Max(b => b.Id) + 1;

        public Data() => SeedData();
        public void SeedData()
        {

            Author Author1 = new Author(1, "Jane", "Doe");
            Author Author2 = new Author(2, "John", "Doe");


            Post post1 = new Post(1, "Title1", Author1, "content1");
            Post post2 = new Post(2, "Title2", Author2, "content2");

            _authors.Add(Author1);
            _authors.Add(Author2);

            _posts.Add(post1);
            _posts.Add(post2);

        }

        public List<T> Get<T>(Expression<Func<T, bool>> expression)
        {
            FieldInfo? fInfo = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance).
                FirstOrDefault(f => f.FieldType == typeof(List<T>));

            if (fInfo is not null)
            {
                var list = (List<T>)fInfo.GetValue(this);
                if(expression is not null)
                    list = list.Where(expression.Compile()).ToList();
                return list;
            }
            else
            {
                throw new Exception("Type could not be found");
            }

        }
        public void Add<T>(T item)
        {
            try
            {
                FieldInfo? fInfo = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                    .FirstOrDefault(f => f.FieldType == typeof(List<T>));

                if (fInfo is not null && item is not null)
                {
                    var list = (List<T>)fInfo.GetValue(this);
                    list.Add(item);
                }
                else
                {
                    throw new Exception("Type could not be found");
                }
            }
            catch (Exception)
            {

                throw new ArgumentNullException();
            }

        }
        public T Single<T>(Expression<Func<T, bool>> expression)
        {
            FieldInfo? fInfo = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance).
                FirstOrDefault(f => f.FieldType == typeof(List<T>));
            try
            {
                if (fInfo is not null)
                {
                    var list = (List<T>)fInfo.GetValue(this);
                    var item = list.SingleOrDefault(expression.Compile());
                    return item;
                }
                else
                    throw new Exception("Type could not be found");
            }
            catch (Exception)
            {

                throw new ArgumentNullException();
            }

        }
    }
}