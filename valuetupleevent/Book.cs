using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetupleevent
{
    class Book
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int ID { get; }
        private static int id;
        public Book()
        {
            ID = ++id;
        }
    }
}
