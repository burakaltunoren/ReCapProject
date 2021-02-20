using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {
        public void Delete(int ıd)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.Id equals co.Id
                             join br in context.Brands
                             on ca.ColorId equals br.Id
                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 ColorName = co.ColorName,
                                 BrandName = br.BrandName,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();


            }
        }
    }
}
