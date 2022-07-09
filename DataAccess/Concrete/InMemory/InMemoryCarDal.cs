using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, YearOfModel = 2011, DailyPrice=39150, Description="Chevrolet Cruze 1.6"},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, YearOfModel = 2021, DailyPrice=100000, Description="BMW M5 2.0"},
                new Car{CarId = 3, BrandId = 3, ColorId = 1, YearOfModel = 2021, DailyPrice=250000, Description="Ferrari 458 Italia 3.0"},
                new Car{CarId = 4, BrandId = 4, ColorId = 1, YearOfModel = 2006, DailyPrice=40000, Description="Renault Clio 1.4"},
                new Car{CarId = 5, BrandId = 1, ColorId = 1, YearOfModel = 2021, DailyPrice=12000, Description="Chevrolet Spark 1.2"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.YearOfModel = car.YearOfModel;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
