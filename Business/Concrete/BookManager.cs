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
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(message: "Kitap Eklendi");
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(message: "Kitap Silindi");
        }

        public IDataResult<List<Book>> GetList()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetList().ToList());
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(message: "Kitap Güncellendi");
        }
    }
}
