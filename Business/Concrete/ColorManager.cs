using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)        // Program.cs yazıldı.
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)     // Program.cs yazıldı.
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()         // Program.cs yazıldı.
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), true);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p=>p.Id == id), true);
        }

        public IResult Update(Color color)     // Program.cs yazıldı.
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }


    }
}
