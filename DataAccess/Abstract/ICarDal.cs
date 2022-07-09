using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Car ile ilgili veritabanında yapacağım operasyonları (CRUD) içeren interface
    public interface ICarDal : IEntityRepository<Car>
    {
        // Data Access Object (Cross Table)
        List<CarDetailDto> GetCarDetails();
    }
}
