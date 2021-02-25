using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)        //Program.cs yazıldı
        {
            if (brand.BrandName.Length <3)
            {
                return new ErrorResult(Messages.InvalidName);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)     //Program.cs yazıldı
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()         //Program.cs yazıldı
        {
           return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), true);
        }

        public IDataResult<Brand> GetById(int id)        //Program.cs yazıldı
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == id), true);
        }

        public IResult Update(Brand brand)     //Program.cs yazıldı
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }


    }
}
