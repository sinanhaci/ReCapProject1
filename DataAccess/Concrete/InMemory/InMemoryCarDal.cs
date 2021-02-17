using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=15000,ModelYear=1995,Description="Kaza Boya yok."},
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=23000,ModelYear=1998,Description="Hasar Kaydı var"},
                new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=31000,ModelYear=2002,Description="Öğretmenden Temiz"},
                new Car{Id=4,BrandId=4,ColorId=1,DailyPrice=90000,ModelYear=2017,Description="Temizlik boyası var, takla atmadı"},
                new Car{Id=5,BrandId=5,ColorId=1,DailyPrice=65000,ModelYear=2014,Description="Abi sen gel kuş çarp, tüm airbaglar gül gibi açıldı. Başka sorunu yok."},


            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void GetAll(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void GetByld(Car car)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
