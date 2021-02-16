using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomersService
    {
        IDataResult<List<Customers>> GetAll();
        IResult AddCustomer(Customers customer);
        IResult DeleteCustomer(Customers customer);
        IResult UpdateCustomer(Customers customer);
        IDataResult<List<CustomerDetailDto>> GetCustomersDetails();
    }
}
