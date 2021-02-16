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
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult AddUser(Users user)
        {
            _usersDal.Add(user);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult DeleteUser(Users user)
        {
            _usersDal.Delete(user);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll(),Messages.SuccessMessage);
        }

        public IResult UpdateUser(Users user)
        {
            _usersDal.Update(user);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
