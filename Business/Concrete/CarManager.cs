﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()  // bu satırdaki GetCarDetails Business abstract -ICarService'den gelir.
        {
            return _carDal.GetCarDetails();    // Buradaki GetCarDetails ise ICarDal tarafından gelir.
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }


        public List<Car> GetCarsByCarId(int carId)
        {
            return _carDal.GetAll(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        
    }
}
