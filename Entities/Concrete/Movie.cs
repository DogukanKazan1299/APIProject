using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Movie : IEntity
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public int CategoryID { get; set; }
    }
}
