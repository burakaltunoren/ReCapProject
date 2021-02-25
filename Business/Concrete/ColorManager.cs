﻿using Business.Abstract;
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

        public void Add(Color color)        // Program.cs yazıldı.
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)     // Program.cs yazıldı.
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()         // Program.cs yazıldı.
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(p=>p.Id == id);
        }

        public void Update(Color color)     // Program.cs yazıldı.
        {
            _colorDal.Update(color);
        }
    }
}
