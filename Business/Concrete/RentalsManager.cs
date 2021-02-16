using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult AddRental(Rentals rental)
        {
            _rentalsDal.Add(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult DeleteRental(Rentals rental)
        {
            _rentalsDal.Delete(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(),Messages.SuccessMessage);
        }

        public IResult UpdateRental(Rentals rental)
        {
            _rentalsDal.Update(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
