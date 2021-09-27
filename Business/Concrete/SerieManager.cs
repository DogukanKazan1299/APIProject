using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SerieManager : ISerieService
    {
        private ISerieDal _serieDal;
        public SerieManager(ISerieDal serieDal)
        {
            _serieDal = serieDal;
        }
        public IResult Add(Serie serie)
        {
            _serieDal.Add(serie);
            return new SuccessResult(message: "Dizi Eklendi");
        }

        public IResult Delete(Serie serie)
        {
            _serieDal.Delete(serie);
            return new SuccessResult(message: "Dizi Silindi");
        }

        public IDataResult<List<Serie>> GetList()
        {
            return new SuccessDataResult<List<Serie>>(_serieDal.GetList().ToList());
        }

        public IResult Update(Serie serie)
        {
            _serieDal.Update(serie);
            return new SuccessResult(message: "Dizi Güncellendi");
        }
    }
}
