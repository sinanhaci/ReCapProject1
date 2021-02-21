using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsId(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();


        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
