using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IResult AddUser(Users user);
        IResult DeleteUser(Users user);
        IResult UpdateUser(Users user);
    }
}
