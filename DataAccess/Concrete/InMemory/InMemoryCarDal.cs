using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id = 1, BrandId = 1, ColorId = 1, YearOfModel = DateTime.Parse("2011,10,11"), DailyPrice=39150, Description="Chevrolet Cruze 1.6"},
                new Car{Id = 2, BrandId = 2, ColorId = 1, YearOfModel = DateTime.Parse("2021,10,11"), DailyPrice=100000, Description="BMW M5 2.0"},
                new Car{Id = 3, BrandId = 3, ColorId = 1, YearOfModel = DateTime.Parse("2021,5,11"), DailyPrice=250000, Description="Ferrari 458 Italia 3.0"},
                new Car{Id = 4, BrandId = 4, ColorId = 1, YearOfModel = DateTime.Parse("2006,7,11"), DailyPrice=40000, Description="Renault Clio 1.4"},
                new Car{Id = 5, BrandId = 1, ColorId = 1, YearOfModel = DateTime.Parse("2021,10,11"), DailyPrice=12000, Description="Chevrolet Spark 1.2"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.YearOfModel = car.YearOfModel;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }
    }
}
