using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalsService
    {
        IResult AddRental(Rentals rental);
        IResult DeleteRental(Rentals rental);
        IResult UpdateRental(Rentals rental);
        IDataResult<List<Rentals>> GetAll();
    }
}
