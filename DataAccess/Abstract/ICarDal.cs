using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Car ile ilgili veritabanında yapacağım operasyonları (CRUD) içeren interface
    public interface ICarDal
    {
        // GetAll
        List<Car> GetAll();

        // Add
        void Add(Car car);

        // Update
        void Update(Car car);

        // Delete
        void Delete(Car car);

        // GetById
        Car GetById(int id);

    }
}
