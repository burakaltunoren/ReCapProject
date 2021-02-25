using Business.Abstract;
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

        public void Add(Brand brand)        //Program.cs yazıldı
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)     //Program.cs yazıldı
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()         //Program.cs yazıldı
        {
           return _brandDal.GetAll();
        }

        public Brand GetById(int id)        //Program.cs yazıldı
        {
            return _brandDal.Get(p=>p.Id == id);
        }

        public void Update(Brand brand)     //Program.cs yazıldı
        {
            _brandDal.Update(brand);
        }


    }
}
