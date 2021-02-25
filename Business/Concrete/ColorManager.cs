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

        public List<Color> GetAll()         // Program.cs yazıldı.
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(p=>p.Id == id);
        }

        public IResult Update(Color color)     // Program.cs yazıldı.
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
