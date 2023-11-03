using NewBlogg.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlogg.Common.Classes
{
    public class Title : IStart
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Title(int id, string text) =>
            (Id, Text) = (id, text);
    }
}
