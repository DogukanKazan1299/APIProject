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
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(message: "Film Eklendi");
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(message: "Film Silindi");
        }

        public IDataResult<Movie> GetById(int movieId)
        {
            return new SuccessDataResult<Movie>(_movieDal.Get(filter: x => x.MovieID == movieId));
        }

        public IDataResult<List<Movie>> GetList()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList().ToList());
            
        }

        public IDataResult<List<Movie>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList(x => x.CategoryID == categoryId).ToList());
            
        }

        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(message: "Film Güncellendi");
        }
    }
}
