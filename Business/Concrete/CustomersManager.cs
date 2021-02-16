using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersService
    {
        ICustomersDal _customersDal;

        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public IResult AddCustomer(Customers customer)
        {
            _customersDal.Add(customer);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult DeleteCustomer(Customers customer)
        {
            _customersDal.Delete(customer);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomersDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customersDal.GetCustomerDetailDtos(),Messages.SuccessMessage);
        }

        public IResult UpdateCustomer(Customers customer)
        {
            _customersDal.Update(customer);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
