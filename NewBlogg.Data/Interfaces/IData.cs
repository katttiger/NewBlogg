using NewBlogg.Common.Classes;
using NewBlogg.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Data.Interfaces
{
    public interface IData
    {
        //TODO: Add more content
        int nextTitleId {  get; }
        int nextPostId {  get; }
        int nextAuthorId {  get; }
        int nextContentId {  get; }

    }
}
