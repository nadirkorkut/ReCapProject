﻿using DataAccess.Abstract;
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
            _cars = new List<Car>()
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1988,DailyPrice=80000,Description="88 Model Mercedes"},
                new Car{CarId=2,BrandId=1,ColorId=1,ModelYear=2013,DailyPrice=250000,Description="Amg c180"},
                new Car{CarId=3,BrandId=2,ColorId=2,ModelYear=2016,DailyPrice=280000,Description="Volvo s60"},
                new Car{CarId=4,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=800000,Description="Volvo s90"},
                new Car{CarId=5,BrandId=3,ColorId=4,ModelYear=2014,DailyPrice=245000,Description="Wolksvagen Golf"},
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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
