using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISerieService
    {
        IDataResult<List<Serie>> GetList();
        IResult Add(Serie serie);
        IResult Update(Serie serie);
        IResult Delete(Serie serie);
    }
}
