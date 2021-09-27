using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Serie : IEntity
    {
        public int SerieID { get; set; }
        public string SerieName { get; set; }
        public string Director { get; set; }
        public int CategoryID { get; set; }
    }
}
