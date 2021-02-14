using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult  // hangi tipi dondurecegini belirtiriz.
    {

        T Data { get; }  // message ve succes iresult icinde var . ondan dolayi inherite ettik.

    }
}
