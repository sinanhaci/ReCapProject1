using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate > rental.ReturnDate && rental.RentDate != null)
            {
                return new ErrorResult(Messages.RentalError);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
            //if (rental.RentDate < rental.ReturnDate && rental.RentDate != null && rental.ReturnDate != null)
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId),Messages.RentalListedByCarId);
        }

        public IDataResult<List<Rental>> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId),Messages.RentalListedByCustomerId);
        }

        public IDataResult<List<Rental>> GetById(int Id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.Id == Id), Messages.RentalListedById);
        }

        public IResult Update(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                return new ErrorResult(Messages.RentalError);
            }

            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdate);
        }
    }
}
