using NewBlogg.Common.Classes;
using NewBlogg.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Data.Interfaces
{
    public interface IData
    {   
        //Get
        List<T> Get<T>(Expression<Func<T, bool>> expression);
        void Add<T>(T item);
        T Single<T>(Expression<Func<T, bool>> expression);

        //TODO: Add more content
         int nextPostId { get; }
        int nextAuthorId { get; }
        
    }
}
