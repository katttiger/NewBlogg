using NewBlogg.Common.Classes;
using NewBlogg.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Common.Extensionmethods
{
    public static class ExMethods
    {
        public static int AuthorPosts(this List<IPost> posts, int authorId)
        {
            int nr = 0;
            foreach (var post in posts)
            {
                if(post.Author.Id==authorId)
                    nr++;
            }
            return nr;
        }
    }
}
