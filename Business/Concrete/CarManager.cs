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
            if (car.DailyPrice <= 0 && car.Description.Length < 2)
            {
                throw new NotImplementedException("Ücret 0'dan büyük ve Açıklama iki karakterden uzun olmalıdır.");
            }

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

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(b => b.Id == id);
        }

        public List<Car> GetCarsId(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }


    }
}