using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IDataResult<List<CarImages>> GetAll();
        IDataResult<CarImages> Get(int id);
        IResult Add(IFormFile file ,CarImages carImages);
        IResult Update(IFormFile file,CarImages carImages);
        IResult Delete(CarImages carImages);
        IDataResult<List<CarImages>> GetImagesByCarId(int id);
    }
}
