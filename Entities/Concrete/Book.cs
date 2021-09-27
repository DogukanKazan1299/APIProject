using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {

        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public int Point { get; set; }
        public int CategoryID { get; set; }


    }
}
