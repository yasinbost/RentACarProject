using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IColorServices
    {
        IResult Added(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int id);
    }
}
