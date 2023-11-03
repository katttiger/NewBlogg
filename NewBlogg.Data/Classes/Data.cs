using NewBlogg.Common.Interfaces;
using NewBlogg.Data.Interfaces;

namespace NewBlogg.Data.Classes
{
    public class Data : IData
        //TODO: Implement interface
        //Add methods (generic and non-generic)
    {
        readonly List<IPost> _posts = new List<IPost>();

    }
}