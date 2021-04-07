using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }
        
        public IResult AddColor(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }
        public IResult DeleteColor(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }
        public IResult UpdateColor(Color color)
        {
            IResult result = BusinessRules.Run(ColorExists(color.ColorId));
            if (result != null)
            {
                return result;
            }
            _colorDal.Update(color);
            return new SuccessResult();
        }
        private IResult ColorExists(int id)
        {
            if (_colorDal.Exists(c => c.ColorId == id))
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ColorNotFound);
        }
    }
}
